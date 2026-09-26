namespace MiniSupermarket.WinForms
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCategoryManagement = new System.Windows.Forms.Button();
            this.btnCustomerManagement = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblWelcome
            //
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblWelcome.Location = new System.Drawing.Point(30, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(120, 20);
            this.lblWelcome.Text = "Xin chào,";
            //
            // btnCategoryManagement
            //
            this.btnCategoryManagement.Location = new System.Drawing.Point(30, 70);
            this.btnCategoryManagement.Name = "btnCategoryManagement";
            this.btnCategoryManagement.Size = new System.Drawing.Size(280, 45);
            this.btnCategoryManagement.TabIndex = 1;
            this.btnCategoryManagement.Text = "Quản lý Nhóm hàng";
            this.btnCategoryManagement.UseVisualStyleBackColor = true;
            this.btnCategoryManagement.Click += new System.EventHandler(this.btnCategoryManagement_Click);
            //
           
            // btnCustomerManagement
            //
            this.btnCustomerManagement.Location = new System.Drawing.Point(30, 125);
            this.btnCustomerManagement.Name = "btnCustomerManagement";
            this.btnCustomerManagement.Size = new System.Drawing.Size(280, 45);
            this.btnCustomerManagement.TabIndex = 3;
            this.btnCustomerManagement.Text = "Quản lý Khách hàng";
            this.btnCustomerManagement.UseVisualStyleBackColor = true;
            this.btnCustomerManagement.Click += new System.EventHandler(this.btnCustomerManagement_Click);
            //
            // btnLogout
            //
            this.btnLogout.ForeColor = System.Drawing.Color.Firebrick;
            this.btnLogout.Location = new System.Drawing.Point(30, 195);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(280, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            //
            // FormMain
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 265);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnCategoryManagement);
            this.Controls.Add(this.btnCustomerManagement);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniSupermarket - Menu chính";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCategoryManagement;
        private System.Windows.Forms.Button btnCustomerManagement;
        private System.Windows.Forms.Button btnLogout;
    }
}