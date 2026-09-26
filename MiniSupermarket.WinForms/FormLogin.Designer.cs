namespace MiniSupermarket.WinForms
{
    partial class FormLogin
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
            label1 = new Label();
            txtUser = new TextBox();
            groupBox1 = new GroupBox();
            btnLogin = new Button();
            txtPass = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 63);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(101, 60);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(196, 27);
            txtUser.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Location = new Point(78, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 264);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng nhập";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(76, 194);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(242, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập hệ thống";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(101, 127);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(196, 27);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 130);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormLogin";
            Text = "FormLogin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtUser;
        private GroupBox groupBox1;
        private TextBox txtPass;
        private Label label2;
        private Button btnLogin;
    }
}