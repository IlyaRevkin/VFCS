using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFCS
{
    public partial class MessageBoxAnswer : MetroFramework.Forms.MetroForm
    {
        public MessageBoxAnswer()
        {
            InitializeComponent();

            metroLabel1.Font = new Font("Arial", 18, FontStyle.Bold);

            Resizable = false;
        }
    }
}
