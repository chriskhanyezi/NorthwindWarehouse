using Northwind.Business.Logic.Categories;
using Northwind.Business.Logic.Suppliers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Northwind.UI.WinForms.Categories
{
  public partial class CategorySelect : Form
  {
	private int _categoryId;

	public int CategoryId
	{
	  get { return _categoryId; }
	}

	public CategorySelect()
	{
	  InitializeComponent();
	}

	private void OK_Button_Click(object sender, EventArgs e)
	{
	  _categoryId = (int) this.CategoryListBox.SelectedValue;
	  this.Close();
	} 

	private void Cancel_Button_Click(object sender, EventArgs e)
	{
	  this.Close();
	}

	private void CategorySelect_Load(object sender, EventArgs e)
	{
	  DisplayList(CategoryList.GetCategoryList());
	}

	private void DisplayList(CategoryList list)
	{
	  var sortedList = from p in list where p.Id !=-1 orderby p.Name select p;
	  this.categoryListBindingSource.DataSource = sortedList;
	}

	private void GetListButton_Click(object sender, EventArgs e)
	{
	  DisplayList(CategoryList.GetCategoryList(NameTextBox.Text));
	}

	private void CategoryListListBox_DoubleClick(object sender, EventArgs e)
	{
	  _categoryId = (int) this.CategoryListBox.SelectedValue;
	  this.DialogResult = DialogResult.OK;
	  this.Close();
	}
  }
}