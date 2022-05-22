
namespace Northwind.UI.WinForms.Suppliers
{
  partial class Supplier
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
            System.Windows.Forms.Label AddressLabel;
            System.Windows.Forms.Label ContactTitleLabel;
            System.Windows.Forms.Label IdLabel;
            System.Windows.Forms.Label SupplierNameLabel;
            System.Windows.Forms.Label ContactNameLabel;
            System.Windows.Forms.Label CityLabel;
            System.Windows.Forms.Label RegionLabel;
            System.Windows.Forms.Label PostalCodeLabel;
            System.Windows.Forms.Label CountryLabel;
            System.Windows.Forms.Label PhoneLabel;
            System.Windows.Forms.Label FaxLabel;
            System.Windows.Forms.Label HomePageLabel;
            this.ApplyButton = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.RoleListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.SupplierNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactNameTextBox = new System.Windows.Forms.TextBox();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ReadWriteAuthorization1 = new Csla.Windows.ReadWriteAuthorization(this.components);
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.RegionTextBox = new System.Windows.Forms.TextBox();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.FaxTextBox = new System.Windows.Forms.TextBox();
            this.HomePageTextBox = new System.Windows.Forms.TextBox();
            this.ContactTitleTextBox = new System.Windows.Forms.TextBox();
            this.bindingSourceRefresh1 = new Csla.Windows.BindingSourceRefresh(this.components);
            this.SupplierTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            AddressLabel = new System.Windows.Forms.Label();
            ContactTitleLabel = new System.Windows.Forms.Label();
            IdLabel = new System.Windows.Forms.Label();
            SupplierNameLabel = new System.Windows.Forms.Label();
            ContactNameLabel = new System.Windows.Forms.Label();
            CityLabel = new System.Windows.Forms.Label();
            RegionLabel = new System.Windows.Forms.Label();
            PostalCodeLabel = new System.Windows.Forms.Label();
            CountryLabel = new System.Windows.Forms.Label();
            PhoneLabel = new System.Windows.Forms.Label();
            FaxLabel = new System.Windows.Forms.Label();
            HomePageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoleListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRefresh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierTitlesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(AddressLabel, false);
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new System.Drawing.Point(14, 146);
            AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new System.Drawing.Size(55, 15);
            AddressLabel.TabIndex = 8;
            AddressLabel.Text = "Address :";
            // 
            // ContactTitleLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(ContactTitleLabel, false);
            ContactTitleLabel.AutoSize = true;
            ContactTitleLabel.Location = new System.Drawing.Point(14, 113);
            ContactTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ContactTitleLabel.Name = "ContactTitleLabel";
            ContactTitleLabel.Size = new System.Drawing.Size(80, 15);
            ContactTitleLabel.TabIndex = 6;
            ContactTitleLabel.Text = "Contact Title :";
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
            // SupplierNameLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(SupplierNameLabel, false);
            SupplierNameLabel.AutoSize = true;
            SupplierNameLabel.Location = new System.Drawing.Point(14, 48);
            SupplierNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            SupplierNameLabel.Name = "SupplierNameLabel";
            SupplierNameLabel.Size = new System.Drawing.Size(100, 15);
            SupplierNameLabel.TabIndex = 2;
            SupplierNameLabel.Text = "Company Name :";
            // 
            // ContactNameLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(ContactNameLabel, false);
            ContactNameLabel.AutoSize = true;
            ContactNameLabel.Location = new System.Drawing.Point(14, 81);
            ContactNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ContactNameLabel.Name = "ContactNameLabel";
            ContactNameLabel.Size = new System.Drawing.Size(90, 15);
            ContactNameLabel.TabIndex = 4;
            ContactNameLabel.Text = "Contact Name :";
            // 
            // CityLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(CityLabel, false);
            CityLabel.AutoSize = true;
            CityLabel.Location = new System.Drawing.Point(14, 243);
            CityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new System.Drawing.Size(34, 15);
            CityLabel.TabIndex = 16;
            CityLabel.Text = "City :";
            // 
            // RegionLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(RegionLabel, false);
            RegionLabel.AutoSize = true;
            RegionLabel.Location = new System.Drawing.Point(14, 274);
            RegionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            RegionLabel.Name = "RegionLabel";
            RegionLabel.Size = new System.Drawing.Size(50, 15);
            RegionLabel.TabIndex = 18;
            RegionLabel.Text = "Region :";
            // 
            // PostalCodeLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(PostalCodeLabel, false);
            PostalCodeLabel.AutoSize = true;
            PostalCodeLabel.Location = new System.Drawing.Point(14, 316);
            PostalCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PostalCodeLabel.Name = "PostalCodeLabel";
            PostalCodeLabel.Size = new System.Drawing.Size(76, 15);
            PostalCodeLabel.TabIndex = 20;
            PostalCodeLabel.Text = "Postal Code :";
            // 
            // CountryLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(CountryLabel, false);
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new System.Drawing.Point(14, 345);
            CountryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new System.Drawing.Size(56, 15);
            CountryLabel.TabIndex = 22;
            CountryLabel.Text = "Country :";
            // 
            // PhoneLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(PhoneLabel, false);
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new System.Drawing.Point(14, 378);
            PhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new System.Drawing.Size(47, 15);
            PhoneLabel.TabIndex = 24;
            PhoneLabel.Text = "Phone :";
            // 
            // FaxLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(FaxLabel, false);
            FaxLabel.AutoSize = true;
            FaxLabel.Location = new System.Drawing.Point(17, 413);
            FaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            FaxLabel.Name = "FaxLabel";
            FaxLabel.Size = new System.Drawing.Size(31, 15);
            FaxLabel.TabIndex = 26;
            FaxLabel.Text = "Fax :";
            // 
            // HomePageLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(HomePageLabel, false);
            HomePageLabel.AutoSize = true;
            HomePageLabel.Location = new System.Drawing.Point(19, 448);
            HomePageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            HomePageLabel.Name = "HomePageLabel";
            HomePageLabel.Size = new System.Drawing.Size(75, 15);
            HomePageLabel.TabIndex = 28;
            HomePageLabel.Text = "Home Page :";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.ApplyButton, false);
            this.ApplyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ApplyButton.Location = new System.Drawing.Point(493, 45);
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
            this.Cancel_Button.Location = new System.Drawing.Point(493, 91);
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
            // SuppliersBindingSource
            // 
            this.SuppliersBindingSource.AllowNew = true;
            this.SuppliersBindingSource.DataSource = typeof(Northwind.Business.Logic.Suppliers.SupplierEdit);
            this.bindingSourceRefresh1.SetReadValuesOnChange(this.SuppliersBindingSource, true);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.AddressTextBox, true);
            this.AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SuppliersBindingSource, "Address", true));
            this.AddressTextBox.Location = new System.Drawing.Point(122, 143);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(312, 84);
            this.AddressTextBox.TabIndex = 9;
            // 
            // IdLabel1
            // 
            this.IdLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.IdLabel1, false);
            this.IdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SuppliersBindingSource, "SupplierID", true));
            this.IdLabel1.Location = new System.Drawing.Point(122, 15);
            this.IdLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(509, 27);
            this.IdLabel1.TabIndex = 1;
            this.IdLabel1.Visible = false;
            // 
            // SupplierNameTextBox
            // 
            this.SupplierNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.SupplierNameTextBox, true);
            this.SupplierNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SuppliersBindingSource, "CompanyName", true));
            this.SupplierNameTextBox.Location = new System.Drawing.Point(122, 45);
            this.SupplierNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SupplierNameTextBox.MaxLength = 0;
            this.SupplierNameTextBox.Name = "SupplierNameTextBox";
            this.SupplierNameTextBox.Size = new System.Drawing.Size(312, 23);
            this.SupplierNameTextBox.TabIndex = 3;
            // 
            // ContactNameTextBox
            // 
            this.ContactNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.ContactNameTextBox, true);
            this.ContactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SuppliersBindingSource, "ContactName", true));
            this.ContactNameTextBox.Location = new System.Drawing.Point(122, 78);
            this.ContactNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ContactNameTextBox.MaxLength = 0;
            this.ContactNameTextBox.Name = "ContactNameTextBox";
            this.ContactNameTextBox.Size = new System.Drawing.Size(312, 23);
            this.ContactNameTextBox.TabIndex = 5;
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider1.ContainerControl = this;
            this.ErrorProvider1.DataSource = this.SuppliersBindingSource;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.CityTextBox, true);
            this.CityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SuppliersBindingSource, "City", true));
            this.CityTextBox.Location = new System.Drawing.Point(123, 240);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(311, 23);
            this.CityTextBox.TabIndex = 17;
            // 
            // RegionTextBox
            // 
            this.RegionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.RegionTextBox, true);
            this.RegionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SuppliersBindingSource, "Region", true));
            this.RegionTextBox.Location = new System.Drawing.Point(122, 274);
            this.RegionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RegionTextBox.Name = "RegionTextBox";
            this.RegionTextBox.Size = new System.Drawing.Size(312, 23);
            this.RegionTextBox.TabIndex = 19;
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.PostalCodeTextBox, true);
            this.PostalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SuppliersBindingSource, "PostalCode", true));
            this.PostalCodeTextBox.Location = new System.Drawing.Point(123, 308);
            this.PostalCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(311, 23);
            this.PostalCodeTextBox.TabIndex = 21;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.CountryTextBox, true);
            this.CountryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SuppliersBindingSource, "Country", true));
            this.CountryTextBox.Location = new System.Drawing.Point(123, 342);
            this.CountryTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(311, 23);
            this.CountryTextBox.TabIndex = 23;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.PhoneTextBox, true);
            this.PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SuppliersBindingSource, "Phone", true));
            this.PhoneTextBox.Location = new System.Drawing.Point(123, 375);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(311, 23);
            this.PhoneTextBox.TabIndex = 25;
            // 
            // FaxTextBox
            // 
            this.FaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.FaxTextBox, true);
            this.FaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SuppliersBindingSource, "Fax", true));
            this.FaxTextBox.Location = new System.Drawing.Point(122, 410);
            this.FaxTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FaxTextBox.Name = "FaxTextBox";
            this.FaxTextBox.Size = new System.Drawing.Size(312, 23);
            this.FaxTextBox.TabIndex = 27;
            // 
            // HomePageTextBox
            // 
            this.HomePageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.HomePageTextBox, true);
            this.HomePageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SuppliersBindingSource, "HomePage", true));
            this.HomePageTextBox.Location = new System.Drawing.Point(122, 445);
            this.HomePageTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HomePageTextBox.Name = "HomePageTextBox";
            this.HomePageTextBox.Size = new System.Drawing.Size(312, 23);
            this.HomePageTextBox.TabIndex = 29;
            // 
            // ContactTitleTextBox
            // 
            this.ContactTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.ContactTitleTextBox, true);
            this.ContactTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SuppliersBindingSource, "ContactTitle", true));
            this.ContactTitleTextBox.Location = new System.Drawing.Point(122, 110);
            this.ContactTitleTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ContactTitleTextBox.MaxLength = 0;
            this.ContactTitleTextBox.Name = "ContactTitleTextBox";
            this.ContactTitleTextBox.Size = new System.Drawing.Size(312, 23);
            this.ContactTitleTextBox.TabIndex = 30;
            // 
            // bindingSourceRefresh1
            // 
            this.bindingSourceRefresh1.Host = this;
            // 
            // SupplierTitlesBindingSource
            // 
            this.SupplierTitlesBindingSource.AllowNew = false;
            this.bindingSourceRefresh1.SetReadValuesOnChange(this.SupplierTitlesBindingSource, false);
            // 
            // Supplier
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(this, false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ContactTitleTextBox);
            this.Controls.Add(this.HomePageTextBox);
            this.Controls.Add(HomePageLabel);
            this.Controls.Add(this.FaxTextBox);
            this.Controls.Add(FaxLabel);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(PhoneLabel);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(CountryLabel);
            this.Controls.Add(this.PostalCodeTextBox);
            this.Controls.Add(PostalCodeLabel);
            this.Controls.Add(this.RegionTextBox);
            this.Controls.Add(RegionLabel);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(CityLabel);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(AddressLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(ContactTitleLabel);
            this.Controls.Add(IdLabel);
            this.Controls.Add(SupplierNameLabel);
            this.Controls.Add(ContactNameLabel);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(this.SupplierNameTextBox);
            this.Controls.Add(this.ContactNameTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Supplier";
            this.Size = new System.Drawing.Size(776, 524);
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoleListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRefresh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierTitlesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    internal System.Windows.Forms.Button ApplyButton;
    internal System.Windows.Forms.Button Cancel_Button;
    internal System.Windows.Forms.TextBox AddressTextBox;
    internal System.Windows.Forms.Label IdLabel1;
    internal System.Windows.Forms.TextBox SupplierNameTextBox;
    internal System.Windows.Forms.TextBox ContactNameTextBox;
    internal Csla.Windows.ReadWriteAuthorization ReadWriteAuthorization1;
    internal System.Windows.Forms.ErrorProvider ErrorProvider1;
    internal System.Windows.Forms.BindingSource RoleListBindingSource;
    private Csla.Windows.BindingSourceRefresh bindingSourceRefresh1;
        internal System.Windows.Forms.TextBox CityTextBox;
        internal System.Windows.Forms.TextBox HomePageTextBox;
        internal System.Windows.Forms.TextBox FaxTextBox;
        internal System.Windows.Forms.TextBox PhoneTextBox;
        internal System.Windows.Forms.TextBox CountryTextBox;
        internal System.Windows.Forms.TextBox PostalCodeTextBox;
        internal System.Windows.Forms.TextBox RegionTextBox;
        private System.Windows.Forms.BindingSource SupplierTitlesBindingSource;
        private System.Windows.Forms.BindingSource SuppliersBindingSource;
        internal System.Windows.Forms.TextBox ContactTitleTextBox;
    }
}
