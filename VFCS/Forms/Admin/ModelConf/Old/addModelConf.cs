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
    public partial class addModelConf : Template
    {
        bool action_active = false;
        private string modelConf = "";
        private bool confOrModel;

        public addModelConf()
        {
            InitializeComponent();

            iconButtonExit.Text = "Выход";

            iconButtonExit.Size = new Size(104,30);
        }

        private void buttonAddModel_Click(object sender, EventArgs e)
        {
            modelConf = "конфигурации";
            confOrModel = false;
            VisibleObj(true);
            metroRadioButtonCreateNew.Checked = true;
            VisibleObjEdit();
        }

        private void buttonAddConf_Click(object sender, EventArgs e)
        {
            modelConf = "модели";
            confOrModel = true;
            VisibleObj(true);
            metroRadioButtonCreateNew.Checked = true;
            VisibleObjEdit();
        }

        private void addModelConf_Load(object sender, EventArgs e)
        {
            VisibleObj(false);

            //TODO SELECT FROM DB to Combobox
        }

        private void VisibleObj(bool vis)
        {
            metroRadioButtonAddExist.Text = "Добавление к существующей " + modelConf;
            metroRadioButtonCreateNew.Text = "Добавление к новой " + modelConf;

            action_active = vis;
            buttonAddConf.Visible = !vis;
            buttonAddModel.Visible = !vis;
            buttonAdd.Visible = vis;
            metroRadioButtonAddExist.Visible = vis;
            metroRadioButtonCreateNew.Visible = vis;

            foreach (TextBox_ textBox in Controls.OfType<TextBox_>())
                textBox.Visible = vis;

            foreach (ComboBox comboBox in Controls.OfType<ComboBox>())
                comboBox.Visible = vis;

            
        }

        private void VisibleObjEdit()
        {
            if (metroRadioButtonCreateNew.Checked)
            {
                metroComboBoxModel.Visible = false;
                metroComboBoxConf.Visible = false;
                foreach (TextBox_ textBox in Controls.OfType<TextBox_>())
                    textBox.Visible = true;
            }
            if (metroRadioButtonAddExist.Checked)
            {
                foreach (TextBox_ textBox in Controls.OfType<TextBox_>())
                    textBox.Visible = false;
                metroComboBoxConf.Visible = false;
                metroComboBoxModel.Visible = false;

                if (!confOrModel)
                {
                    textBoxModel.Visible = true;
                    metroComboBoxConf.Visible = true;
                }
                else
                {
                    foreach (TextBox_ textBox in Controls.OfType<TextBox_>())
                        textBox.Visible = true;
                    textBoxModel.Visible = false;
                    metroComboBoxModel.Visible = true;
                }
            }
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            if (action_active == false)
            {
                adminStartForm adf = new adminStartForm();
                adf.Show();
                Close();
            }
            if (action_active == true)
            {
                VisibleObj(false);
            }
        }

        private void metroRadioButtonAddExist_CheckedChanged(object sender, EventArgs e)
        {
            VisibleObjEdit();
        }

        private void metroRadioButtonCreateNew_CheckedChanged(object sender, EventArgs e)
        {
            VisibleObjEdit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //TODO DB INSERT
        }
    }
}
