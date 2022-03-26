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
using VFCS.Forms.Template;

namespace VFCS
{
    public partial class adminStartForm : Template
    {
        public adminStartForm()
        {
            InitializeComponent();

            Text = "VFCS Admin";

            //card1.Font = new Font("Arial", 12);

            //card1.TextHeader = ;

        }

        private void cardPromotion_Click(object sender, EventArgs e)
        {
            promotionForm pf = new promotionForm();
            pf.Show();
            Close();
        }
    }
}
