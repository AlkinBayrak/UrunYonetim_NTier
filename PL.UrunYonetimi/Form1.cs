using BLL.UrunYonetimi.Managers.Concrete;
using BLL.UrunYonetimi.Models;

namespace PL.UrunYonetimi
{
    public partial class Form1 : Form
    {
        ProductModel selectedProduct = new ProductModel();
        ProductManager productManager = new ProductManager();

        public void ListAllProducts()
        {
            dgvProducts.DataSource = productManager.GetAll();
        }
        public Form1()
        {
            InitializeComponent();
            ListAllProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModel productModel = new ProductModel();

            productModel.Name = txtName.Text;
            productModel.Price = Convert.ToInt32(txtPrice.Text);

            productManager.Create(productModel);

            ListAllProducts();
            MessageBox.Show("The product has successfully beem added");
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProduct = (ProductModel)dgvProducts.SelectedRows[0].DataBoundItem;
        }
    }
}
