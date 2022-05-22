using Csla.Rules;
using Northwind.Business.Logic.Categories;
using Northwind.Business.Logic.Products;
using Northwind.Business.Logic.Suppliers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Northwind.UI.WinForms.Products
{
    public partial class Product : WinPart
    {
        #region Properties

        public ProductEdit ProductBO { get; private set; }

        protected internal override object GetIdValue()
        {
            return ProductBO;
        }

        public override string ToString()
        {
            return !String.IsNullOrEmpty(ProductBO.ProductName) ? ProductBO.ProductName : "New product";
        }

        #endregion

        #region Change event handlers
        private void ProductBO_CurrentPrincipalChanged(object sender, EventArgs e)
        {
            ApplyAuthorizationRules();
        }

        private void ProductBO_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsDirty")
            {
                this.ProductBindingSource.ResetBindings(true);
            }
        }

        #endregion

        #region Constructors

        private Product()
        {
            // force to use parametrized constructor
        }

        public Product(ProductEdit product)
        {
            InitializeComponent();

            // store object reference
            ProductBO = product;
        }

        #endregion

        #region Load

        private void Product_Load(object sender, EventArgs e)
        {
            this.CurrentPrincipalChanged += new EventHandler(ProductBO_CurrentPrincipalChanged);
            ProductBO.PropertyChanged += new PropertyChangedEventHandler(ProductBO_PropertyChanged);
            Setup();
            SetUpDropdownlists();
        }

        private void Setup()
        {
            // set up binding
            BindUI();
            ApplyAuthorizationRules();
        }

        private void ApplyAuthorizationRules()
        {
            bool canEdit = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.EditObject, typeof(ProductEdit));

            if (!canEdit)
                RebindUI(false, true);

            // have the controls enable/disable/etc
            this.ReadWriteAuthorization1.ResetControlAuthorization();

            // enable/disable appropriate buttons
            this.ApplyButton.Enabled = canEdit;
            this.SupplierComboBox.Enabled = canEdit;
            this.CategoryComboBox.Enabled = canEdit;
        }

        private void SetUpDropdownlists() 
        {
            SupplierComboBox.DataSource = SupplierList.GetSupplierList();

            if (ProductBO.SupplierID.HasValue)
            {
                SupplierComboBox.SelectedIndex = ProductBO.SupplierID.Value;
            }

            CategoryComboBox.DataSource = CategoryList.GetCategoryList();

            if (ProductBO.CategoryID.HasValue)
            {
                CategoryComboBox.SelectedIndex = ProductBO.CategoryID.Value;
            }
        }

        private void BindUI()
        {
            ProductBO.BeginEdit();
            this.ProductBindingSource.DataSource = ProductBO;
        }

        private bool RebindUI(bool saveObject, bool rebind)
        {
            // disable events
            this.ProductBindingSource.RaiseListChangedEvents = false;
            try
            {
                // unbind the UI
                UnbindBindingSource(this.ProductBindingSource, saveObject, true);

                // save or cancel changes
                if (saveObject)
                {
                    ProductBO.ApplyEdit();
                    try
                    {
                        ProductBO = ProductBO.Save();
                    }
                    catch (Csla.DataPortalException ex)
                    {
                        MessageBox.Show(ex.BusinessException.ToString(), "Error saving", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                else
                    ProductBO.CancelEdit();

                return true;
            }
            finally
            {
                // rebind UI if requested
                if (rebind)
                    BindUI();

                // restore events
                this.ProductBindingSource.RaiseListChangedEvents = true;

                if (rebind)
                {
                    // refresh the UI if rebinding
                    this.ProductBindingSource.ResetBindings(false);
                }
            }
        }

        #endregion

        #region Button event handlers

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (IsSavable())
            {
                using (StatusBusy busy = new StatusBusy("Saving..."))
                {
                    RebindUI(true, true);
                    this.Close();
                }
            }
        }

        private bool IsSavable()
        {
            if (ProductBO.IsSavable)
                return true;

            if (!ProductBO.IsValid)
            {
                MessageBox.Show(GetErrorMessage(), "Saving Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private string GetErrorMessage()
        {
            var message = "Product is invalid and cannot be saved." + Environment.NewLine + Environment.NewLine;
            foreach (var rule in ProductBO.BrokenRulesCollection)
            {
                if (rule.Severity == RuleSeverity.Error)
                    message += "- " + rule.Description + Environment.NewLine;
            }

            return message;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            RebindUI(false, true);
            this.Close();
        }

        #endregion

        private void SupplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SupplierComboBox.SelectedIndex != 0)
            {
                ProductBO.SupplierID = SupplierComboBox.SelectedIndex;
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex != 0)
            {
                ProductBO.CategoryID = CategoryComboBox.SelectedIndex;
            }
        }
    }
}