using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangTapHoa
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            // đổi màu chổ này
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(176, 102, 254), Color.FromArgb(99, 226, 255), 179);

            graphics.FillRectangle(b, gradient_rectangle);
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(set_background);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
