
namespace SalesWinApp
{
    partial class frmOrderDetails
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchProductId = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.txtSearchOrderId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbSearch.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(14, 241);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 28;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(596, 241);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(360, 531);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.txtSearchProductId);
            this.gbSearch.Controls.Add(this.lb2);
            this.gbSearch.Controls.Add(this.txtSearchOrderId);
            this.gbSearch.Controls.Add(this.label5);
            this.gbSearch.Location = new System.Drawing.Point(497, 10);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(271, 182);
            this.gbSearch.TabIndex = 23;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // txtSearchProductId
            // 
            this.txtSearchProductId.Location = new System.Drawing.Point(117, 113);
            this.txtSearchProductId.Name = "txtSearchProductId";
            this.txtSearchProductId.Size = new System.Drawing.Size(125, 27);
            this.txtSearchProductId.TabIndex = 12;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(7, 116);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(77, 20);
            this.lb2.TabIndex = 11;
            this.lb2.Text = "Product Id";
            // 
            // txtSearchOrderId
            // 
            this.txtSearchOrderId.Location = new System.Drawing.Point(117, 36);
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
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.txtDiscount);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.txtProductId);
            this.gbInfo.Controls.Add(this.lbMemberId);
            this.gbInfo.Controls.Add(this.txtQuantity);
            this.gbInfo.Controls.Add(this.lbFreight);
            this.gbInfo.Controls.Add(this.txtUnitPrice);
            this.gbInfo.Controls.Add(this.txtOrderId);
            this.gbInfo.Controls.Add(this.lbOrderDate);
            this.gbInfo.Controls.Add(this.lbOrderId);
            this.gbInfo.Location = new System.Drawing.Point(13, 10);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(478, 182);
            this.gbInfo.TabIndex = 22;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(347, 86);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(125, 27);
            this.txtDiscount.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Discount";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(80, 86);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.PasswordChar = '*';
            this.txtProductId.Size = new System.Drawing.Size(125, 27);
            this.txtProductId.TabIndex = 21;
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(4, 89);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(73, 20);
            this.lbMemberId.TabIndex = 20;
            this.lbMemberId.Text = "ProductId";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(80, 131);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '*';
            this.txtQuantity.Size = new System.Drawing.Size(125, 27);
            this.txtQuantity.TabIndex = 19;
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(4, 134);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(65, 20);
            this.lbFreight.TabIndex = 18;
            this.lbFreight.Text = "Quantity";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(347, 37);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(125, 27);
            this.txtUnitPrice.TabIndex = 13;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(80, 36);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(125, 27);
            this.txtOrderId.TabIndex = 12;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(225, 43);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(72, 20);
            this.lbOrderDate.TabIndex = 10;
            this.lbOrderDate.Text = "Unit Price";
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
            // dgvOrderList
            // 
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(14, 317);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 29;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(776, 188);
            this.dgvOrderList.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(202, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(382, 241);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 572);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.dgvOrderList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Details";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox txtSearchProductId;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txtSearchOrderId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lbMemberId;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}