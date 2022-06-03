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

// TODO Диологовое окно с выбором добавить конфигурацию или добавить модель или связать модель с конфигурацией
// TODO выбор модели к которйо добавить конфигурацию через CheckBox
namespace VFCS
{
    public partial class modelConfForm : Template
    {
        public modelConfForm()
        {
            InitializeComponent();

            foreach (Button_ btn in Controls.OfType<Button_>())
                btn.Font = new Font("Arial", 9, FontStyle.Regular);
        }

        private void buttonAddModel_Click(object sender, EventArgs e)
        {
            addModelForm amf = new addModelForm();
            amf.Show();
            Close();
        }

        private void buttonAddConf_Click(object sender, EventArgs e)
        {
            addConfForm acf = new addConfForm();
            acf.Show();
            Close();
        }

        private void buttonAddICE_Click(object sender, EventArgs e)
        {
            addICEForm aif = new addICEForm();
            aif.Show();
            Close();
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            adminStartForm asf = new adminStartForm();
            asf.Show();
            Close();
        }
    }
}
