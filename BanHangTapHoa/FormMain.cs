using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace BanHangTapHoa
{
    public partial class frmMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public frmMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,54);
            panelMenu.Controls.Add(leftBorderBtn);
            menucon();
        }

        private void menucon()
        {
            panelMenuDanhMuc.Visible = false;
        }

        private void hidemenucon()
        {
            if(panelMenuDanhMuc.Visible == true)
            {
                panelMenuDanhMuc.Visible = false;
            }
        }
        
        private void showmenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hidemenucon();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        // cấu trúc màu rbg cho button
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(67, 170, 229);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }

        }
        // MÀU CỦA RGB CỦA MENU
        private struct RGBColors
        {
            public static Color color4 = Color.FromArgb(79, 18, 18);



        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(55, 146, 201);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void btnTepTin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            showmenu(panelMenuDanhMuc);

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);

        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);

        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            hidemenucon();
        }

        private void btnChatLieu_Click(object sender, EventArgs e)
        {

            hidemenucon();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
