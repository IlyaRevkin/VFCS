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
    public partial class addServiceForm : Template
    {
        public addServiceForm()
        {
            InitializeComponent();
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.connection.Open();

                string sqlExp = "INSERT INTO [dbo].[Service] VALUES" +
                    " (@name, @price)";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@price", textBoxPrice.Text);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Данныые внесены успешно");

                    adminStartForm asf = new adminStartForm();
                    asf.Show();
                    Close();
                }
                else
                    MessageBox.Show("Ошибка внесения данных");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            adminStartForm asf = new adminStartForm();
            asf.Show();
            Close();
        }

        private void addServiceForm_Load(object sender, EventArgs e)
        {
            if (Setting_.themeStyle == "Dark")
            {
                textBoxPrice.BackColor = FlatColors.LightGray;
                textBoxPrice.BorderColor = Color.White;

                textBoxName.BackColor = FlatColors.LightGray;
                textBoxName.BorderColor = Color.White;
            }
        }
    }
}
