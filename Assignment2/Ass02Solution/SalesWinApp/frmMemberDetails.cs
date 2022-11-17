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
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
        }
        public IMemberRepository MemberRepository = new MemberRepository();
        public string Section { get; set; }
        public Member MemberInfo { get; set; }
        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            if (Section.Contains("Update"))
            {
                txtEmail.Enabled = false;
                txtEmail.Text = MemberInfo.Email;
                txtCompanyName.Text = MemberInfo.CompanyName;
                txtPassword.Text = MemberInfo.Password;
                txtConfirmPassword.Text = MemberInfo.Password;
                txtCountry.Text = MemberInfo.Country;
                txtCity.Text = MemberInfo.City;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country=txtCountry.Text
                };
                if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
                {
                    MessageBox.Show("Confirm password not correct");
                    txtConfirmPassword.Text = string.Empty;
                    txtConfirmPassword.Focus();
                }
                else if (Section.Equals("Update"))
                {
                    if (MemberInfo != null)
                    {
                        member.MemberId = MemberInfo.MemberId;
                        MemberRepository.Update(member);
                        MessageBox.Show("Update successfully"); 
                    }
                }
                else
                {
                    MemberRepository.Add(member);
                    MessageBox.Show("Insert successfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Section.Equals("Update") ? "Update member" : "Add new member");
            }
        }
        public void Clear()
        {
            txtConfirmPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtCity.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
