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
    public partial class frmOrderDetails : Form
    {
        public Member loginUser { get; set; }
        public Order Order { get; set; }
        public IOrderDetailsRepository orderDetailsRepository = new OrderDetailsRepository();
        public IProductRepository productRepository = new ProductRepository();
        public IOrderRepository orderRepository = new OrderRepository();
        BindingSource source;
        public frmOrderDetails()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            txtProductId.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtOrderId.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }

        private void ClearBindingData()
        {
            txtOrderId.DataBindings.Clear();
            txtProductId.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtDiscount.DataBindings.Clear();
        }
        public OrderDetail GetOrderDetailsObject()
        {
            OrderDetail orderDetails = null;
            try
            {
                orderDetails = new OrderDetail
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    ProductId = int.Parse(txtProductId.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = double.Parse(txtDiscount.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order details");
            }
            return orderDetails;
        }

        public void LoadOrderDetailsList(IEnumerable<OrderDetail> OrderList)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = OrderList;

                ClearBindingData();

                txtOrderId.DataBindings.Add("Text", source, "OrderId");
                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtDiscount.DataBindings.Add("Text", source, "Discount");

                dgvOrderList.DataSource = source;
                if (OrderList.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load order details list");
            }
        }
        public IEnumerable<OrderDetail> GetList()
        {
            List<OrderDetail> ListOrderDetails = new List<OrderDetail>();
            List<Order> ListOrder = new List<Order>();
            if(Order != null)
            {
                var details = orderDetailsRepository.Get().Where(d => d.OrderId == Order.OrderId);
                foreach (OrderDetail detail in details)
                {
                    ListOrderDetails.Add(detail);
                }
            }
            else
            {
                if (loginUser != null && loginUser.Email.Equals("admin@fstore.com"))
                {
                    ListOrder = orderRepository.Get().ToList();
                }
                else
                {
                    ListOrder = orderRepository.Get().Where(o => o.MemberId == loginUser.MemberId)
                        .ToList();
                }
                foreach (Order order in ListOrder)
                {
                    var details = orderDetailsRepository.Get().Where(d => d.OrderId == order.OrderId);
                    foreach (OrderDetail detail in details)
                    {
                        ListOrderDetails.Add(detail);
                    }
                }
            }
            return ListOrderDetails;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var ListOrderDetails = GetList();
            LoadOrderDetailsList(ListOrderDetails);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var orderdetail = orderDetailsRepository.Get()
                .Where(detail => detail.OrderId == int.Parse(txtOrderId.Text) && detail.ProductId == int.Parse(txtProductId.Text))
                .FirstOrDefault();
            orderDetailsRepository.Remove(orderdetail);
            var ListOrderDetails = GetList();
            LoadOrderDetailsList(ListOrderDetails);
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            if (!loginUser.CompanyName.Equals("Admin"))
            {
                btnDelete.Hide();
                btnAdd.Hide();
            }
            else
            {
                btnAdd.Show();
                btnDelete.Show();
            }
            var ListOrderDetails = GetList();
            LoadOrderDetailsList(ListOrderDetails);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddDetail frmAddDetail = new frmAddDetail()
            {
                Text = "Add new detail",
                InsertOrUpdate = true,
                Order = this.Order
            };
            if (frmAddDetail.ShowDialog() == DialogResult.OK)
            {
                var details = GetList();
                LoadOrderDetailsList(details);
            }
        }

        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (loginUser.Email == DataAccess.Helper.JsonReader.GetAdmin().Email)
            {
                frmAddDetail frmAddDetail = new frmAddDetail
                {
                    Text = "Update detail",
                    InsertOrUpdate = false,
                    Detail = GetOrderDetailsObject()
                };
                if (frmAddDetail.ShowDialog() == DialogResult.OK)
                {
                    LoadOrderDetailsList(GetList());
                }
            }
            else
            {
                MessageBox.Show("You are not allowed to access this function!");
            }
        }
    }
}
