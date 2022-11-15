using DataAccess.Models;
using DataAccess;
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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }
        public Member loginUser { get; set; }
        IOrderRepository orderRepository = new OrderRepository();
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmOrders_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtOrderId.Enabled = false;
            txtSearchMemberId.Text = string.Empty;
            txtSearchOrderId.Text = string.Empty;
            var ListOrders = orderRepository.Get();
            LoadOrderList(ListOrders);
        }

        private void dgvOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetails frmOrderDetails = new frmOrderDetails
            {
                loginUser = loginUser,
                orderRepository = orderRepository,
                Order = GetOrderObject()
            };
            if (frmOrderDetails.ShowDialog() == DialogResult.OK)
            {
                var OrderList = orderRepository.Get();
                LoadOrderList(OrderList);
                source.Position = source.Count - 1;
            }
        }

        public void LoadOrderList(IEnumerable<Order> OrderList)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = OrderList;

                ClearBindingData();

                txtOrderId.DataBindings.Add("Text", source, "OrderId");
                txtMemberId.DataBindings.Add("Text", source, "MemberId");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");

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
                MessageBox.Show(ex.Message, "Load order list");
            }
        }

        private void Clear()
        {
            txtMemberId.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtOrderId.Text = string.Empty;
            txtRequiredDate.Text = string.Empty;
            txtShippedDate.Text = string.Empty;
            txtFreight.Text = string.Empty;
        }

        private void ClearBindingData()
        {
            txtOrderId.DataBindings.Clear();
            txtMemberId.DataBindings.Clear();
            txtFreight.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtShippedDate.DataBindings.Clear();
            txtRequiredDate.DataBindings.Clear();
            txtSearchOrderId.DataBindings.Clear();
            txtSearchMemberId.DataBindings.Clear();
        }

        public Order GetOrderObject()
        {
            Order order = null;
            try
            {
                order = new Order
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    MemberId = int.Parse(txtMemberId.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    Freight = decimal.Parse(txtFreight.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order");
            }
            return order;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var ListOrders = orderRepository.Get();
            LoadOrderList(ListOrders);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var orderNew = GetOrderObject();
            orderNew.OrderId = 0;
            orderRepository.Add(orderNew);
            frmOrderDetails frmOrderDetails = new frmOrderDetails
            {
                Text = "Add new Details to Order",
                Order = orderNew
            };
            if (frmOrderDetails.ShowDialog() == DialogResult.OK)
            {
                var ListOrder = orderRepository.Get();
                LoadOrderList(ListOrder);
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetOrderObject();
                if (order != null)
                {
                    orderRepository.Remove(order);
                    var OrderList = orderRepository.Get();
                    LoadOrderList(OrderList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove order");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var OrderList = orderRepository.Get();
            List<Order> searchList = new List<Order>();
            if (!txtSearchOrderId.Text.Equals(string.Empty) && !txtSearchMemberId.Text.Equals(string.Empty))
            {
                foreach (Order o in OrderList)
                {
                    if (o.Member.MemberId == int.Parse(txtSearchOrderId.Text) && o.OrderId.Equals(txtSearchMemberId.Text))
                    {
                        searchList.Add(o);
                    }
                }
                if (searchList.Count() != 0)
                {
                    LoadOrderList(searchList);
                }
                else
                {
                    LoadOrderList(OrderList);
                    MessageBox.Show("No results found mathches OrderID and MemberId");
                }
            }
        }
    }
}
