using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VFCS.Classes.Style;
using VFCS.Forms.Template;

namespace VFCS
{
    public partial class promotionForm : Template
    {
        private int borderSize = 2;

        FlowLayoutPanel fpanel;

        public promotionForm()
        {
            InitializeComponent();

            CollapseMenu();

            MaximizeBox = true;

            Padding = new Padding(borderSize);
            BackColor = Color.FromArgb(98,102,244);

            iconButtonMenu.ForeColor = FlatColors.BlueDark;
            iconButtonMenu.BackColor = FlatColors.BlueDark;

            panelMenu.BackColor = FlatColors.Blue;

            panelColor1.BackColor = FlatColors.Blue;

            MinimumSize = new Size(800, 450);

            //buttonActivePromotion.BackColor = FlatColors.LightGray;
        }

        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBoxExit_Click_1(object sender, EventArgs e)
        {
            if (true) // User Admin
            {
                adminStartForm asf = new adminStartForm();
                asf.Show();
                Close();
            }
            if (false) // User Promotion 
            {

            }
        }

        private void buttonArchivePromotion_Click(object sender, EventArgs e)
        {
            //buttonArchivePromotion.BackColor = FlatColors.LightGray;
            //buttonActivePromotion.BackColor = FlatColors.GrayLight;
        }

        private void buttonActivePromotion_Click(object sender, EventArgs e)
        {
            //buttonArchivePromotion.BackColor = FlatColors.GrayLight;
            //buttonActivePromotion.BackColor = FlatColors.LightGray;
        }

        private void iconButtonMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (panelMenu.Width > 100)
            {
                panelMenu.Width = 50;
                //button_1.Visible = false;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    //iconButtonSetting.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
                    //menuButton.ForeColor = FlatColors.Blue;
                    menuButton.BackColor = FlatColors.Blue;
                    menuButton.FlatStyle = FlatStyle.Flat;
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 165;
                //button_1.Visible = true;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    //iconButtonSetting.IconChar = FontAwesome.Sharp.IconChar.EllipsisH;
                    //menuButton.ForeColor = FlatColors.Blue;
                    menuButton.BackColor = FlatColors.Blue;
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10,0,0,0);
                }
            }
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            if (true) // Admin
            {
                adminStartForm asf = new adminStartForm();
                asf.Show();
                Close();
            }
            if (false) // Promotion
            {

            }
        }

        private void promotionForm_Load(object sender, EventArgs e)
        {
            List<Button> btns = new List<Button>()
            {
                new Button() {Text = "firstButton", Location = new Point(0,0) },
                new Button() {Text = "secondButton", Location = new Point(100,0) },
                new Button() {Text = "thirdButton", Location = new Point(200,0) },
            };
            for (int i = 0; i < 3; i++)
            {
                if (i < btns.Count)
                    panelMain.Controls.Add(btns[i]);
            }
        }
    }
}
