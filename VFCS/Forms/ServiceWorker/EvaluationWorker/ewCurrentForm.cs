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
    public partial class ewCurrentForm : Template
    {
        int idReg;
        int status;

        List<int> workersId = new List<int>();
        int workerId;

        public ewCurrentForm()
        {
            InitializeComponent();
        }

        public ewCurrentForm(int idReg, int status)
        {
            InitializeComponent();

            this.idReg = idReg;
            this.status = status;
        }

        private void ewCurrentForm_Load(object sender, EventArgs e)
        {
            if (status != 1)
            {
                buttonComplite.Visible = false;
                metroComboBoxEmployee.Visible = false;
                metroTextBoxWorkDescription.Visible = false;
            }
            //else
            //{
                //buttonComplite.Visible = true;
                //metroComboBoxEmployee.Visible = true;
                //metroTextBoxWorkDescription.Visible = true;
            //}

            labelModelConf.Text = "";
            labelNameClient.Text = "";
            labelService.Text = "Сервесы: ";

            //SELECT Reg data
            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [name], [model_name], [id_configuration], [description_service]" +
                    " FROM [dbo].[Registration]" +
                    " join [dbo].[Model] ON [dbo].[Model] .[id_model] = [dbo].[Registration].[id_model]" +
                    " join [dbo].[Service_Reg] ON [dbo].[Service_Reg].[id_reg] = [dbo].[Registration].[id_reg]" +
                    " join [dbo].[Service] ON [dbo].[Service].[id_service] = [dbo].[Service_Reg].[id_service]" +
                    " WHERE [dbo].[Registration].[id_reg] = @idReg";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@idReg", idReg);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        labelNameClient.Text = "Имя клиента: " + (string)dr[0];
                        labelModelConf.Text = "Модель: " + dr[1].ToString() + 
                            " Конфигурация: " + dr[2].ToString();
                        labelService.Text += (string)dr[3] + " | ";
                    }
                    dr.Close();
                }

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            
            //SELECT free employee
            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [first_name], [last_name], [id_employee]" +
                    " FROM [dbo].[Employee]" +
                    " WHERE [status] = 1";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        metroComboBoxEmployee.Items.Add((string)dr[0] + " " + (string)dr[1]);
                        workersId.Add((int)dr[2]);
                    }
                    dr.Close();
                }

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void buttonComplite_Click(object sender, EventArgs e)
        {
            if (metroComboBoxEmployee.Text != "")
            {
                try
                {
                    Connection.connection.Open();

                    string sqlExp = "UPDATE [dbo].[Registration] SET " +
                        " [id_status_work] = 2," +
                        " [id_employee] = @idEmployee" +
                        " WHERE [id_reg] = @idReg";
                    SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                    cmd.Parameters.AddWithValue("@idReg", idReg); 
                    cmd.Parameters.AddWithValue("@idEmployee", workerId);

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        Connection.connection.Close();

                        if (INSERT_INTO_WE() && UPDATE_SSW_Status())
                        {
                            MessageBox.Show("OK");

                            EvaluationWorkerForm ewf = new EvaluationWorkerForm();
                            ewf.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка обновления статуса заказа");
                            back_data();
                        }
                    }
                    else
                        MessageBox.Show("");

                    Connection.connection.Close();
                }
                catch (Exception ex ) { MessageBox.Show(ex.ToString()); }
            }
            else
                MessageBox.Show("Выбирете рабочего");
        }

        private bool INSERT_INTO_WE()
        {
            try
            {
                Connection.connection.Open();

                string sqlExp = "INSERT INTO [dbo].[Work_Evaluation] VALUES" +
                    " (@workDescription, @idEmployee, @idReg)";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@workDescription", metroTextBoxWorkDescription.Text);
                cmd.Parameters.AddWithValue("@idEmployee", workerId);
                cmd.Parameters.AddWithValue("@idReg", idReg);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    Connection.connection.Close();

                    return true;
                }
                else
                    MessageBox.Show("Ошибка внесения в таблицу [dbo].[Work_Evaluation]");

                Connection.connection.Close();

                return false;
            }
            catch (Exception ex ) { MessageBox.Show(ex.ToString()); return false; }
        }

        private bool UPDATE_SSW_Status()
        {
            try
            {
                Connection.connection.Open();

                string sqlExp = "UPDATE [dbo].[Employee]" +
                    " SET [status] = 0" +
                    " WHERE [id_employee] = @idEmployee";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@idEmployee", workerId);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    Connection.connection.Close();

                    return true;
                }
                else
                {
                    string sqlExpDel = "DELETE FROM [dbo].[Work_Evaluation]" +
                        " WHERE [id_work_evaluation] = (SELECT MAX([id_work_evaluation]) " +
                        " FROM [dbo].[Work_Evaluation])";
                    SqlCommand cmdDel = new SqlCommand(sqlExpDel, Connection.connection);

                    if (cmdDel.ExecuteNonQuery() != 0)
                        MessageBox.Show("Данные из таблицы были удалины в связи " +
                            "с ошибкой обновления статуса рабочего");
                    else
                        MessageBox.Show("Ошибка обновления статуса рабочего и удаления данных " +
                            "в таблице [dbo].[Work_Evaluation]");

                    Connection.connection.Close();

                    return false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return false; }
        }

        private void back_data()
        {
            try
            {
                Connection.connection.Open();

                string sqlExpUpReg = "UPDATE [dbo].[Registration] " +
                       " SET [id_status_work] = 1" +
                       " WHERE [id_reg] = @idReg";
                SqlCommand cmdUpReg = new SqlCommand(sqlExpUpReg, Connection.connection);

                cmdUpReg.Parameters.AddWithValue("@idReg", idReg);

                string sqlExpUpEmp = "UPDATE [dbo].[Employee]" +
                    " SET [status] = 1" +
                    " WHERE [id_employee] = @idEmployee";
                SqlCommand cmdUpEmp = new SqlCommand(sqlExpUpEmp, Connection.connection);

                cmdUpReg.Parameters.AddWithValue("@idReg", idReg);

                if (cmdUpReg.ExecuteNonQuery() != 0 && cmdUpEmp.ExecuteNonQuery() != 0)
                {
                    Connection.connection.Close();

                    ewCurrentForm ewcf = new ewCurrentForm();
                    ewcf.Show();
                    Close();
                }
                else
                    MessageBox.Show("Данные были возвращены к изначальным статусам");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void metroComboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            workerId = workersId[metroComboBoxEmployee.SelectedIndex];
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            EvaluationWorkerForm ewr = new EvaluationWorkerForm();
            ewr.Show();
            Close();
        }
    }
}
