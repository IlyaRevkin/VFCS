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
    public partial class sswOrderForm : Template
    {
        int idReg;
        int idConf;

        List<(int, string, int, int, int)> expressStatusList = new List<(int, string, int, int, int)>();
        int idStatus;
        int priceStatus = 0;

        int price = 0;

        public sswOrderForm()
        {
            InitializeComponent();
        }

        public sswOrderForm(int idReg, int idConf)
        {
            InitializeComponent();

            this.idReg = idReg;
            this.idConf = idConf;
        }

        private void sswOrderForm_Load(object sender, EventArgs e)
        {
            metroTextBoxDescriptionOrder.Multiline = true;

            //ComboBoxStatus
            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT * FROM [dbo].[Express_status]";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                    while (dr.Read())
                    {
                        expressStatusList.Add((Convert.ToInt32(dr[0]), dr[1].ToString(),
                            Convert.ToInt32(dr[2]), Convert.ToInt32(dr[3]), Convert.ToInt32(dr[4])));
                        metroComboBoxStatus.Items.Add((string)dr[1]);
                    }
                else
                    MessageBox.Show("Ошибка получения данных о статусах доставки");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void metroComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceStatus = 0;
            priceStatus += expressStatusList[metroComboBoxStatus.SelectedIndex].Item3;
            idStatus = expressStatusList[metroComboBoxStatus.SelectedIndex].Item1;
            labelStatusInfo.Text = "Цена: " + expressStatusList[metroComboBoxStatus.SelectedIndex].Item3
                + "\nОт " + expressStatusList[metroComboBoxStatus.SelectedIndex].Item4 
                + " до " + expressStatusList[metroComboBoxStatus.SelectedIndex].Item5 + " дней";

            labelPrice.Text = "Итоговая цена: " + (priceStatus + price);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelPrice.Invalidate();
        }

        private void metroTextBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBoxPrice.Text != "")
                price = Convert.ToInt32(metroTextBoxPrice.Text);
            else
                price = 0;

            labelPrice.Text = "Итоговая цена: " + (priceStatus + price);
        }

        private void metroTextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) ||
                e.KeyChar == (char)Keys.Back ||
                e.KeyChar == (char)Keys.Delete)
            { e.Handled = true; }
        }

        private void metroTextBoxDescriptionOrder_Click(object sender, EventArgs e)
        {
            metroTextBoxDescriptionOrder.Focus();
        }

        private void metroTextBoxPrice_MouseEnter(object sender, EventArgs e)
        {
            //Cursor = Cursors.IBeam;
        }

        private void metroTextBoxPrice_MouseLeave(object sender, EventArgs e)
        {
            //Cursor = Cursors.Arrow;
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            if (Update_Reg(3))
            {
                try
                {
                    Connection.connection.Open();

                    string sqlExp = "INSERT INTO [dbo].[Order] VALUES" +
                        " (@descOrder, @idExpStatus, @idConf, 1, CAST(GETDATE() AS DATE), @price, @idReg)";
                    SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                    cmd.Parameters.AddWithValue("@descOrder", metroTextBoxDescriptionOrder.Text);
                    cmd.Parameters.AddWithValue("@idExpStatus", idStatus);
                    cmd.Parameters.AddWithValue("@idConf", idConf);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@idReg", idReg);

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Заказ отправлен на склад");
                    }
                    else
                    {
                        Connection.connection.Close();
                        MessageBox.Show("Ошабка внесения данных о заказе");
                        Update_Reg(2);
                    }

                    Connection.connection.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }          
        }

        private bool Update_Reg(int statusWork)
        {
            try
            {
                Connection.connection.Open();

                string sqlExp = "UPDATE [dbo].[Registration]" +
                    " SET [id_status_work] = @statusWork" +
                    " WHERE [id_reg] = @idReg";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@idReg", idReg);
                cmd.Parameters.AddWithValue("@statusWork", statusWork);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Данные заказа были обновлены");

                    Connection.connection.Close();

                    return true;
                }
                else
                {
                    MessageBox.Show("Ошибка обновления данных");

                    Connection.connection.Close();

                    return false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return false; }
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            serviceWorkerForm sswf = new serviceWorkerForm();
            sswf.Show();
            Close();
        }
    }
}
