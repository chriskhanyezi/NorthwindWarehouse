
namespace Northwind.UI.WinForms.Products
{
  partial class Product
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label CategoryLabel;
            System.Windows.Forms.Label IdLabel;
            System.Windows.Forms.Label ProductNameLabel;
            System.Windows.Forms.Label SupplierLabel;
            System.Windows.Forms.Label QuantityPerUnitLabel;
            System.Windows.Forms.Label UnitPriceLabel;
            System.Windows.Forms.Label UnitsInStockLabel;
            System.Windows.Forms.Label UnitsOnOrderLabel;
            System.Windows.Forms.Label ReorderLevelLabel;
            System.Windows.Forms.Label DiscontinuedLabel;
            this.ApplyButton = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.RoleListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ReadWriteAuthorization1 = new Csla.Windows.ReadWriteAuthorization(this.components);
            this.QuantityPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.UnitsInStockTextBox = new System.Windows.Forms.TextBox();
            this.UnitsOrderTextBox = new System.Windows.Forms.TextBox();
            this.ReOrderTextBox = new System.Windows.Forms.TextBox();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.DiscontinuedCheckBox = new System.Windows.Forms.CheckBox();
            this.bindingSourceRefresh1 = new Csla.Windows.BindingSourceRefresh(this.components);
            CategoryLabel = new System.Windows.Forms.Label();
            IdLabel = new System.Windows.Forms.Label();
            ProductNameLabel = new System.Windows.Forms.Label();
            SupplierLabel = new System.Windows.Forms.Label();
            QuantityPerUnitLabel = new System.Windows.Forms.Label();
            UnitPriceLabel = new System.Windows.Forms.Label();
            UnitsInStockLabel = new System.Windows.Forms.Label();
            UnitsOnOrderLabel = new System.Windows.Forms.Label();
            ReorderLevelLabel = new System.Windows.Forms.Label();
            DiscontinuedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoleListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRefresh1)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(CategoryLabel, false);
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new System.Drawing.Point(14, 108);
            CategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new System.Drawing.Size(61, 15);
            CategoryLabel.TabIndex = 6;
            CategoryLabel.Text = "Category :";
            // 
            // IdLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(IdLabel, false);
            IdLabel.AutoSize = true;
            IdLabel.Location = new System.Drawing.Point(14, 15);
            IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new System.Drawing.Size(20, 15);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "Id:";
            IdLabel.Visible = false;
            // 
            // ProductNameLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(ProductNameLabel, false);
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new System.Drawing.Point(14, 48);
            ProductNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new System.Drawing.Size(90, 15);
            ProductNameLabel.TabIndex = 2;
            ProductNameLabel.Text = "Product Name :";
            // 
            // SupplierLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(SupplierLabel, false);
            SupplierLabel.AutoSize = true;
            SupplierLabel.Location = new System.Drawing.Point(14, 78);
            SupplierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            SupplierLabel.Name = "SupplierLabel";
            SupplierLabel.Size = new System.Drawing.Size(56, 15);
            SupplierLabel.TabIndex = 4;
            SupplierLabel.Text = "Supplier :";
            // 
            // QuantityPerUnitLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(QuantityPerUnitLabel, false);
            QuantityPerUnitLabel.AutoSize = true;
            QuantityPerUnitLabel.Location = new System.Drawing.Point(14, 140);
            QuantityPerUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            QuantityPerUnitLabel.Name = "QuantityPerUnitLabel";
            QuantityPerUnitLabel.Size = new System.Drawing.Size(104, 15);
            QuantityPerUnitLabel.TabIndex = 16;
            QuantityPerUnitLabel.Text = "Quantity Per Unit :";
            // 
            // UnitPriceLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(UnitPriceLabel, false);
            UnitPriceLabel.AutoSize = true;
            UnitPriceLabel.Location = new System.Drawing.Point(14, 187);
            UnitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            UnitPriceLabel.Name = "UnitPriceLabel";
            UnitPriceLabel.Size = new System.Drawing.Size(64, 15);
            UnitPriceLabel.TabIndex = 18;
            UnitPriceLabel.Text = "Unit Price :";
            // 
            // UnitsInStockLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(UnitsInStockLabel, false);
            UnitsInStockLabel.AutoSize = true;
            UnitsInStockLabel.Location = new System.Drawing.Point(14, 219);
            UnitsInStockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            UnitsInStockLabel.Name = "UnitsInStockLabel";
            UnitsInStockLabel.Size = new System.Drawing.Size(85, 15);
            UnitsInStockLabel.TabIndex = 20;
            UnitsInStockLabel.Text = "Units In Stock :";
            // 
            // UnitsOnOrderLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(UnitsOnOrderLabel, false);
            UnitsOnOrderLabel.AutoSize = true;
            UnitsOnOrderLabel.Location = new System.Drawing.Point(17, 251);
            UnitsOnOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            UnitsOnOrderLabel.Name = "UnitsOnOrderLabel";
            UnitsOnOrderLabel.Size = new System.Drawing.Size(92, 15);
            UnitsOnOrderLabel.TabIndex = 22;
            UnitsOnOrderLabel.Text = "Units On Order :";
            // 
            // ReorderLevelLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(ReorderLevelLabel, false);
            ReorderLevelLabel.AutoSize = true;
            ReorderLevelLabel.Location = new System.Drawing.Point(14, 290);
            ReorderLevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ReorderLevelLabel.Name = "ReorderLevelLabel";
            ReorderLevelLabel.Size = new System.Drawing.Size(84, 15);
            ReorderLevelLabel.TabIndex = 24;
            ReorderLevelLabel.Text = "Reorder Level :";
            // 
            // DiscontinuedLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(DiscontinuedLabel, false);
            DiscontinuedLabel.AutoSize = true;
            DiscontinuedLabel.Location = new System.Drawing.Point(17, 330);
            DiscontinuedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DiscontinuedLabel.Name = "DiscontinuedLabel";
            DiscontinuedLabel.Size = new System.Drawing.Size(83, 15);
            DiscontinuedLabel.TabIndex = 29;
            DiscontinuedLabel.Text = "Discontinued :";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.ApplyButton, false);
            this.ApplyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ApplyButton.Location = new System.Drawing.Point(674, 45);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(88, 27);
            this.ApplyButton.TabIndex = 12;
            this.ApplyButton.Text = "Save";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.Cancel_Button, false);
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(674, 82);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(88, 27);
            this.Cancel_Button.TabIndex = 13;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // RoleListBindingSource
            // 
            this.bindingSourceRefresh1.SetReadValuesOnChange(this.RoleListBindingSource, false);
            // 
            // ProductBindingSource
            // 
            this.ProductBindingSource.DataSource = typeof(Northwind.Business.Logic.Products.ProductEdit);
            this.bindingSourceRefresh1.SetReadValuesOnChange(this.ProductBindingSource, true);
            // 
            // IdLabel1
            // 
            this.IdLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.IdLabel1, false);
            this.IdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "ProductID", true));
            this.IdLabel1.Location = new System.Drawing.Point(94, 15);
            this.IdLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(537, 27);
            this.IdLabel1.TabIndex = 1;
            this.IdLabel1.Visible = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.NameTextBox, true);
            this.NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "ProductName", true));
            this.NameTextBox.Location = new System.Drawing.Point(125, 45);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(505, 23);
            this.NameTextBox.TabIndex = 3;
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider1.ContainerControl = this;
            this.ErrorProvider1.DataSource = this.ProductBindingSource;
            // 
            // QuantityPerUnitTextBox
            // 
            this.QuantityPerUnitTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.QuantityPerUnitTextBox, true);
            this.QuantityPerUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "QuantityPerUnit", true));
            this.QuantityPerUnitTextBox.Location = new System.Drawing.Point(126, 145);
            this.QuantityPerUnitTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.QuantityPerUnitTextBox.Name = "QuantityPerUnitTextBox";
            this.QuantityPerUnitTextBox.Size = new System.Drawing.Size(505, 23);
            this.QuantityPerUnitTextBox.TabIndex = 17;
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.UnitPriceTextBox, true);
            this.UnitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "UnitPrice", true));
            this.UnitPriceTextBox.Location = new System.Drawing.Point(125, 184);
            this.UnitPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.Size = new System.Drawing.Size(505, 23);
            this.UnitPriceTextBox.TabIndex = 19;
            // 
            // UnitsInStockTextBox
            // 
            this.UnitsInStockTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.UnitsInStockTextBox, true);
            this.UnitsInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "UnitsInStock", true));
            this.UnitsInStockTextBox.Location = new System.Drawing.Point(125, 216);
            this.UnitsInStockTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UnitsInStockTextBox.Name = "UnitsInStockTextBox";
            this.UnitsInStockTextBox.Size = new System.Drawing.Size(505, 23);
            this.UnitsInStockTextBox.TabIndex = 21;
            // 
            // UnitsOrderTextBox
            // 
            this.UnitsOrderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.UnitsOrderTextBox, true);
            this.UnitsOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "UnitsOnOrder", true));
            this.UnitsOrderTextBox.Location = new System.Drawing.Point(125, 251);
            this.UnitsOrderTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UnitsOrderTextBox.Name = "UnitsOrderTextBox";
            this.UnitsOrderTextBox.Size = new System.Drawing.Size(505, 23);
            this.UnitsOrderTextBox.TabIndex = 23;
            // 
            // ReOrderTextBox
            // 
            this.ReOrderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.ReOrderTextBox, true);
            this.ReOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductBindingSource, "ReorderLevel", true));
            this.ReOrderTextBox.Location = new System.Drawing.Point(125, 290);
            this.ReOrderTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReOrderTextBox.Name = "ReOrderTextBox";
            this.ReOrderTextBox.Size = new System.Drawing.Size(505, 23);
            this.ReOrderTextBox.TabIndex = 25;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.SupplierComboBox, false);
            this.SupplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(125, 75);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(505, 23);
            this.SupplierComboBox.TabIndex = 26;
            this.SupplierComboBox.SelectedIndexChanged += new System.EventHandler(this.SupplierComboBox_SelectedIndexChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.CategoryComboBox, false);
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(126, 108);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(505, 23);
            this.CategoryComboBox.TabIndex = 28;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // DiscontinuedCheckBox
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.DiscontinuedCheckBox, false);
            this.DiscontinuedCheckBox.AutoSize = true;
            this.DiscontinuedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ProductBindingSource, "Discontinued", true));
            this.DiscontinuedCheckBox.Location = new System.Drawing.Point(125, 333);
            this.DiscontinuedCheckBox.Name = "DiscontinuedCheckBox";
            this.DiscontinuedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DiscontinuedCheckBox.TabIndex = 30;
            this.DiscontinuedCheckBox.UseVisualStyleBackColor = true;
            // 
            // bindingSourceRefresh1
            // 
            this.bindingSourceRefresh1.Host = this;
            // 
            // Product
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(this, false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DiscontinuedCheckBox);
            this.Controls.Add(DiscontinuedLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.SupplierComboBox);
            this.Controls.Add(ReorderLevelLabel);
            this.Controls.Add(this.ReOrderTextBox);
            this.Controls.Add(UnitsOnOrderLabel);
            this.Controls.Add(this.UnitsOrderTextBox);
            this.Controls.Add(UnitsInStockLabel);
            this.Controls.Add(this.UnitsInStockTextBox);
            this.Controls.Add(UnitPriceLabel);
            this.Controls.Add(this.UnitPriceTextBox);
            this.Controls.Add(QuantityPerUnitLabel);
            this.Controls.Add(this.QuantityPerUnitTextBox);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(CategoryLabel);
            this.Controls.Add(IdLabel);
            this.Controls.Add(ProductNameLabel);
            this.Controls.Add(SupplierLabel);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.NameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(776, 524);
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoleListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRefresh1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    internal System.Windows.Forms.Button ApplyButton;
    internal System.Windows.Forms.Button Cancel_Button;
    internal System.Windows.Forms.Label IdLabel1;
    internal System.Windows.Forms.TextBox NameTextBox;
    internal Csla.Windows.ReadWriteAuthorization ReadWriteAuthorization1;
    internal System.Windows.Forms.ErrorProvider ErrorProvider1;
    internal System.Windows.Forms.BindingSource ProductBindingSource;
    internal System.Windows.Forms.BindingSource RoleListBindingSource;
    private Csla.Windows.BindingSourceRefresh bindingSourceRefresh1;
        internal System.Windows.Forms.TextBox ReOrderTextBox;
        internal System.Windows.Forms.TextBox UnitsOrderTextBox;
        internal System.Windows.Forms.TextBox UnitsInStockTextBox;
        internal System.Windows.Forms.TextBox UnitPriceTextBox;
        internal System.Windows.Forms.TextBox QuantityPerUnitTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.CheckBox DiscontinuedCheckBox;
    }
}
