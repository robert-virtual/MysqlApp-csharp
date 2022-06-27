using MysqlApp.Forms;
using MysqlApp.Models;

namespace MysqlApp
{
    public partial class Main : Form
    {
        Products products = new Products();
        Category category = new Category();


        public Main()
        {
            InitializeComponent();
            refreshProds();
            RefreshCategories();    

        }
        private void RefreshCategories()
        {
            cb_categories.DataSource = category.GetAll();
            cb_categories.DisplayMember= "Name";
            cb_categories.ValueMember = "Id";
        }
        private void refreshProds()
        {
            dgv_products.DataSource = null;
            dgv_products.DataSource = products.GetAll();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            products.Name = txt_name.Text;
            products.Stock = (int)n_stock.Value;
            products.CategoryId = (int)cb_categories.SelectedValue;
            products.Price = (float)n_price.Value;
            products.Save(products);
            refreshProds();
        }

        private void btn_nueva_category_Click(object sender, EventArgs e)
        {
            var categories = new Categories();
            categories.ShowDialog();
            RefreshCategories();
        }
    }
}