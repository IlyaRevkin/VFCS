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
using VFCS.Forms.Template;

namespace VFCS
{
    public partial class adminStartForm : Template
    {
        public adminStartForm()
        {
            InitializeComponent();
        }

        private void adminStartForm_Load(object sender, EventArgs e)
        {
            Text = "VFCS Admin";
        }

        private void cardPromotion_Click(object sender, EventArgs e)
        {
            promotionForm pf = new promotionForm();
            pf.Show();
            Close();
        }

        private void cardService_Click(object sender, EventArgs e)
        {
            addServiceForm asf = new addServiceForm();
            asf.Show();
            Close();
        }

        private void cardModelConf_Click(object sender, EventArgs e)
        {
            modelConfForm mcf = new modelConfForm();
            mcf.Show();
            Close();
        }

        private void cardClientReg_Click(object sender, EventArgs e)
        {
            clientRegForm crf = new clientRegForm();
            crf.Show();
            Close();
        }

        private void cardewManager_Click(object sender, EventArgs e)
        {
            EvaluationWorkerForm ewf = new EvaluationWorkerForm();
            ewf.Show();
            Close();
        }

        private void cardSSW_Click(object sender, EventArgs e)
        {
            serviceWorkerForm sswf = new serviceWorkerForm();
            sswf.Show();
            Close();
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Connection.userRole = "";
            Connection.userEmployeeId = 0;

            mainForm mf = new mainForm();
            mf.Show();
            Close();
        }

        private void iconButtonPromo_Click(object sender, EventArgs e)
        {
            cardPromotion_Click(sender, e);
        }

        private void iconButtonServices_Click(object sender, EventArgs e)
        {
            cardService_Click(sender, e);
        }

        private void iconButtonModelConf_Click(object sender, EventArgs e)
        {
            cardModelConf_Click(sender, e);
        }

        private void iconButtonClient_Click(object sender, EventArgs e)
        {
            cardClientReg_Click(sender, e);
        }

        private void iconButtonEW_Click(object sender, EventArgs e)
        {
            cardewManager_Click(sender, e);
        }

        private void iconButtonSSW_Click(object sender, EventArgs e)
        {
            cardSSW_Click(sender, e);
        }
    }
}
