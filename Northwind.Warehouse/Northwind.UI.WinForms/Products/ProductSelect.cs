using Northwind.Business.Logic.Products;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Northwind.UI.WinForms.Products
{
  public partial class ProductSelect : Form
  {
    private int _productId;

    public int ProductId
    {
      get { return _productId; }
    }

    public ProductSelect()
    {
      InitializeComponent();
    }

    private void OK_Button_Click(object sender, EventArgs e)
    {
      _productId = (int) this.ProductListListBox.SelectedValue;
      this.Close();
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ProductSelect_Load(object sender, EventArgs e)
    {
      DisplayList(ProductList.GetProductList());
    }

    private void DisplayList(ProductList list)
    {
      var sortedList = from p in list where p.Id != -1 orderby p.Name select p;
      this.productListBindingSource.DataSource = sortedList;
    }

    private void GetListButton_Click(object sender, EventArgs e)
    {
      DisplayList(ProductList.GetProductList(NameTextBox.Text));
    }

    private void ProductListListBox_DoubleClick(object sender, EventArgs e)
    {
      _productId = (int) this.ProductListListBox.SelectedValue;
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }
}