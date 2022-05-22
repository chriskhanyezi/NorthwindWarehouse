using Northwind.Business.Logic.Categories;

namespace Northwind.UI.WinForms.Categories
{
    partial class Category
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
            System.Windows.Forms.Label CategoryNameLabel;
            System.Windows.Forms.Label IdLabel;
            System.Windows.Forms.Label DescriptionLabel;
            System.Windows.Forms.Label CategoryPictureBoxLabel;
            this.ApplyButton = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.RoleListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel1 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ReadWriteAuthorization1 = new Csla.Windows.ReadWriteAuthorization(this.components);
            this.CategoryPictureBox = new System.Windows.Forms.PictureBox();
            this.SelectPictureButton = new System.Windows.Forms.Button();
            this.bindingSourceRefresh1 = new Csla.Windows.BindingSourceRefresh(this.components);
            CategoryNameLabel = new System.Windows.Forms.Label();
            IdLabel = new System.Windows.Forms.Label();
            DescriptionLabel = new System.Windows.Forms.Label();
            CategoryPictureBoxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoleListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRefresh1)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryNameLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(CategoryNameLabel, false);
            CategoryNameLabel.AutoSize = true;
            CategoryNameLabel.Location = new System.Drawing.Point(15, 48);
            CategoryNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CategoryNameLabel.Name = "CategoryNameLabel";
            CategoryNameLabel.Size = new System.Drawing.Size(93, 15);
            CategoryNameLabel.TabIndex = 2;
            CategoryNameLabel.Text = "Category Name:";
            // 
            // IdLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(IdLabel, false);
            IdLabel.AutoSize = true;
            IdLabel.Location = new System.Drawing.Point(15, 15);
            IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new System.Drawing.Size(20, 15);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "Id:";
            IdLabel.Visible = false;
            // 
            // DescriptionLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(DescriptionLabel, false);
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new System.Drawing.Point(15, 78);
            DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new System.Drawing.Size(73, 15);
            DescriptionLabel.TabIndex = 4;
            DescriptionLabel.Text = "Description :";
            // 
            // CategoryPictureBoxLabel
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(CategoryPictureBoxLabel, false);
            CategoryPictureBoxLabel.AutoSize = true;
            CategoryPictureBoxLabel.Location = new System.Drawing.Point(15, 213);
            CategoryPictureBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CategoryPictureBoxLabel.Name = "CategoryPictureBoxLabel";
            CategoryPictureBoxLabel.Size = new System.Drawing.Size(46, 15);
            CategoryPictureBoxLabel.TabIndex = 13;
            CategoryPictureBoxLabel.Text = "Image :";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.ApplyButton, false);
            this.ApplyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ApplyButton.Location = new System.Drawing.Point(584, 41);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(88, 27);
            this.ApplyButton.TabIndex = 8;
            this.ApplyButton.Text = "Save";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.Cancel_Button, false);
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(584, 82);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(88, 27);
            this.Cancel_Button.TabIndex = 9;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // RoleListBindingSource
            // 
            this.bindingSourceRefresh1.SetReadValuesOnChange(this.RoleListBindingSource, false);
            // 
            // CategoryBindingSource
            // 
            this.CategoryBindingSource.DataSource = typeof(Northwind.Business.Logic.Categories.CategoryEdit);
            this.bindingSourceRefresh1.SetReadValuesOnChange(this.CategoryBindingSource, true);
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.CategoryNameTextBox, true);
            this.CategoryNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CategoryBindingSource, "CategoryName", true));
            this.CategoryNameTextBox.Location = new System.Drawing.Point(116, 45);
            this.CategoryNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(425, 23);
            this.CategoryNameTextBox.TabIndex = 3;
            // 
            // IdLabel1
            // 
            this.IdLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.IdLabel1, true);
            this.IdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CategoryBindingSource, "CategoryID", true));
            this.IdLabel1.Location = new System.Drawing.Point(116, 15);
            this.IdLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel1.Name = "IdLabel1";
            this.IdLabel1.Size = new System.Drawing.Size(426, 27);
            this.IdLabel1.TabIndex = 1;
            this.IdLabel1.Visible = false;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.DescriptionTextBox, true);
            this.DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CategoryBindingSource, "Description", true));
            this.DescriptionTextBox.Location = new System.Drawing.Point(116, 75);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(425, 101);
            this.DescriptionTextBox.TabIndex = 5;
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider1.ContainerControl = this;
            this.ErrorProvider1.DataSource = this.CategoryBindingSource;
            // 
            // CategoryPictureBox
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.CategoryPictureBox, false);
            this.CategoryPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CategoryPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CategoryPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.CategoryBindingSource, "Picture", true));
            this.CategoryPictureBox.Enabled = false;
            this.CategoryPictureBox.Location = new System.Drawing.Point(116, 191);
            this.CategoryPictureBox.Name = "CategoryPictureBox";
            this.CategoryPictureBox.Size = new System.Drawing.Size(232, 145);
            this.CategoryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CategoryPictureBox.TabIndex = 12;
            this.CategoryPictureBox.TabStop = false;
            // 
            // SelectPictureButton
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(this.SelectPictureButton, false);
            this.SelectPictureButton.Location = new System.Drawing.Point(364, 191);
            this.SelectPictureButton.Name = "SelectPictureButton";
            this.SelectPictureButton.Size = new System.Drawing.Size(93, 25);
            this.SelectPictureButton.TabIndex = 14;
            this.SelectPictureButton.Text = "Choose Image";
            this.SelectPictureButton.UseVisualStyleBackColor = true;
            this.SelectPictureButton.Click += new System.EventHandler(this.SelectPictureButton_Click);
            // 
            // bindingSourceRefresh1
            // 
            this.bindingSourceRefresh1.Host = this;
            // 
            // Category
            // 
            this.ReadWriteAuthorization1.SetApplyAuthorization(this, false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectPictureButton);
            this.Controls.Add(CategoryPictureBoxLabel);
            this.Controls.Add(this.CategoryPictureBox);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(CategoryNameLabel);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(IdLabel);
            this.Controls.Add(this.IdLabel1);
            this.Controls.Add(DescriptionLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Category";
            this.Size = new System.Drawing.Size(686, 479);
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoleListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRefresh1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button ApplyButton;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.TextBox CategoryNameTextBox;
        internal System.Windows.Forms.Label IdLabel1;
        internal System.Windows.Forms.TextBox DescriptionTextBox;
        internal Csla.Windows.ReadWriteAuthorization ReadWriteAuthorization1;
        internal System.Windows.Forms.BindingSource RoleListBindingSource;
        internal System.Windows.Forms.BindingSource CategoryBindingSource;
        internal System.Windows.Forms.ErrorProvider ErrorProvider1;
        private Csla.Windows.BindingSourceRefresh bindingSourceRefresh1;
        private System.Windows.Forms.PictureBox CategoryPictureBox;
        private System.Windows.Forms.Button SelectPictureButton;
    }
}
