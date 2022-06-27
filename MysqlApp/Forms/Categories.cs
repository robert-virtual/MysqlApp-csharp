using MysqlApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MysqlApp.Forms
{
    public partial class Categories : Form
    {
        Category category = new Category();
        public Categories()
        {
            InitializeComponent();
            RefreshCategories();
        }
        private void RefreshCategories()
        {
            dgv_categories.DataSource = null;
            dgv_categories.DataSource = category.GetAll();
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {

            category.Name = txt_name.Text;
            category.Save(category);
            RefreshCategories();
            txt_name.Clear();

        }
    }
}
