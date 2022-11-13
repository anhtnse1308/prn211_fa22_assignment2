using BussinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        public OrderObject OrderInfo { get; set; }

        public frmProducts()
        {
            InitializeComponent();
        }

        IProductRepository productRepository = new ProductRepository();
        BindingSource source;

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmProducts_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails
            {
                Text = "Update Member",
                Section = "Update",
                ProductInfo = GetProductObject(),
                ProductRepository = this.productRepository
            };
            if (frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                var ListMembers = productRepository.GetProducts();
                LoadMemberList(ListMembers);
                source.Position = source.Count - 1;
            }
        }

        public void LoadMemberList(IEnumerable<ProductObject> ListMembers)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = ListMembers;

                ClearBindingData();

                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtUnitInStock.DataBindings.Add("Text", source, "UnitInStock");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtWeight.DataBindings.Add("Text", source, "Weight");

                dgvProductList.DataSource = source;
                if (ListMembers.Count() == 0)
                {
                    Clear();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void Clear()
        {
            txtCategoryId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtProductId.Text = string.Empty;
            txtUnitInStock.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }

        private void ClearBindingData()
        {
            txtCategoryId.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtProductId.DataBindings.Clear();
            txtUnitInStock.DataBindings.Clear();
            txtWeight.DataBindings.Clear();
        }

        public ProductObject GetProductObject()
        {
            ProductObject product = null;
            try
            {
                product = new ProductObject
                {
                    CategoryId=int.Parse(txtCategoryId.Text),
                    ProductName= txtProductName.Text,
                    UnitPrice=int.Parse(txtUnitPrice.Text),
                    ProductId=int.Parse(txtProductId.Text),
                    UnitInStock = int.Parse(txtUnitInStock.Text),
                    Weight = txtWeight.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return product;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var ListProduct = productRepository.GetProducts();
            LoadMemberList(ListProduct);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails
            {
                Text = "Add new member",
                Section = "Add new member",
                ProductRepository = this.productRepository
            };
            if (frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                var ListProduct = productRepository.GetProducts();
                LoadMemberList(ListProduct);
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                if (product != null)
                {
                    productRepository.Remove(product);
                    var ListProduct = productRepository.GetProducts();
                    LoadMemberList(ListProduct);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove product");
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e) => Close();
    }
}
