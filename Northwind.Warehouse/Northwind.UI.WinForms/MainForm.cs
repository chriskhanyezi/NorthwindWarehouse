using System;
using System.Windows.Forms;
using Northwind.Business.Logic.Products;
using Northwind.Business.Logic.Suppliers;
using Northwind.UI.WinForms.Products;
using Northwind.UI.WinForms.Categories;
using Northwind.Business.Logic.Categories;
using Northwind.UI.WinForms.Suppliers;
using Northwind.Business.Logic.Security;
using System.Collections.Generic;

namespace Northwind.UI.WinForms
{
    public partial class MainForm : Form
    {
        private static MainForm _main;

        internal static MainForm Instance
        {
            get { return _main; }
        }

        public MainForm()
        {
            InitializeComponent();
            _main = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DoLogin();
        }

        #region Products
        private void NewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StatusBusy busy = new StatusBusy("Creating product..."))
            {
                AddWinPart(new Product(ProductEdit.NewProductEdit()));
            }
        }

        private void EditProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ProductSelect dlg = new ProductSelect())
            {
                dlg.Text = "Select Product";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ShowEditProduct(dlg.ProductId);
                }
            }
        }

        public void ShowEditProduct(int productId)
        {
            //  see if this product is already loaded

            foreach (Control ctl in Panel1.Controls)
            {
                if (ctl is Product)
                {
                    Product part = (Product)ctl;
                    if (part.ProductBO.ProductID.Equals(productId))
                    {
                        // product already loaded so just
                        // display the existing winpart
                        ShowWinPart(part);
                        return;
                    }
                }
            }

            // the product wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy busy = new StatusBusy("Loading product..."))
            {
                try
                {
                    AddWinPart(new Product(ProductEdit.GetProductEdit(productId)));
                }
                catch (Csla.DataPortalException ex)
                {
                    MessageBox.Show(ex.BusinessException.ToString(), "Error loading", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error loading", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private async void DeleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductSelect dlg = new ProductSelect();
            dlg.Text = "Delete Product";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // get the product id
                var productId = dlg.ProductId;

                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete project",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    using (StatusBusy busy = new StatusBusy("Deleting product..."))
                    {
                        try
                        {
                            await ProductEdit.DeleteProductEditAsync(productId);
                        }
                        catch (Csla.DataPortalException ex)
                        {
                            MessageBox.Show(ex.BusinessException.ToString(), "Error deleting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error deleting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        #endregion

        #region Categories

        private void NewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StatusBusy busy = new StatusBusy("Creating category..."))
            {
                AddWinPart(new Category(CategoryEdit.NewCategoryEdit()));
            }
        }

        private void EditCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategorySelect dlg = new CategorySelect();
            dlg.Text = "Select Category";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // get the category id
                ShowEditCategory(dlg.CategoryId);
            }
        }

        public void ShowEditCategory(int categoryId)
        {
            // see if this category is already loaded
            foreach (Control ctl in Panel1.Controls)
            {
                if (ctl is Category)
                {
                    Category part = (Category)ctl;
                    if (part.CategoryBO.CategoryID.Equals(categoryId))
                    {
                        // category already loaded so just
                        // display the existing winpart
                        ShowWinPart(part);
                        return;
                    }
                }
            }

            //// the category wasn't already loaded
            //// so load it and display the new winpart
            using (StatusBusy busy = new StatusBusy("Loading category..."))
            {
                try
                {
                    AddWinPart(new Category(CategoryEdit.GetCategoryEdit(categoryId)));
                }
                catch (Csla.DataPortalException ex)
                {
                    MessageBox.Show(ex.BusinessException.ToString(), "Error loading", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error loading", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void DeleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategorySelect dlg = new CategorySelect();
            dlg.Text = "Delete Category";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // get the category id
                int categoryId = dlg.CategoryId;

                if (MessageBox.Show("Are you sure you to delete this category?", "Delete category", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    using (StatusBusy busy = new StatusBusy("Deleting category..."))
                    {
                        try
                        {
                            CategoryEdit.DeleteCategoryEdit(categoryId);
                        }
                        catch (Csla.DataPortalException ex)
                        {
                            MessageBox.Show(ex.BusinessException.ToString(), "Error deleting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error deleting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }
        #endregion
         
        #region Suppliers

        private void NewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StatusBusy busy = new StatusBusy("Creating supplier..."))
            {
                AddWinPart(new Supplier(SupplierEdit.NewSupplierEdit()));
            }
        }

        private void EditSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierSelect dlg = new SupplierSelect();
            dlg.Text = "Select Supplier";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ShowEditSupplier(dlg.SupplierId);
            }
        }

        public void ShowEditSupplier(int supplierId)
        {
            // see if this supplier is already loaded
            foreach (Control ctl in Panel1.Controls)
            {
                if (ctl is Supplier)
                {
                    Supplier part = (Supplier)ctl;
                    if (part.SupplierBO.SupplierID.Equals(supplierId))
                    {
                        ShowWinPart(part);
                        return;
                    }
                }
            }

            // the supplier wasn't already loaded
            // so load it and display the new winpart
            using (StatusBusy busy = new StatusBusy("Loading supplier..."))
            {
                try
                {
                    AddWinPart(new Supplier(SupplierEdit.GetSupplierEdit(supplierId)));
                }
                catch (Csla.DataPortalException ex)
                {
                    MessageBox.Show(ex.BusinessException.ToString(), "Error loading", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error loading", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void DeleteSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierSelect dlg = new SupplierSelect();
            dlg.Text = "Delete Supplier";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // get the supplier id
                int supplierId = dlg.SupplierId;

                if (MessageBox.Show("Are you sure you to delete this supplier?", "Delete supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    using (StatusBusy busy = new StatusBusy("Deleting Supplier..."))
                    {
                        try
                        {
                            SupplierEdit.DeleteSupplierEdit(supplierId);
                        }
                        catch (Csla.DataPortalException ex)
                        {
                            MessageBox.Show(ex.BusinessException.ToString(), "Error deleting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error deleting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }
        #endregion

        #region Login/Logout

        private void LoginToolStripButton_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void DoLogin()
        {
            PTPrincipal.Logout();

            if (this.LoginToolStripButton.Text == "Login")
            {
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog(this);
            }

            System.Security.Principal.IPrincipal user = Csla.ApplicationContext.User;

            if (user.Identity.IsAuthenticated)
            {
                ProductsToolStripDropDownButton.Visible = true;
                SuppliersToolStripDropDownButton.Visible = true;
                CategoriesToolStripDropDownButton.Visible = true;

                this.LoginToolStripLabel.Text = "Logged in as " + user.Identity.Name;
                this.LoginToolStripButton.Text = "Logout";
            }

            else
            {
                ProductsToolStripDropDownButton.Visible = false;
                SuppliersToolStripDropDownButton.Visible = false;
                CategoriesToolStripDropDownButton.Visible = false;

                this.LoginToolStripLabel.Text = "Not logged in";
                this.LoginToolStripButton.Text = "Login";
            }

            // reset menus, etc.
            ApplyAuthorizationRules();

            // notify all documents
            List<object> tmpList = new List<object>();
            foreach (var ctl in Panel1.Controls)
                tmpList.Add(ctl);
            foreach (var ctl in tmpList)
                if (ctl is WinPart)
                    ((WinPart)ctl).OnCurrentPrincipalChanged(this, EventArgs.Empty);
        }

        #endregion

        #region ApplyAuthorizationRules

        private void ApplyAuthorizationRules()
        {
            // Product menu
            this.NewProductToolStripMenuItem.Visible = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.CreateObject, typeof(ProductEdit));
            this.EditProductToolStripMenuItem.Visible = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.GetObject, typeof(ProductEdit));
            if (Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.EditObject, typeof(ProductEdit)))
                this.EditProductToolStripMenuItem.Text = "Edit Product";
            else
                this.EditProductToolStripMenuItem.Text = "View Products";
            this.DeleteProductToolStripMenuItem.Visible = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.DeleteObject, typeof(ProductEdit));

            // Supplier menu
            this.NewSupplierToolStripMenuItem.Visible = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.CreateObject, typeof(SupplierEdit));
            this.EdiSupplierToolStripMenuItem.Visible = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.GetObject, typeof(SupplierEdit));
            if (Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.EditObject, typeof(SupplierEdit)))
                this.EdiSupplierToolStripMenuItem.Text = "Edit Supplier";
            else
                this.EdiSupplierToolStripMenuItem.Text = "View Suppliers";
            this.DeleteSupplierToolStripMenuItem.Visible = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.DeleteObject, typeof(SupplierEdit));

            // Category menu
            this.NewCategoryToolStripMenuItem.Visible = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.CreateObject, typeof(CategoryEdit));
            this.EditCategoryToolStripMenuItem.Visible = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.GetObject, typeof(CategoryEdit));
            if (Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.EditObject, typeof(CategoryEdit)))
                this.EditCategoryToolStripMenuItem.Text = "Edit Category";
            else
                this.EditCategoryToolStripMenuItem.Text = "View Categories";
            this.DeleteCategoryToolStripMenuItem.Visible = Csla.Rules.BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.DeleteObject, typeof(CategoryEdit));
        }

        #endregion

        #region WinPart handling

        /// <summary>
        /// Add a new WinPart control to the
        /// make it the active WinPart.
        /// </summary>
        /// <param name="part">The WinPart control to add and display.</param>
        private void AddWinPart(WinPart part)
        {
            part.CloseWinPart += new EventHandler(CloseWinPart);
            part.BackColor = toolStrip1.BackColor;
            Panel1.Controls.Add(part);
            ShowWinPart(part);
        }

        /// <summary>
        /// Make the specified WinPart the 
        /// active, displayed control.
        /// </summary>
        /// <param name="part">The WinPart control to display.</param>
        private void ShowWinPart(WinPart part)
        {
            part.Dock = DockStyle.Fill;
            part.Visible = true;
            part.BringToFront();
            this.Text = "Northwind Warehouse - " + part.ToString();
        }

        /// <summary>
        /// Handles event from WinPart when that
        /// WinPart is closing.
        /// </summary>
        private void CloseWinPart(object sender, EventArgs e)
        {
            WinPart part = (WinPart)sender;
            part.CloseWinPart -= new EventHandler(CloseWinPart);
            part.Visible = false;
            Panel1.Controls.Remove(part);
            part.Dispose();

            foreach (Control ctl in Panel1.Controls)
            {
                if (ctl is WinPart)
                {
                    this.Text = "Northwind Warehouse - " + ((WinPart)ctl).ToString();
                    break;
                }
            }

            if (Panel1.Controls.Count == 0)
            {
                this.Text = "Northwind Warehouse";
            }
        }
        #endregion
    }
}