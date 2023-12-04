using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tabloda verileri getiren kod
            loadProducts();
        }

        private void loadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Ürün ekleme işlemi
                _productDal.Add(new Product
                {
                    Name = nametbx.Text,
                    UnitPrice = Convert.ToDecimal(unitepricetbx.Text),
                    StockAmount = Convert.ToInt32(stockamounttbx.Text)

                });
                loadProducts();
                MessageBox.Show("Load products added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
       
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = Txt_NameUpdate.Text,
                UnitPrice = Convert.ToDecimal(Txt_UnitUpdate.Text),
                StockAmount = Convert.ToInt32(Txt_StockUpdate.Text)
            };
            _productDal.Update(product);
            loadProducts();
            MessageBox.Show("Updated");
        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //İçeriğe tıklayınca çalışır
            MessageBox.Show("Content");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Satır seçilince çalışır 
            MessageBox.Show("Cell Click");
            //DatagridViewde verileri textboxa ekle
           Txt_NameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            Txt_UnitUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            Txt_StockUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();

        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            loadProducts();
            MessageBox.Show("Deleted");
        }
    }
}
