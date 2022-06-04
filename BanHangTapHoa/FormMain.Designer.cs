namespace BanHangTapHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuDanhMuc = new System.Windows.Forms.Panel();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnChatLieu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTroGiup = new FontAwesome.Sharp.IconButton();
            this.btnBaoCao = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnHoaDon = new FontAwesome.Sharp.IconButton();
            this.btnDanhMuc = new FontAwesome.Sharp.IconButton();
            this.btnTepTin = new FontAwesome.Sharp.IconButton();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelMenuDanhMuc.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(146)))), ((int)(((byte)(201)))));
            this.panelMenu.Controls.Add(this.btnTroGiup);
            this.panelMenu.Controls.Add(this.btnBaoCao);
            this.panelMenu.Controls.Add(this.btnTimKiem);
            this.panelMenu.Controls.Add(this.btnHoaDon);
            this.panelMenu.Controls.Add(this.panelMenuDanhMuc);
            this.panelMenu.Controls.Add(this.btnDanhMuc);
            this.panelMenu.Controls.Add(this.btnTepTin);
            this.panelMenu.Controls.Add(this.panel1);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // panelMenuDanhMuc
            // 
            this.panelMenuDanhMuc.Controls.Add(this.btnHangHoa);
            this.panelMenuDanhMuc.Controls.Add(this.btnKhachHang);
            this.panelMenuDanhMuc.Controls.Add(this.btnNhanVien);
            this.panelMenuDanhMuc.Controls.Add(this.btnChatLieu);
            resources.ApplyResources(this.panelMenuDanhMuc, "panelMenuDanhMuc");
            this.panelMenuDanhMuc.Name = "panelMenuDanhMuc";
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnHangHoa, "btnHangHoa");
            this.btnHangHoa.FlatAppearance.BorderSize = 0;
            this.btnHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnKhachHang, "btnKhachHang");
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnNhanVien, "btnNhanVien");
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnChatLieu
            // 
            this.btnChatLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnChatLieu, "btnChatLieu");
            this.btnChatLieu.FlatAppearance.BorderSize = 0;
            this.btnChatLieu.ForeColor = System.Drawing.Color.White;
            this.btnChatLieu.Name = "btnChatLieu";
            this.btnChatLieu.UseVisualStyleBackColor = true;
            this.btnChatLieu.Click += new System.EventHandler(this.btnChatLieu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picHome);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnTroGiup
            // 
            resources.ApplyResources(this.btnTroGiup, "btnTroGiup");
            this.btnTroGiup.FlatAppearance.BorderSize = 0;
            this.btnTroGiup.ForeColor = System.Drawing.Color.White;
            this.btnTroGiup.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnTroGiup.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTroGiup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTroGiup.IconSize = 30;
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.UseVisualStyleBackColor = true;
            this.btnTroGiup.Click += new System.EventHandler(this.btnTroGiup_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnBaoCao, "btnBaoCao");
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.IconChar = FontAwesome.Sharp.IconChar.FileMedicalAlt;
            this.btnBaoCao.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBaoCao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBaoCao.IconSize = 30;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTimKiem, "btnTimKiem");
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 30;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnHoaDon, "btnHoaDon");
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnHoaDon.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDon.IconSize = 30;
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDanhMuc, "btnDanhMuc");
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnDanhMuc.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnDanhMuc.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDanhMuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDanhMuc.IconSize = 30;
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnTepTin
            // 
            this.btnTepTin.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTepTin, "btnTepTin");
            this.btnTepTin.FlatAppearance.BorderSize = 0;
            this.btnTepTin.ForeColor = System.Drawing.Color.White;
            this.btnTepTin.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnTepTin.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTepTin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTepTin.IconSize = 30;
            this.btnTepTin.Name = "btnTepTin";
            this.btnTepTin.UseVisualStyleBackColor = true;
            this.btnTepTin.Click += new System.EventHandler(this.btnTepTin_Click);
            // 
            // picHome
            // 
            this.picHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHome.Image = global::BanHangTapHoa.Properties.Resources.shop__8_;
            resources.ApplyResources(this.picHome, "picHome");
            this.picHome.Name = "picHome";
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuDanhMuc.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnTroGiup;
        private FontAwesome.Sharp.IconButton btnBaoCao;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private FontAwesome.Sharp.IconButton btnDanhMuc;
        private FontAwesome.Sharp.IconButton btnTepTin;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Panel panelMenuDanhMuc;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnChatLieu;
    }
}