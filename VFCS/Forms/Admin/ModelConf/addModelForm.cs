using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VFCS.Classes.Style;
using VFCS.Forms;
using VFCS.Forms.Template;

namespace VFCS
{
    public partial class addModelForm : Template
    {
        private string name;

        public addModelForm()
        {
            InitializeComponent();
        }

        private void addModelForm_Load(object sender, EventArgs e)
        {
            if (Setting_.themeStyle == "Dark")
            {
                textBoxModelName.BackColor = FlatColors.LightGray;
                textBoxModelName.BorderColor = Color.White;
            }

            Text = "VFCS добавление модели";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBoxModelName.Text != "")
            {
                name = textBoxModelName.Text;

                mergeConfModel mcf = new mergeConfModel(name);
                mcf.Show();
                Close();
            }
            else
                MessageBox.Show("Введите название модели");
        }

        private void addModelForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char)e.KeyChar == (Char)Keys.Enter)
                buttonNext_Click(this, null);
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            adminStartForm asf = new adminStartForm();
            asf.Show();
            Close();
        }
    }
}
