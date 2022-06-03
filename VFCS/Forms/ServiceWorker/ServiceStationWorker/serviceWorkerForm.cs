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
using VFCS.Forms.Template;

namespace VFCS
{
    public partial class serviceWorkerForm : Template
    {
        int idReg = 0;
        int idConf = 0;
        List<int> idServices = new List<int>();

        public serviceWorkerForm()
        {
            InitializeComponent();
        }

        private void serviceWorkerForm_Load(object sender, EventArgs e)
        {
            buttonAddService.Enabled = false;
            buttonOrder.Enabled = false;
            buttonCompleteReg.Enabled = false;

            labelService.Text = "Сервесы: ";
            labelModelConf.Text = "Конфигурация: " ;
            labelName.Text = "Имя: ";

            try
            {
                Connection.connection.Open();

                //Reg with status 2
                string sqlExp = "SELECT [dbo].[Registration].[id_reg], [dbo].[Registration].[name]," +
                    " [dbo].[Registration].[id_configuration], [dbo].[Service].[description_service]," +
                    " [dbo].[Service].[id_service] " +
                    " FROM [dbo].[Registration]" +
                    " join [dbo].[Service_Reg] ON [dbo].[Service_Reg].[id_reg] = [dbo].[Registration].[id_reg]" +
                    " join [dbo].[Service] ON [dbo].[Service].[id_service] = [dbo].[Service_Reg].[id_service]" +
                    " WHERE [id_employee] = @idEmployee" +
                    " AND ([id_status_work] = 2 OR [id_status_work] = 4)" +
                    " ORDER BY [id_status_work] DESC";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@idEmployee", Connection.userEmployeeId);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        idReg = (int)dr[0];
                        idConf = (int)dr[2];
                        labelName.Text = (string)dr[1];
                        labelModelConf.Text = dr[2].ToString();

                        //TODO join for Conf Model Service 
                        //MessageBox.Show((string)dr[6]);
                        labelService.Text += dr[3].ToString() + " | ";

                        idServices.Add(Convert.ToInt32(dr[4]));
                    }
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Новых заказов нет");

                    Connection.connection.Close();
                    Connection.userEmployeeId = 0;
                    Connection.userRole = "";

                    mainForm mf = new mainForm();
                    mf.Show();
                    Close();
                }

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            if (idReg != 0 && idConf != 0)
            {
                buttonAddService.Enabled = true;
                buttonOrder.Enabled = true;
                buttonCompleteReg.Enabled = true;
            }
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            sswServiceForm sswServiceForm = new sswServiceForm(idReg, idServices);
            sswServiceForm.Show();
            Close();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            sswOrderForm sswOrderForm = new sswOrderForm(idReg, idConf);
            sswOrderForm.Show();
            Close();
        }

        private void buttonCompleteReg_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.connection.Open();

                string sqlExp = "UPDATE [dbo].[Registration]" +
                    " SET [id_status_work] = 5" +
                    " WHERE [id_reg] = @idReg";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@idReg", idReg);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("OK");

                    Connection.connection.Close();

                    //serviceWorkerForm swf = new serviceWorkerForm();
                    //swf.Show();
                    //Close();
                }
                else
                    MessageBox.Show("Ошибка обновления статуса заказа на завершено");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            try
            {
                Connection.connection.Open();

                string sqlExp = "UPDATE [dbo].[Employee]" +
                    " SET [dbo].[Employee].[status] = 1" +
                    " WHERE (select [id_employee] " +
                    " from Registration where id_reg = @idReg) " +
                    " = [dbo].[Employee].[id_employee]";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@idReg", idReg);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("OK1");

                    Connection.connection.Close();

                    serviceWorkerForm swf = new serviceWorkerForm();
                    swf.Show();
                    Close();
                }
                else
                    MessageBox.Show("Ошибка обновления статуса заказа на завершено");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            if (Connection.userRole == "adm") // Admin
            {
                adminStartForm asf = new adminStartForm();
                asf.Show();
                Close();
            }
            if (Connection.userRole == "ssw") // Service Station Worker
            {
                //Connection.userLogin = "";
                Connection.userRole = "";

                mainForm mf = new mainForm();
                mf.Show();
                Close();
            }
        }
    }
}
