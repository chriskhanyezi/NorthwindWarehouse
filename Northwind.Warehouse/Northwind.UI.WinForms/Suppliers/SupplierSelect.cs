using Northwind.Business.Logic.Suppliers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Northwind.UI.WinForms.Suppliers
{
  public partial class SupplierSelect : Form
  {
    private int _supplierId;

    public int SupplierId
        {
      get { return _supplierId; }
    }

    public SupplierSelect()
    {
      InitializeComponent();
    }

    private void OK_Button_Click(object sender, EventArgs e)
    {
      _supplierId = (int) this.SuppliersListListBox.SelectedValue;
      this.Close();
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void SupplierSelect_Load(object sender, EventArgs e)
    {
      DisplayList(SupplierList.GetSupplierList());
    }

    private void DisplayList(SupplierList list)
    {
      var sortedList = from p in list where p.Id != -1 orderby p.Name select p;
      this.suppliersListBindingSource.DataSource = sortedList;
    }

    private void GetListButton_Click(object sender, EventArgs e)
    {
      DisplayList(SupplierList.GetSupplierList(NameTextBox.Text));
    }

    private void SuppliersListListBox_DoubleClick(object sender, EventArgs e)
    {
      _supplierId = (int) this.SuppliersListListBox.SelectedValue;
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }
}