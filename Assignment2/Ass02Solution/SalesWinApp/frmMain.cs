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
    public partial class frmMain : Form
    {
        public MemberObject LoginUser { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        public bool AdminOrUser;//Admin: true || User:false
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (LoginUser != null)
            {
                if (LoginUser.CompanyName.Equals("Admin"))
                {
                    btnMember.Text = "Members Management";
                    btnOrder.Text = "Orders Management";
                    btnProduct.Text = "Products Management";
                    AdminOrUser = true;
                }
                else
                {
                    btnMember.Text = "Edit Member Profile";
                    btnOrder.Text = "View Orders History";
                    btnProduct.Hide();
                }
            }
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            if (AdminOrUser)
            {
                frmMembers frmMembers = new frmMembers();
                frmMembers.Show();
            }
            else
            {
                frmMemberDetails frmMemberDetails = new frmMemberDetails
                {
                    MemberInfo=LoginUser,
                    MemberRepository=memberRepository,
                    Section="Update"
                };
                frmMemberDetails.Show();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (AdminOrUser)
            {
                frmOrders frmOrders = new frmOrders
                {
                    loginUser=LoginUser
                };
                frmOrders.Show();
            }
            else
            {
                frmOrderDetails frmOrderDetails = new frmOrderDetails 
                { 
                    loginUser=LoginUser,
                    orderDetailsRepository=new OrderDetailsRepository(),
                    orderRepository= new OrderRepository()
                };
                frmOrderDetails.Show();
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (AdminOrUser)
            {
                frmProducts frmProducts= new frmProducts
                {
                    Text="Product Management",
                };
                frmProducts.Show();
            }
        }
    }
}
