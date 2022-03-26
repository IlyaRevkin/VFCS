using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VFCS.Classes.Style;
using VFCS.Classes.Style.Animation;
using VFCS.Properties;

namespace VFCS.Forms.Template
{
    public partial class Template : MetroFramework.Forms.MetroForm
    {
        public Template()
        {
            InitializeComponent();

            //Bitmap a = new Bitmap((Bitmap)Resources.ResourceManager.GetObject("icon"));
            //Icon = Icon.FromHandle(a.GetHicon());

            timer1.Enabled = true;
            timer1.Interval = 100;

            Animator.Start();

            Size resolution = Screen.PrimaryScreen.Bounds.Size;

            //Size = new Size(resolution.Width / 7, resolution.Height / 6);

            MinimizeBox = true;
            MaximizeBox = false;

            MinimumSize = new Size(285, 186);
            //MaximumSize = new Size(resolution.Width / 5, resolution.Height / 5);

            panelTop.BackColor = FlatColors.BlueDark;
            BackColor = FlatColors.GrayLight2;

            StyleManager = Setting_.StyleForm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Font = new Font("Arial", 18);
            labelTime.Text = DateTime.Now.ToLongTimeString();

            labelDate.Font = new Font("Arial", 9);
            labelDate.Text = " " + DateTime.Now.ToLongDateString();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, FlatColors.BlueDark, ButtonBorderStyle.Solid);
        }
    }
}
