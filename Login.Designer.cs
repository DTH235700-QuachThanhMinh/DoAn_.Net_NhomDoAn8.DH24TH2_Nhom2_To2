namespace QuanLyCuaHang_VLXD
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelBox = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // panelBox
            // 
            this.panelBox.BackColor = System.Drawing.Color.White;
            this.panelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBox.Location = new System.Drawing.Point(350, 80);
            this.panelBox.Size = new System.Drawing.Size(520, 430);
            this.panelBox.Controls.Add(this.btnLogin);
            this.panelBox.Controls.Add(this.rbStaff);
            this.panelBox.Controls.Add(this.rbAdmin);
            this.panelBox.Controls.Add(this.label4);
            this.panelBox.Controls.Add(this.txtPass);
            this.panelBox.Controls.Add(this.label3);
            this.panelBox.Controls.Add(this.txtUser);
            this.panelBox.Controls.Add(this.label2);
            this.panelBox.Controls.Add(this.lblTitle);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(175, 40);
            this.lblTitle.Text = "ĐĂNG NHẬP";

            // 
            // label2 (Tên đăng nhập)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 120);
            this.label2.Text = "Tên đăng nhập:";

            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(230, 115);
            this.txtUser.Size = new System.Drawing.Size(180, 27);

            // 
            // label3 (Mật khẩu)
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 170);
            this.label3.Text = "Mật khẩu:";

            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(230, 165);
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(180, 27);

            // 
            // label4 (Chức vụ)
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 215);
            this.label4.Text = "Chức vụ:";

            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(205, 240);
            this.rbAdmin.Text = "Quản lý";

            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Checked = true;
            this.rbStaff.Location = new System.Drawing.Point(205, 270);
            this.rbStaff.Text = "Nhân viên";

            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.Location = new System.Drawing.Point(180, 330);
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;  // ⚠️ GIỮ NGUYÊN
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // ⚠️ GIỮ NGUYÊN
            this.MaximizeBox = false;
            this.Controls.Add(this.panelBox);
            this.Name = "LoginForm";
            this.Text = "Phần mềm quản lý cửa hàng VLXD";

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Button btnLogin;
    }
}
