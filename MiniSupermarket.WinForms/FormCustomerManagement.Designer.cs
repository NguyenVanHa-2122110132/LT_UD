namespace MiniSupermarket.WinForms
{
    partial class FormCustomerManagement
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblRewardPoints = new System.Windows.Forms.Label();
            this.txtRewardPoints = new System.Windows.Forms.TextBox();
            this.lblMembershipRank = new System.Windows.Forms.Label();
            this.txtMembershipRank = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            //
            // dgvCustomers
            //
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 195);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowTemplate.Height = 25;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(760, 320);
            this.dgvCustomers.TabIndex = 20;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            //
            // lblCustomerId
            //
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(12, 15);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(46, 15);
            this.lblCustomerId.Text = "Mã KH:";
            //
            // txtCustomerId
            //
            this.txtCustomerId.Location = new System.Drawing.Point(120, 12);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(150, 23);
            this.txtCustomerId.TabIndex = 1;
            //
            // lblCustomerName
            //
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 45);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(70, 15);
            this.lblCustomerName.Text = "Họ tên KH:";
            //
            // txtCustomerName
            //
            this.txtCustomerName.Location = new System.Drawing.Point(120, 42);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(250, 23);
            this.txtCustomerName.TabIndex = 2;
            //
            // lblPhoneNumber
            //
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 75);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(80, 15);
            this.lblPhoneNumber.Text = "Số điện thoại:";
            //
            // txtPhoneNumber
            //
            this.txtPhoneNumber.Location = new System.Drawing.Point(120, 72);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(150, 23);
            this.txtPhoneNumber.TabIndex = 3;
            //
            // lblAddress
            //
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 105);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(42, 15);
            this.lblAddress.Text = "Địa chỉ:";
            //
            // txtAddress
            //
            this.txtAddress.Location = new System.Drawing.Point(120, 102);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 23);
            this.txtAddress.TabIndex = 4;
            //
            // lblRewardPoints
            //
            this.lblRewardPoints.AutoSize = true;
            this.lblRewardPoints.Location = new System.Drawing.Point(400, 45);
            this.lblRewardPoints.Name = "lblRewardPoints";
            this.lblRewardPoints.Size = new System.Drawing.Size(80, 15);
            this.lblRewardPoints.Text = "Điểm tích lũy:";
            //
            // txtRewardPoints
            //
            this.txtRewardPoints.Location = new System.Drawing.Point(520, 42);
            this.txtRewardPoints.Name = "txtRewardPoints";
            this.txtRewardPoints.Size = new System.Drawing.Size(100, 23);
            this.txtRewardPoints.TabIndex = 5;
            //
            // lblMembershipRank
            //
            this.lblMembershipRank.AutoSize = true;
            this.lblMembershipRank.Location = new System.Drawing.Point(400, 75);
            this.lblMembershipRank.Name = "lblMembershipRank";
            this.lblMembershipRank.Size = new System.Drawing.Size(60, 15);
            this.lblMembershipRank.Text = "Hạng thẻ:";
            //
            // txtMembershipRank
            //
            this.txtMembershipRank.Location = new System.Drawing.Point(520, 72);
            this.txtMembershipRank.Name = "txtMembershipRank";
            this.txtMembershipRank.Size = new System.Drawing.Size(100, 23);
            this.txtMembershipRank.TabIndex = 6;
            //
            // lblKeyword
            //
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(400, 105);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(56, 15);
            this.lblKeyword.Text = "Từ khóa:";
            //
            // txtKeyword
            //
            this.txtKeyword.Location = new System.Drawing.Point(520, 102);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(150, 23);
            this.txtKeyword.TabIndex = 7;
            //
            // btnLoad
            //
            this.btnLoad.Location = new System.Drawing.Point(12, 150);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 30);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Tải lại";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(120, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnUpdate
            //
            this.btnUpdate.Location = new System.Drawing.Point(228, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // btnDelete
            //
            this.btnDelete.Location = new System.Drawing.Point(336, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnSearch
            //
            this.btnSearch.Location = new System.Drawing.Point(520, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // FormCustomerManagement
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblRewardPoints);
            this.Controls.Add(this.txtRewardPoints);
            this.Controls.Add(this.lblMembershipRank);
            this.Controls.Add(this.txtMembershipRank);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Name = "FormCustomerManagement";
            this.Text = "Quản lý Khách hàng thân thiết";
            this.Load += new System.EventHandler(this.FormCustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblRewardPoints;
        private System.Windows.Forms.TextBox txtRewardPoints;
        private System.Windows.Forms.Label lblMembershipRank;
        private System.Windows.Forms.TextBox txtMembershipRank;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
    }
}