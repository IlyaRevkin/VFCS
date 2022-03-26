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

namespace VFCS.Forms.Template
{
    public partial class TemplateWork : Template
    {
        public TemplateWork()
        {
            InitializeComponent();

            panelColor1.BackColor = FlatColors.Red;
            panelColor2.BackColor = FlatColors.Red;

            panelMainContainer.BackColor = FlatColors.GrayLight;
            panelMenuContainer.BackColor = FlatColors.GrayLight;

            foreach (Button_ button in Controls.OfType<Button_>())
                button.BackColor = FlatColors.Red;
        }

        public void pictureBoxExit_Click(object sender, EventArgs e)
        {

        }
    }
}
