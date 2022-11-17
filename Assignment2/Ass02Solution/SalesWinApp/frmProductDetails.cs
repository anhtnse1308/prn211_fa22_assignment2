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
    public partial class frmProductDetails : Form
    {
        public frmProductDetails()
        {
            InitializeComponent();
        }
        public IProductRepository ProductRepository { get; set; }
        public string Section { get; set; }
        public Product ProductInfo { get; set; }
        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            if (Section.Contains("Update"))
            {
                txtCategoryId.Text = ProductInfo.CategoryId.ToString();
                txtProductName.Text = ProductInfo.ProductName;
                txtUnitInStock.Text = ProductInfo.UnitInStock.ToString();
                txtUnitPrice.Text = ProductInfo.UnitPrice.ToString();
                txtWeight.Text = ProductInfo.Weight;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    CategoryId= int.Parse(txtCategoryId.Text),
                    ProductName= txtProductName.Text,
                    UnitInStock= int.Parse(txtUnitInStock.Text),
                    UnitPrice= int.Parse(txtUnitPrice.Text),
                    Weight= txtWeight.Text
                };
                if (Section.Equals("Update"))
                {
                    if (ProductInfo != null)
                    {
                        product.ProductId = ProductInfo.ProductId;
                        ProductRepository.Update(product);
                        MessageBox.Show("Update successfully"); 
                    }
                }
                else
                {
                    ProductRepository.Add(product);
                    MessageBox.Show("Insert successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Section.Equals("Update") ? "Update member" : "Add new member");
            }
        }
        public void Clear()
        {
            txtWeight.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitInStock.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtCategoryId.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
