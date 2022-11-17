using DataAccess.Models;
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
    public partial class frmAddDetail : Form
    {
        IProductRepository productRepository = new ProductRepository();
        IOrderDetailsRepository orderDetailsRepository = new OrderDetailsRepository();
        public Order Order { get; set; }
        public OrderDetail Detail { get; set; }
        public bool InsertOrUpdate { get; set; } = true;
        public frmAddDetail()
        {
            InitializeComponent();
        }

        private void frmAddDetail_Load(object sender, EventArgs e)
        {
            ClearText();
            var listProduct = productRepository.Get();
            if (listProduct != null && listProduct.Count() > 0)
            {
                cboProductId.DataSource = listProduct;
                cboProductId.DisplayMember = "ProductName";
                cboProductId.ValueMember = "ProductId";
            }
            if (!InsertOrUpdate)
            {
                if (Detail != null)
                {
                    txtUnitPrice.Text = Detail.UnitPrice.ToString();
                    txtQuantity.Text = Detail.Quantity.ToString();
                    txtDiscount.Text = Detail.Discount.ToString();
                    cboProductId.SelectedValue = Detail.ProductId.ToString();
                }
            }
        }

        private void ClearText()
        {
            txtDiscount.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var detail = new OrderDetail
            {
                OrderId = Order.OrderId,
                ProductId = int.Parse(cboProductId.SelectedValue.ToString()),
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                Discount = double.Parse(txtDiscount.Text),
            };
            if (InsertOrUpdate)
            {
                bool update = GetUpdateProduct(detail.ProductId, detail.Quantity);
                if (update)
                {
                    orderDetailsRepository.Add(detail);
                }
            }
            else
            {
                bool update = GetUpdateProduct(detail.ProductId, detail.Quantity);
                if (update)
                {
                    orderDetailsRepository.Update(detail);
                }
            }
        }
        private bool GetUpdateProduct(int productId, int quantity)
        {
            bool rs = false;
            var product = productRepository.Get().Where(p => p.ProductId == productId).FirstOrDefault();
            if (product != null)
            {
                if (product.UnitPrice > 0 && product.UnitPrice > quantity)
                {
                    product.UnitInStock -= quantity;
                    productRepository.Update(product);
                    rs = true;
                }
                else
                {
                    MessageBox.Show("Not enough quantity");
                }
            }
            return rs;
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void cboProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = cboProductId.SelectedItem as Product;
            txtUnitPrice.Text = product.UnitPrice.ToString();
        }
    }
}
