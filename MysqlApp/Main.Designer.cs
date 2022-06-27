namespace MysqlApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.n_stock = new System.Windows.Forms.NumericUpDown();
            this.n_price = new System.Windows.Forms.NumericUpDown();
            this.btn_save = new System.Windows.Forms.Button();
            this.cb_categories = new System.Windows.Forms.ComboBox();
            this.btn_nueva_category = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_price)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_products
            // 
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(39, 114);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.RowTemplate.Height = 29;
            this.dgv_products.Size = new System.Drawing.Size(559, 319);
            this.dgv_products.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(686, 122);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(150, 27);
            this.txt_name.TabIndex = 1;
            // 
            // n_stock
            // 
            this.n_stock.Location = new System.Drawing.Point(686, 185);
            this.n_stock.Name = "n_stock";
            this.n_stock.Size = new System.Drawing.Size(150, 27);
            this.n_stock.TabIndex = 2;
            // 
            // n_price
            // 
            this.n_price.Location = new System.Drawing.Point(686, 242);
            this.n_price.Name = "n_price";
            this.n_price.Size = new System.Drawing.Size(150, 27);
            this.n_price.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(686, 384);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(150, 29);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cb_categories
            // 
            this.cb_categories.FormattingEnabled = true;
            this.cb_categories.Location = new System.Drawing.Point(686, 287);
            this.cb_categories.Name = "cb_categories";
            this.cb_categories.Size = new System.Drawing.Size(151, 28);
            this.cb_categories.TabIndex = 4;
            // 
            // btn_nueva_category
            // 
            this.btn_nueva_category.Location = new System.Drawing.Point(686, 321);
            this.btn_nueva_category.Name = "btn_nueva_category";
            this.btn_nueva_category.Size = new System.Drawing.Size(150, 29);
            this.btn_nueva_category.TabIndex = 3;
            this.btn_nueva_category.Text = "Nueva categoria";
            this.btn_nueva_category.UseVisualStyleBackColor = true;
            this.btn_nueva_category.Click += new System.EventHandler(this.btn_nueva_category_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 607);
            this.Controls.Add(this.cb_categories);
            this.Controls.Add(this.btn_nueva_category);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.n_price);
            this.Controls.Add(this.n_stock);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dgv_products);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_products;
        private TextBox txt_name;
        private NumericUpDown n_stock;
        private NumericUpDown n_price;
        private Button btn_save;
        private ComboBox cb_categories;
        private Button btn_nueva_category;
    }
}