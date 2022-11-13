
namespace SalesWinApp
{
    partial class frmMain
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
            this.btnMember = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(74, 115);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(368, 29);
            this.btnMember.TabIndex = 0;
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(74, 233);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(368, 29);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(74, 175);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(368, 29);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(22, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(474, 81);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Main Dashboard";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 288);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Dashboard";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lbTitle;
    }
}