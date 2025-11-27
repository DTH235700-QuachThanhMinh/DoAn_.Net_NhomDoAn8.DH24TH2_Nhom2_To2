using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHang_VLXD.UC;

namespace QuanLyCuaHang_VLXD
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.panelMenu.Controls.Add(this.btnThoat);
            this.panelMenu.Controls.Add(this.btnQuayLai);
            this.panelMenu.Controls.Add(this.btn8);
            this.panelMenu.Controls.Add(this.btn7);
            this.panelMenu.Controls.Add(this.btn6);
            this.panelMenu.Controls.Add(this.btn5);
            this.panelMenu.Controls.Add(this.btn4);
            this.panelMenu.Controls.Add(this.btn3);
            this.panelMenu.Controls.Add(this.btn2);
            this.panelMenu.Controls.Add(this.btn1);
            this.panelMenu.Controls.Add(this.lblMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 700);
            this.panelMenu.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(130, 620);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 40);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuayLai.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Location = new System.Drawing.Point(10, 620);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(110, 40);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.btn8.Location = new System.Drawing.Point(0, 551);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(250, 52);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8. Quản lý chi tiết phiếu nhập";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.btn7.Location = new System.Drawing.Point(0, 484);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(250, 52);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7. Quản lý phiếu nhập";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.btn6.Location = new System.Drawing.Point(0, 417);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(250, 52);
            this.btn6.TabIndex = 4;
            this.btn6.Text = "6. Quản lý chi tiết hóa đơn";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.btn5.Location = new System.Drawing.Point(0, 350);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(250, 52);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5. Quản lý hóa đơn";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.btn4.Location = new System.Drawing.Point(0, 283);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(250, 52);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4. Quản lý vật liệu";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.btn3.Location = new System.Drawing.Point(0, 216);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(250, 52);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3. Quản lý nhà cung cấp";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.btn2.Location = new System.Drawing.Point(0, 149);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(250, 52);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2. Quản lý khách hàng";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.btn1.Location = new System.Drawing.Point(0, 82);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(247, 52);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1. Quản lý nhân viên";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(24, 28);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(189, 32);
            this.lblMenu.TabIndex = 10;
            this.lblMenu.Text = "MENU CHÍNH";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.lblWelcome.Location = new System.Drawing.Point(299, 307);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(430, 40);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Xin chào: admin (Quản lý)";
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.AutoSize = true;
            this.lblSystemTitle.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.lblSystemTitle.ForeColor = System.Drawing.Color.Red;
            this.lblSystemTitle.Location = new System.Drawing.Point(197, 241);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(610, 44);
            this.lblSystemTitle.TabIndex = 2;
            this.lblSystemTitle.Text = "Hệ thống quản lý cửa hàng VLXD";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Arial", 12F);
            this.lblInstruction.Location = new System.Drawing.Point(348, 364);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(294, 23);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Vui lòng chọn chức năng bên trái";
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Controls.Add(this.lblInstruction);
            this.panelContent.Controls.Add(this.lblSystemTitle);
            this.panelContent.Controls.Add(this.lblWelcome);
            this.panelContent.Location = new System.Drawing.Point(246, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(954, 700);
            this.panelContent.TabIndex = 3;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "Phần mềm quản lý cửa hàng VLXD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

            // ===========================
            // GÁN SỰ KIỆN CLICK CHO MENU
            // ===========================
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            this.btn8.Click += new System.EventHandler(this.btn8_Click);

            // ===========================
            // GÁN SỰ KIỆN CHO HAI NÚT DƯỚI
            // ===========================
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

        }

        private void ButtonStyle(Button btn, string text, int top)
        {
            btn.BackColor = Color.White;
            btn.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Popup;
            btn.Size = new Size(230, 50);
            btn.Location = new Point(10, top);
            btn.Text = text;
            this.panelMenu.Controls.Add(btn);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInstruction;
        private Panel panelContent;
    }
}
