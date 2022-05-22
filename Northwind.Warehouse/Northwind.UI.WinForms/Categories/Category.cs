using Csla.Rules;
using Northwind.Business.Logic.Categories;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Northwind.UI.WinForms.Categories
{
    public partial class Category : WinPart
    {
        #region Properties
        public CategoryEdit CategoryBO { get; private set; }

        protected internal override object GetIdValue()
        {
            return CategoryBO;
        }

        public override string ToString()
        {
            return !String.IsNullOrEmpty(CategoryBO.CategoryName) ? CategoryBO.CategoryName : "New category";
        }
        #endregion

        #region Change event handlers
        private void CategoryBO_CurrentPrincipalChanged(object sender, EventArgs e)
        {
            ApplyAuthorizationRules();
        }

        private void CategoryBO_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsDirty")
            {
                this.CategoryBindingSource.ResetBindings(true);
            }
        }

        #endregion

        #region Constructors

        private Category()
        {
            // force to use parametrized constructor
        }

        public Category(CategoryEdit category)
        {
            InitializeComponent();
            CategoryBO = category;
        }

        #endregion

        #region Load

        private void Category_Load(object sender, EventArgs e)
        {
            this.CurrentPrincipalChanged += new EventHandler(CategoryBO_CurrentPrincipalChanged);
            CategoryBO.PropertyChanged += new PropertyChangedEventHandler(CategoryBO_PropertyChanged);
            Setup();
        }

        private void Setup()
        {
            BindUI();
            ApplyAuthorizationRules();
        }

        private void ApplyAuthorizationRules()
        {
            bool canEdit = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.EditObject,typeof(CategoryEdit));

            if (!canEdit)
                RebindUI(false, true);

            // have the controls enable/disable/etc
            this.ReadWriteAuthorization1.ResetControlAuthorization();

            // enable/disable appropriate buttons
            this.ApplyButton.Enabled = canEdit;
            this.SelectPictureButton.Enabled = canEdit;
        }

        private void BindUI()
        {
            CategoryBO.BeginEdit();
            this.CategoryBindingSource.DataSource = CategoryBO;
        }

        private bool RebindUI(bool saveObject, bool rebind)
        {
            // disable events
            this.CategoryBindingSource.RaiseListChangedEvents = false;
            try
            {
                // unbind the UI
                UnbindBindingSource(this.CategoryBindingSource, saveObject, true);

                // save or cancel changes
                if (saveObject)
                {
                    CategoryBO.ApplyEdit();
                    try
                    {
                        CategoryBO = CategoryBO.Save();
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
                    CategoryBO.CancelEdit();

                return true;
            }
            finally
            {
                // rebind UI if requested
                if (rebind)
                    BindUI();

                // restore events
                this.CategoryBindingSource.RaiseListChangedEvents = true;

                if (rebind)
                {
                    // refresh the UI if rebinding
                    this.CategoryBindingSource.ResetBindings(false);
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
                    Close();
                }
            }
        }

        private bool IsSavable()
        {
            if (CategoryBO.IsSavable)
                return true;

            if (!CategoryBO.IsValid)
            {
                MessageBox.Show(GetErrorMessage(), "Saving Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private string GetErrorMessage()
        {
            var message = "Category is invalid and cannot be saved." + Environment.NewLine + Environment.NewLine;
            foreach (var rule in CategoryBO.BrokenRulesCollection)
            {
                if (rule.Severity == RuleSeverity.Error)
                    message += "- " + rule.Description + Environment.NewLine;
            }

            return message;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            RebindUI(false, true);
            Close();
        }

        #endregion

        private void SelectPictureButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Title = "Choose Category Image", Filter = "All files (*.*)|*.*", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Image img = Image.FromFile(ofd.FileName);
                        CategoryPictureBox.Image = img;
                        CategoryBO.Picture = ConvertImageToBinary(img);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


    }
}