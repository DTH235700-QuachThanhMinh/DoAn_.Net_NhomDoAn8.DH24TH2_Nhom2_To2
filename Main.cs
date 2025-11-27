using QuanLyCuaHang_VLXD.UC;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCuaHang_VLXD
{
    public partial class MainForm : Form
    {
        private string _username;
        private string _role;

        public MainForm(string username, string role)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            _username = username;
            _role = role;

            // Chuyển role sang dạng tiếng Việt cho đúng hiển thị
            string roleDisplay = (_role == "QuanLy") ? "Quản lý" : "Nhân viên";

            lblWelcome.Text = $"Xin chào: {_username} ({roleDisplay})";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Nếu muốn ẩn bớt quyền theo chức vụ (tùy chọn)
            if (_role == "NhanVien")
            {
                btn1.Enabled = false; // Quản lý nhân viên
                btn3.Enabled = false; // Quản lý nhà cung cấp
            }
        }

        private void LoadUC(UserControl uc)
        {
            panelContent.Controls.Clear();       // Xóa giao diện cũ
            uc.Dock = DockStyle.Fill;            // Tự động căng vừa panel
            panelContent.Controls.Add(uc);       // Thêm UC vào panel
        }

        // ================================
        // Sự kiện cho 10 nút menu 
        // ================================
        private void btn1_Click(object sender, EventArgs e)
        {
            if (_role != "QuanLy" && _role != "admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
                return;
            }

            LoadUC(new UCNhanVien());
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            LoadUC(new UCKhachHang());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (_role != "QuanLy" && _role != "admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
                return;
            }

            LoadUC(new UCNhaCungCap());
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            LoadUC(new UCVatLieu());
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            LoadUC(new UCHoaDon());
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            LoadUC(new UCCTHoaDon());
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            LoadUC(new UCPhieuNhap());
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            LoadUC(new UCCTPhieuNhap());
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
