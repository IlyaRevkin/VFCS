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

namespace VFCS.Forms
{
    public partial class Setting_ : MetroFramework.Forms.MetroForm
    {
        public static MetroFramework.Components.MetroStyleManager styleManager;

        public static string themeStyle;

        public Setting_()
        {
            InitializeComponent();

            MinimizeBox = false;
            MaximizeBox = false;

            BackColor = FlatColors.GrayLight2;

            StyleManager = metroStyleManager1;

            mcbColor.Font = new Font("Arial", 14);
            mcbTheme.Font = new Font("Arial", 14);
            metroLabel1.Font = new Font("Arial", 14);
            metroLabel2.Font = new Font("Arial", 14);
        }

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            styleManager = metroStyleManager1;
            mainForm mf = new mainForm();
            mf.Show();
        }

        public static MetroFramework.Components.MetroStyleManager StyleForm()
        {
            return styleManager;
        }

        public static string ThemeForm()
        {
            return themeStyle;
        }

        private void mcbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mcbTheme.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    themeStyle = "Dark";
                    break;
                case 1:
                    themeStyle = "Light";
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
            }
        }

        private void mcbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(mcbColor.SelectedIndex);
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            Region = new Region(RoundedRect.RoundedRect1(new Rectangle(0, 0, Width, Height), 5));

            mcbColor.SelectedIndex = 0;
            mcbTheme.SelectedIndex = 0;
        }
    }
}
