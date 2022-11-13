﻿using BussinessObject;
using DataAccess.Repository;
using System;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public static MemberObject loginUser;
        public frmLogin()
        {
            InitializeComponent();
        }
        IMemberRepository memberRepository = new MemberRepository();
        public MemberObject login(string email, string password)
        {
            var MemberList = memberRepository.GetMembers();
            var admin = memberRepository.GetAdmin();
            MemberObject member = null;
            foreach(MemberObject o in MemberList)
            {
                if(email.Equals(o.Email) && password.Equals(o.Password))
                {
                    member = o;
                }
            }
            if (admin!=null && email.Equals(admin.Email) && password.Equals(admin.Password))
            {
                member = admin;
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
            MemberObject loginMem = login(email, password);
            if (loginMem!=null)
            {
                loginUser = loginMem;
                if (loginUser!=null)
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
