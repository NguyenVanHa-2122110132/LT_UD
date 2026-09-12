namespace MiniSupermarket.WinForms
{
    partial class FormCategoryManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnLoad = new Button();
            btnSearch = new Button();
            txtKeyword = new TextBox();
            groupBox2 = new GroupBox();
            dgvCategories = new DataGridView();
            groupBox3 = new GroupBox();
            txtDescription = new TextBox();
            label3 = new Label();
            txtCategoryName = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtKeyword);
            groupBox1.Location = new Point(31, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(535, 74);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Kiếm";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(432, 36);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Tải lại";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(332, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(21, 36);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(305, 27);
            txtKeyword.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvCategories);
            groupBox2.Location = new Point(31, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(535, 333);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhóm hàng";
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Dock = DockStyle.Fill;
            dgvCategories.Location = new Point(3, 23);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.Size = new Size(529, 307);
            dgvCategories.TabIndex = 0;
            dgvCategories.CellContentClick += dgvCategories_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDescription);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtCategoryName);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtId);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(584, 105);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(421, 241);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin Nhóm hàng";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(7, 172);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(395, 53);
            txtDescription.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 149);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "Mô Tả";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(6, 109);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(396, 27);
            txtCategoryName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 86);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Nhóm hàng";
            // 
            // txtId
            // 
            txtId.Location = new Point(6, 46);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(396, 27);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã ID";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(584, 352);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(717, 352);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(857, 352);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormCategoryManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormCategoryManagement";
            Text = "Form1";
            Load += FormCategoryManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLoad;
        private Button btnSearch;
        private TextBox txtKeyword;
        private GroupBox groupBox2;
        private DataGridView dgvCategories;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtCategoryName;
        private Label label3;
        private TextBox txtDescription;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
