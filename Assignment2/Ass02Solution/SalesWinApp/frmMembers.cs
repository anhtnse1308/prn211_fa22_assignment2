using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmMembersManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtSearchID.Text = string.Empty;
            txtSearchEmail.Text = string.Empty;
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Update Member",
                Section = "Update",
                MemberInfo = GetMemberObject(),
                MemberRepository = this.memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                var ListMembers = memberRepository.Get();
                LoadMemberList(ListMembers);
                source.Position = source.Count - 1;
            }
        }

        public void LoadMemberList(IEnumerable<Member> ListMembers)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = ListMembers;

                ClearBindingData();

                txtID.DataBindings.Add("Text", source, "MemberId");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = source;
                if (ListMembers.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void Clear()
        {
            txtEmail.Text = string.Empty;
            txtID.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        private void ClearBindingData()
        {
            txtEmail.DataBindings.Clear();
            txtID.DataBindings.Clear();
            txtCompanyName.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtSearchID.DataBindings.Clear();
            txtSearchEmail.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
        }

        public Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberId = int.Parse(txtID.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return member;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var ListMembers = memberRepository.Get();
            LoadMemberList(ListMembers);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Add new member",
                Section = "Add new member",
                MemberRepository = this.memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                var ListMembers = memberRepository.Get();
                LoadMemberList(ListMembers);
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                if (member != null)
                {
                    memberRepository.Remove(member);
                    var ListMembers = memberRepository.Get();
                    LoadMemberList(ListMembers);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove member");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var ListMembers = memberRepository.Get();
            List<Member> searchList = new List<Member>();
            if (!txtSearchID.Text.Equals(string.Empty) && !txtSearchEmail.Text.Equals(string.Empty))
            {
                foreach (Member o in ListMembers)
                {
                    if (o.MemberId == int.Parse(txtSearchID.Text) && o.Email.Equals(txtSearchEmail.Text))
                    {
                        searchList.Add(o);
                    }
                }
                if (searchList.Count() != 0)
                {
                    LoadMemberList(searchList);
                }
                else
                {
                    LoadMemberList(ListMembers);
                    MessageBox.Show("No results found mathches ID and Name");
                }
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            var ListMembers = memberRepository.Get();
            List<Member> searchList = new List<Member>();
            if (!txtSearchEmail.Text.Equals(string.Empty))
            {
                foreach (Member o in ListMembers)
                {
                    if (o.Email.Contains(txtSearchEmail.Text))
                    {
                        searchList.Add(o);
                    }
                }
                if (searchList.Count() != 0)
                {
                    LoadMemberList(searchList);
                }
                else
                {
                    LoadMemberList(ListMembers);
                }
            }
            else
            {
                LoadMemberList(ListMembers);
            }
        }
    }
}
