
namespace SalesWinApp
{
    partial class frmProducts
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(16, 158);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 22);
            this.btnLoad.TabIndex = 28;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(406, 158);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 22);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(214, 158);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 22);
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(308, 343);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 22);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.txtProductName);
            this.gbInfo.Controls.Add(this.lbMemberId);
            this.gbInfo.Controls.Add(this.txtCategoryId);
            this.gbInfo.Controls.Add(this.lbFreight);
            this.gbInfo.Controls.Add(this.txtWeight);
            this.gbInfo.Controls.Add(this.lbShippedDate);
            this.gbInfo.Controls.Add(this.txtUnitInStock);
            this.gbInfo.Controls.Add(this.txtUnitPrice);
            this.gbInfo.Controls.Add(this.txtProductId);
            this.gbInfo.Controls.Add(this.lbRequiredDate);
            this.gbInfo.Controls.Add(this.lbOrderDate);
            this.gbInfo.Controls.Add(this.lbOrderId);
            this.gbInfo.Location = new System.Drawing.Point(7, 6);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbInfo.Size = new System.Drawing.Size(496, 136);
            this.gbInfo.TabIndex = 22;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(93, 64);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(110, 23);
            this.txtProductName.TabIndex = 21;
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(4, 67);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(81, 15);
            this.lbMemberId.TabIndex = 20;
            this.lbMemberId.Text = "ProductName";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(93, 98);
            this.txtCategoryId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(110, 23);
            this.txtCategoryId.TabIndex = 19;
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(4, 100);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(65, 15);
            this.lbFreight.TabIndex = 18;
            this.lbFreight.Text = "CategoryId";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(348, 98);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(110, 23);
            this.txtWeight.TabIndex = 17;
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(262, 100);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(45, 15);
            this.lbShippedDate.TabIndex = 16;
            this.lbShippedDate.Text = "Weight";
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Location = new System.Drawing.Point(348, 64);
            this.txtUnitInStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(110, 23);
            this.txtUnitInStock.TabIndex = 14;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(348, 27);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(110, 23);
            this.txtUnitPrice.TabIndex = 13;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(93, 27);
            this.txtProductId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(110, 23);
            this.txtProductId.TabIndex = 12;
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(262, 66);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(74, 15);
            this.lbRequiredDate.TabIndex = 11;
            this.lbRequiredDate.Text = "Unit In Stock";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(262, 32);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(58, 15);
            this.lbOrderDate.TabIndex = 10;
            this.lbOrderDate.Text = "Unit Price";
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(5, 30);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(59, 15);
            this.lbOrderId.TabIndex = 8;
            this.lbOrderId.Text = "ProductId";
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(6, 191);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 29;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(676, 141);
            this.dgvProductList.TabIndex = 21;
            this.dgvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellDoubleClick);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 374);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.dgvProductList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Management";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbMemberId;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.TextBox txtUnitInStock;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.DataGridView dgvProductList;
    }
}