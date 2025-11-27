using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang_VLXD
{
    public partial class LoginForm : Form
    {
        public string Username { get; private set; }
        public string Role { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            string role = rbAdmin.Checked ? "QuanLy" : "NhanVien";

            var accounts = new Dictionary<string, (string pass, string role)>
            {
                { "admin", ("123456", "QuanLy") },
                { "nv1", ("abc123", "NhanVien") },
                { "nv2", ("abc456", "NhanVien") }
            };

            if (!accounts.ContainsKey(user))
            {
                MessageBox.Show("Tên đăng nhập không tồn tại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var acc = accounts[user];

            if (acc.pass != pass)
            {
                MessageBox.Show("Sai mật khẩu! Vui lòng nhập lại", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (acc.role != role)
            {
                MessageBox.Show("Sai chức vụ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Username = user;
            Role = role;
            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
