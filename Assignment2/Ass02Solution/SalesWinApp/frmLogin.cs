using DataAccess.Models;
using DataAccess.Repository;
using DataAccess.Helper;
using System;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository;
        public static Member loginUser;
        public frmLogin()
        {
            InitializeComponent();
            memberRepository = new MemberRepository();
        }
        public Member login(string email, string password)
        {
            var admin = JsonReader.GetAdmin();
            Member member = null;
            if (admin != null && email.Equals(admin.Email) && password.Equals(admin.Password))
            {
                member = admin;
            }
            if (member == null)
            {
                var MemberList = memberRepository.Get();
                foreach (Member o in MemberList)
                {
                    if (email.Equals(o.Email) && password.Equals(o.Password))
                    {
                        member = o;
                    }
                }
            }
            return member;
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        public void ClearText()
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IMemberRepository MemberRepository = new MemberRepository();
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            Member loginMem = login(email, password);
            if (loginMem != null)
            {
                loginUser = loginMem;
                if (loginUser != null)
                {
                    frmMain frmMain = new frmMain
                    {
                        LoginUser = loginUser
                    };
                    frmMain.Show();
                }
            }
            else
            {
                ClearText();
            }
        }
    }
}
