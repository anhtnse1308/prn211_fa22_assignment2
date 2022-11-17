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
    public partial class frmMain : Form
    {
        public Member LoginUser { get; set; }
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
                if (LoginUser.Email == DataAccess.Helper.JsonReader.GetAdmin().Email)
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
                frmMembers frmMembers = new frmMembers()
                {
                    Text = "Member Management"
                };
                frmMembers.Show();
            }
            else
            {
                frmMemberDetails frmMemberDetails = new frmMemberDetails
                {
                    Text = "Member Profile",
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
                    Text = "Order Management",
                    loginUser=LoginUser
                };
                frmOrders.Show();
            }
            else
            {
                frmOrders frmOrders = new frmOrders 
                {
                    Text = "Order History",
                    loginUser=LoginUser
                };
                frmOrders.Show();
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

        private void btnClose_Click(object sender, EventArgs e)=> this.Close();
    }
}
