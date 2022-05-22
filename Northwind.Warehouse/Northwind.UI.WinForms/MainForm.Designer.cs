namespace Northwind.UI.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ProductsToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.NewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuppliersToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.NewSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdiSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriesToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.NewCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.LoginToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductsToolStripDropDownButton,
            this.SuppliersToolStripDropDownButton,
            this.CategoriesToolStripDropDownButton,
            this.LoginToolStripLabel,
            this.LoginToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(965, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // ProductsToolStripDropDownButton
            // 
            this.ProductsToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewProductToolStripMenuItem,
            this.EditProductToolStripMenuItem,
            this.DeleteProductToolStripMenuItem});
            this.ProductsToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProductsToolStripDropDownButton.Name = "ProductsToolStripDropDownButton";
            this.ProductsToolStripDropDownButton.Size = new System.Drawing.Size(67, 22);
            this.ProductsToolStripDropDownButton.Text = "Products";
            // 
            // NewProductToolStripMenuItem
            // 
            this.NewProductToolStripMenuItem.Name = "NewProductToolStripMenuItem";
            this.NewProductToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NewProductToolStripMenuItem.Text = "New product";
            this.NewProductToolStripMenuItem.Click += new System.EventHandler(this.NewProductToolStripMenuItem_Click);
            // 
            // EditProductToolStripMenuItem
            // 
            this.EditProductToolStripMenuItem.Name = "EditProductToolStripMenuItem";
            this.EditProductToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.EditProductToolStripMenuItem.Text = "Edit product";
            this.EditProductToolStripMenuItem.Click += new System.EventHandler(this.EditProductToolStripMenuItem_Click);
            // 
            // DeleteProductToolStripMenuItem
            // 
            this.DeleteProductToolStripMenuItem.Name = "DeleteProductToolStripMenuItem";
            this.DeleteProductToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteProductToolStripMenuItem.Text = "Delete product";
            this.DeleteProductToolStripMenuItem.Click += new System.EventHandler(this.DeleteProductToolStripMenuItem_Click);
            // 
            // SuppliersToolStripDropDownButton
            // 
            this.SuppliersToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewSupplierToolStripMenuItem,
            this.EdiSupplierToolStripMenuItem,
            this.DeleteSupplierToolStripMenuItem});
            this.SuppliersToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SuppliersToolStripDropDownButton.Name = "SuppliersToolStripDropDownButton";
            this.SuppliersToolStripDropDownButton.Size = new System.Drawing.Size(68, 22);
            this.SuppliersToolStripDropDownButton.Text = "Suppliers";
            // 
            // NewSupplierToolStripMenuItem
            // 
            this.NewSupplierToolStripMenuItem.Name = "NewSupplierToolStripMenuItem";
            this.NewSupplierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NewSupplierToolStripMenuItem.Text = "New supplier";
            this.NewSupplierToolStripMenuItem.Click += new System.EventHandler(this.NewSupplierToolStripMenuItem_Click);
            // 
            // EdiSupplierToolStripMenuItem
            // 
            this.EdiSupplierToolStripMenuItem.Name = "EdiSupplierToolStripMenuItem";
            this.EdiSupplierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.EdiSupplierToolStripMenuItem.Text = "Edit supplier";
            this.EdiSupplierToolStripMenuItem.Click += new System.EventHandler(this.EditSupplierToolStripMenuItem_Click);
            // 
            // DeleteSupplierToolStripMenuItem
            // 
            this.DeleteSupplierToolStripMenuItem.Name = "DeleteSupplierToolStripMenuItem";
            this.DeleteSupplierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteSupplierToolStripMenuItem.Text = "Delete supplier";
            this.DeleteSupplierToolStripMenuItem.Click += new System.EventHandler(this.DeleteSupplierToolStripMenuItem_Click);
            // 
            // CategoriesToolStripDropDownButton
            // 
            this.CategoriesToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewCategoryToolStripMenuItem,
            this.EditCategoryToolStripMenuItem,
            this.DeleteCategoryToolStripMenuItem});
            this.CategoriesToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CategoriesToolStripDropDownButton.Name = "CategoriesToolStripDropDownButton";
            this.CategoriesToolStripDropDownButton.Size = new System.Drawing.Size(76, 22);
            this.CategoriesToolStripDropDownButton.Text = "Categories";
            // 
            // NewCategoryToolStripMenuItem
            // 
            this.NewCategoryToolStripMenuItem.Name = "NewCategoryToolStripMenuItem";
            this.NewCategoryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.NewCategoryToolStripMenuItem.Text = "New category";
            this.NewCategoryToolStripMenuItem.Click += new System.EventHandler(this.NewCategoryToolStripMenuItem_Click);
            // 
            // EditCategoryToolStripMenuItem
            // 
            this.EditCategoryToolStripMenuItem.Name = "EditCategoryToolStripMenuItem";
            this.EditCategoryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.EditCategoryToolStripMenuItem.Text = "Edit category";
            this.EditCategoryToolStripMenuItem.Click += new System.EventHandler(this.EditCategoryToolStripMenuItem_Click);
            // 
            // DeleteCategoryToolStripMenuItem
            // 
            this.DeleteCategoryToolStripMenuItem.Name = "DeleteCategoryToolStripMenuItem";
            this.DeleteCategoryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.DeleteCategoryToolStripMenuItem.Text = "Delete category";
            this.DeleteCategoryToolStripMenuItem.Click += new System.EventHandler(this.DeleteCategoryToolStripMenuItem_Click);
            // 
            // LoginToolStripLabel
            // 
            this.LoginToolStripLabel.Name = "LoginToolStripLabel";
            this.LoginToolStripLabel.Size = new System.Drawing.Size(103, 22);
            this.LoginToolStripLabel.Text = "Login Status Label";
            // 
            // LoginToolStripButton
            // 
            this.LoginToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoginToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoginToolStripButton.Name = "LoginToolStripButton";
            this.LoginToolStripButton.Size = new System.Drawing.Size(41, 22);
            this.LoginToolStripButton.Text = "Login";
            this.LoginToolStripButton.Click += new System.EventHandler(this.LoginToolStripButton_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 25);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(965, 457);
            this.Panel1.TabIndex = 2;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 460);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(965, 22);
            this.StatusStrip1.TabIndex = 3;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 482);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = " Northwind Warehouse";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.ToolStripDropDownButton ProductsToolStripDropDownButton;
        internal System.Windows.Forms.ToolStripMenuItem NewProductToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditProductToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DeleteProductToolStripMenuItem;
        internal System.Windows.Forms.ToolStripDropDownButton CategoriesToolStripDropDownButton;
        internal System.Windows.Forms.ToolStripMenuItem NewCategoryToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditCategoryToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DeleteCategoryToolStripMenuItem;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        internal System.Windows.Forms.ToolStripDropDownButton SuppliersToolStripDropDownButton;
        internal System.Windows.Forms.ToolStripMenuItem NewSupplierToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EdiSupplierToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DeleteSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel LoginToolStripLabel;
        private System.Windows.Forms.ToolStripButton LoginToolStripButton;
    }
}