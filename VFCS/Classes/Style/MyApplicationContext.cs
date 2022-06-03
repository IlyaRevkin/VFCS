using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFCS
{
    public class MyApplicationContext : ApplicationContext
    {
        public MyApplicationContext(Form startupForm)
        {
            startupForm.FormClosed += OnFormClosed;
            startupForm.Show();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count > 0)
            {
                foreach (Form form in Application.OpenForms)
                {
                    form.FormClosed -= OnFormClosed;
                    form.FormClosed += OnFormClosed;
                }
            }
            else ExitThread();
        }
    }
}
