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
    public partial class frmOrderDetails : Form
    {
        public MemberObject loginUser { get; set; }
        public IOrderDetailsRepository orderDetailsRepository = new OrderDetailsRepository();
        public IProductRepository productRepository = new ProductRepository();
        public IOrderRepository orderRepository { get; set; }
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
            txtSearchOrderId.DataBindings.Clear();
            txtSearchProductId.DataBindings.Clear();
        }
        public OrderDetailsObject GetOrderDetailsObject()
        {
            OrderDetailsObject orderDetails = null;
            try
            {
                orderDetails = new OrderDetailsObject
                {
                    Order= int.Parse(txtOrderId.Text),
                    Product = int.Parse(txtProductId.Text),
                    UnitPrice =int.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = float.Parse(txtDiscount.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order details");
            }
            return orderDetails;
        }

        public void LoadOrderDetailsList(IEnumerable<OrderDetailsObject> OrderList)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = OrderList;

                ClearBindingData();

                txtOrderId.DataBindings.Add("Text", source, "Order");
                txtProductId.DataBindings.Add("Text", source, "Product");
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
        public IEnumerable<OrderDetailsObject> GetList()
        {
            List<OrderDetailsObject> ListOrderDetails = new List<OrderDetailsObject>();
            var ListOrder = orderRepository.GetOrdersByMember(loginUser.MemberId);
            foreach (OrderObject o in ListOrder)
            {
                List<OrderDetailsObject> order = (List<OrderDetailsObject>)orderDetailsRepository.GetOrderDetails(o.OrderId);
                foreach (OrderDetailsObject details in order)
                {
                    ListOrderDetails.Add(details);
                }
            }
            return ListOrderDetails;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var ListOrderDetails = GetList();
            LoadOrderDetailsList(ListOrderDetails);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts { };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            orderDetailsRepository.Remove(int.Parse(txtOrderId.Text));
            var ListOrderDetails = GetList();
            LoadOrderDetailsList(ListOrderDetails);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var ListOrderDetails = GetList();
            List<OrderDetailsObject> searchList = new List<OrderDetailsObject>();
            if (!txtSearchOrderId.Text.Equals(string.Empty) && !txtSearchProductId.Text.Equals(string.Empty))
            {
                foreach (OrderDetailsObject o in ListOrderDetails)
                {
                    if (o.Order == int.Parse(txtSearchOrderId.Text) && o.Product.Equals(txtSearchProductId.Text))
                    {
                        searchList.Add(o);
                    }
                }
                if (searchList.Count() != 0)
                {
                    LoadOrderDetailsList(searchList);
                }
                else
                {
                    LoadOrderDetailsList(ListOrderDetails);
                    MessageBox.Show("No results found mathches OrderID and ProductId");
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!loginUser.CompanyName.Equals("Admin"))
            {
                MessageBox.Show("Can't edit");
            }
            else
            {
                var orderDetails = GetOrderDetailsObject();
                orderDetailsRepository.Update(orderDetails);
                var ListOrderDetails = GetList();
                LoadOrderDetailsList(ListOrderDetails);
            }
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            if (!loginUser.CompanyName.Equals("Admin"))
            {
                btnUpdate.Hide();
                btnDelete.Hide();
                dgvOrderList.ReadOnly = true;
            }
            else
            {
                btnUpdate.Show();
                btnDelete.Show();
                dgvOrderList.ReadOnly = false;
            }
        }
    }
}
