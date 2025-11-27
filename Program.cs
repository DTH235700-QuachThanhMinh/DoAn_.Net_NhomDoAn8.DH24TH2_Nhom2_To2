using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHang_VLXD.UC;

namespace QuanLyCuaHang_VLXD
{
    internal static class Program
    {

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mở form đăng nhập trước
            using (LoginForm login = new LoginForm())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // Lấy thông tin đăng nhập từ LoginForm
                    string username = login.Username;
                    string role = login.Role;

                    // Mở mainform với tham số
                    Application.Run(new MainForm(username, role));
                }
                else
                {
                    // Nếu bấm Cancel hoặc tắt cửa sổ -> thoát app
                    Application.Exit();
                }
            }
        }
    }
}
