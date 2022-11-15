
using System;
using System.Windows.Forms;

namespace SalesWinApp
{
    partial class frmOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.txtSearchOrderId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchMemberId = new System.Windows.Forms.TextBox();
            this.lbSearchEmail = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(12, 260);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 29;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(776, 188);
            this.dgvOrderList.TabIndex = 8;
            this.dgvOrderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellDoubleClick);
            // 
            // txtSearchOrderId
            // 
            this.txtSearchOrderId.Location = new System.Drawing.Point(99, 40);
            this.txtSearchOrderId.Name = "txtSearchOrderId";
            this.txtSearchOrderId.Size = new System.Drawing.Size(125, 27);
            this.txtSearchOrderId.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Order Id";
            // 
            // txtSearchMemberId
            // 
            this.txtSearchMemberId.Location = new System.Drawing.Point(99, 118);
            this.txtSearchMemberId.Name = "txtSearchMemberId";
            this.txtSearchMemberId.Size = new System.Drawing.Size(125, 27);
            this.txtSearchMemberId.TabIndex = 12;
            // 
            // lbSearchEmail
            // 
            this.lbSearchEmail.AutoSize = true;
            this.lbSearchEmail.Location = new System.Drawing.Point(7, 121);
            this.lbSearchEmail.Name = "lbSearchEmail";
            this.lbSearchEmail.Size = new System.Drawing.Size(82, 20);
            this.lbSearchEmail.TabIndex = 11;
            this.lbSearchEmail.Text = "Member Id";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.txtMemberId);
            this.gbInfo.Controls.Add(this.lbMemberId);
            this.gbInfo.Controls.Add(this.txtFreight);
            this.gbInfo.Controls.Add(this.lbFreight);
            this.gbInfo.Controls.Add(this.txtShippedDate);
            this.gbInfo.Controls.Add(this.lbShippedDate);
            this.gbInfo.Controls.Add(this.txtRequiredDate);
            this.gbInfo.Controls.Add(this.txtOrderDate);
            this.gbInfo.Controls.Add(this.txtOrderId);
            this.gbInfo.Controls.Add(this.lbRequiredDate);
            this.gbInfo.Controls.Add(this.lbOrderDate);
            this.gbInfo.Controls.Add(this.lbOrderId);
            this.gbInfo.Location = new System.Drawing.Point(13, 13);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(478, 182);
            this.gbInfo.TabIndex = 13;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(80, 86);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(125, 27);
            this.txtMemberId.TabIndex = 21;
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(4, 89);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(78, 20);
            this.lbMemberId.TabIndex = 20;
            this.lbMemberId.Text = "MemberId";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(80, 131);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(125, 27);
            this.txtFreight.TabIndex = 19;
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(4, 134);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(55, 20);
            this.lbFreight.TabIndex = 18;
            this.lbFreight.Text = "Freight";
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(347, 131);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(125, 27);
            this.txtShippedDate.TabIndex = 17;
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(225, 134);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(100, 20);
            this.lbShippedDate.TabIndex = 16;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(347, 86);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(125, 27);
            this.txtRequiredDate.TabIndex = 14;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(347, 37);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(125, 27);
            this.txtOrderDate.TabIndex = 13;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(80, 36);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(125, 27);
            this.txtOrderId.TabIndex = 12;
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(225, 89);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(105, 20);
            this.lbRequiredDate.TabIndex = 11;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(225, 43);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(83, 20);
            this.lbOrderDate.TabIndex = 10;
            this.lbOrderDate.Text = "Order Date";
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(6, 40);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(60, 20);
            this.lbOrderId.TabIndex = 8;
            this.lbOrderId.Text = "OrderId";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.txtSearchMemberId);
            this.gbSearch.Controls.Add(this.lbSearchEmail);
            this.gbSearch.Controls.Add(this.txtSearchOrderId);
            this.gbSearch.Controls.Add(this.label5);
            this.gbSearch.Location = new System.Drawing.Point(497, 13);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(271, 182);
            this.gbSearch.TabIndex = 14;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(361, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(201, 215);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(374, 215);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(596, 215);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(17, 215);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 20;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.dgvOrderList);
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders Details Management";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

            }
        #endregion

        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.TextBox txtSearchOrderId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchMemberId;
        private System.Windows.Forms.Label lbSearchEmail;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoad;
        private TextBox txtShippedDate;
        private Label lbShippedDate;
        private TextBox txtMemberId;
        private Label lbMemberId;
        private TextBox txtFreight;
        private Label lbFreight;
    }
}