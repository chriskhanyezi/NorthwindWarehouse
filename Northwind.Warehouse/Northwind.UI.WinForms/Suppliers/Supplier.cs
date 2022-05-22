using System;
using System.ComponentModel;
using System.Windows.Forms;
using Csla.Rules;
using Northwind.Business.Logic.Suppliers;

namespace Northwind.UI.WinForms.Suppliers
{
    public partial class Supplier : WinPart
    {
        #region Properties
        public SupplierEdit SupplierBO { get; private set; }

        protected internal override object GetIdValue()
        {
            return SupplierBO;
        }

        public override string ToString()
        {
            return !String.IsNullOrEmpty(SupplierBO.CompanyName) ? SupplierBO.CompanyName : "New supplier";
        }

        #endregion

        #region Change event handlers
        private void SupplierBO_CurrentPrincipalChanged(object sender, EventArgs e)
        {
            ApplyAuthorizationRules();
        }

        private void SupplierBO_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsDirty")
            {
                this.SuppliersBindingSource.ResetBindings(true);
            }
        }

        #endregion

        #region Constructors

        private Supplier()
        {
        }

        public Supplier(SupplierEdit supplier)
        {
            InitializeComponent();

            SupplierBO = supplier;
        }

        #endregion

        #region Load
        private void Supplier_Load(object sender, EventArgs e)
        {
            this.CurrentPrincipalChanged += new EventHandler(SupplierBO_CurrentPrincipalChanged);
            SupplierBO.PropertyChanged += new PropertyChangedEventHandler(SupplierBO_PropertyChanged);

            Setup();
            //SetupTitleComboxOnLoad();
        }

        private void Setup()
        {
            // set up binding
            BindUI();
            ApplyAuthorizationRules();
        }

        private void ApplyAuthorizationRules()
        {
            bool canEdit = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.EditObject, typeof(SupplierEdit));

            if (!canEdit)
                RebindUI(false, true);

            // have the controls enable/disable/etc
            this.ReadWriteAuthorization1.ResetControlAuthorization();

            // enable/disable appropriate buttons
            this.ApplyButton.Enabled = canEdit;
        }

        private void BindUI()
        {
            SupplierBO.BeginEdit();
            this.SuppliersBindingSource.DataSource = SupplierBO;
        }

        private bool RebindUI(bool saveObject, bool rebind)
        {
            // disable events
            this.SuppliersBindingSource.RaiseListChangedEvents = false;

            try
            {
                // unbind the UI
                UnbindBindingSource(this.SuppliersBindingSource, saveObject, true);

                // save or cancel changes
                if (saveObject)
                {
                    SupplierBO.ApplyEdit();

                    try
                    {
                        SupplierBO = SupplierBO.Save();
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
                    SupplierBO.CancelEdit();

                return true;
            }
            finally
            {
                // rebind UI if requested
                if (rebind)
                    BindUI();

                // restore events
                this.SuppliersBindingSource.RaiseListChangedEvents = true;

                if (rebind)
                {
                    // refresh the UI if rebinding
                    this.SuppliersBindingSource.ResetBindings(false);
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
            if (SupplierBO.IsSavable)
                return true;

            if (!SupplierBO.IsValid)
            {
                MessageBox.Show(GetErrorMessage(), "Saving Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private string GetErrorMessage()
        {
            var message = "Supplier is invalid and cannot be saved." + Environment.NewLine + Environment.NewLine;
            foreach (var rule in SupplierBO.BrokenRulesCollection)
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
    }
}