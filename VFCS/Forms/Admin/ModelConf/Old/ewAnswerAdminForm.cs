using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VFCS.Forms.Template;

namespace VFCS
{
    public partial class ewAnswerAdminForm : Template
    {
        public ewAnswerAdminForm()
        {
            InitializeComponent();
        }

        private void ewAnswerAdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.connection.Open();

                string sqlExp = "";

                Connection.connection.Close();
            }
            catch { }
        }
    }
}
