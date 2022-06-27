using MysqlApp.Models;

namespace MysqlApp
{
    public partial class Main : Form
    {
        Products products = new Products();


        public Main()
        {
            InitializeComponent();
            refreshProds();

        }
        private void refreshProds()
        {
            dgv_products.DataSource = null;
            dgv_products.DataSource = products.GetAll();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            products.name = txt_name.Text;
            products.stock = (int)n_stock.Value;
            products.price = (float)n_price.Value;
            products.Save();
            refreshProds();
        }
    }
}