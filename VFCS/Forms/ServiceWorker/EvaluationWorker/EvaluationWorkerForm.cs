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
using VFCS.Forms.Template;

namespace VFCS
{
    public partial class EvaluationWorkerForm : Template
    {
        List<Tuple<int, TimeSpan, TimeSpan>> date = new List<Tuple<int, TimeSpan, TimeSpan>>();

        int currentId = 0;

        List<int> timelessIdReg = new List<int>();

        public EvaluationWorkerForm()
        {
            InitializeComponent();
        }

        private void EvaluationWorkerForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddMonths(2);

            //Add values in List(id, date_start, date_end) from schedule
            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT * FROM [dbo].[Schedule]";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                        date.Add(new Tuple<int, TimeSpan, TimeSpan>((int)rd[0], (TimeSpan)rd[1], (TimeSpan)rd[2]));

                    rd.Close();
                }
                else
                    MessageBox.Show("Ошибка получения расписания");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка" + ex); }

            //Change btn text tag in groupBoxButtonReg
            int i = 0;
            foreach (Control btn in groupBoxButtonReg.Controls)
                if (btn is Button_)
                {
                    btn.Text = date[i].Item2.ToString().Remove(5) + " - " + date[i].Item3.ToString().Remove(5);
                    btn.Click += new EventHandler(btnTimeReg_Click);

                    btn.Enabled = false;

                    btn.BackColor = FlatColors.GreenDark;

                    btn.Tag = ++i;
                }

            // Button Reg Currnt and timeless load
            //Current Reg
            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [id_reg]" +
                    " FROM [dbo].[Registration] join [dbo].[Schedule]" +
                    " ON [dbo].[Schedule].[id_schedle] = [dbo].[Registration].[id_schedule]" +
                    " WHERE [date_service] = CAST(GETDATE() AS DATE)" +
                    " AND CAST(GETDATE() AS TIME(7))" +
                    " BETWEEN[dbo].[Schedule].[time_start] AND [dbo].[Schedule].[time_end]";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    buttonCurrent.Enabled = true;
                    buttonCurrent.BackColor = FlatColors.Red;

                    while (dr.Read())
                        currentId = (int)dr[0];
                }
                else
                {
                    buttonCurrent.Enabled = false;
                    buttonCurrent.BackColor = FlatColors.GreenDark;
                }

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            //Timeless Reg
            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [id_reg] FROM [dbo].[Registration] " +
                    " join [dbo].[Schedule]" +
                    " ON [dbo].[Schedule].[id_schedle] = [dbo].[Registration].[id_schedule]" +
                    " WHERE [id_status_work] = 1" +
                    " AND [date_service] <= CAST(GETDATE()-1 AS DATE)";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    buttonTimeless.Enabled = true;
                    buttonTimeless.BackColor = FlatColors.Red;

                    while (dr.Read())
                        timelessIdReg.Add((int)dr[0]);
                }
                else
                {
                    buttonTimeless.Enabled = false;
                    buttonTimeless.BackColor = FlatColors.GreenDark;
                }

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btnTimeReg_Click(object sender, EventArgs e)
        {
            var btn = (Button_)sender;
            int idSchedule = (int)btn.Tag;

            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [id_reg] FROM [dbo].[Registration]" +
                    " WHERE [date_service] = @dateService" +
                    " AND [id_schedule] = @idSchedule";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@dateService", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@idSchedule", idSchedule);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    currentId = (int)dr[0];
                    dr.Close();

                    Connection.connection.Close();

                    ewCurrentForm ewcf = new ewCurrentForm(currentId, 0);
                    ewcf.Show();
                    Close();
                }
                else
                    MessageBox.Show("Ошибка получения регистрационных данных");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка" + ex); }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
                dateToday();
        }

        private void dateToday()
        {
            int i = 0;

            if (dateTimePicker1.Value.Date == DateTime.Now.Date)
            {
                foreach (Control btn in groupBoxButtonReg.Controls)
                {
                    if (btn is Button_)
                    {
                        if (date.Count != 0)
                        {
                            if (date[i].Item2 <= TimeSpan.FromHours(DateTime.Now.Hour))
                            {
                                btn.Enabled = false;
                                btn.Visible = false;
                            }
                            else
                            {
                                btn.Enabled = true;
                                btn.Visible = true;
                                btn.BackColor = FlatColors.GreenDark;
                                dateTimeBook();
                            }
                        }                      
                        i++;
                    }
                }
            }
            else
                dateTimeBook();
        }

        private void dateTimeBook()
        {
            List<int> idShedule = new List<int>();

            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [id_schedule] " +
                    " FROM [dbo].[Registration] " +
                    " WHERE date_service = @dateService" +
                    " AND [dbo].[Registration].[id_employee] = @id_employee";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@dateService", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@id_employee", Connection.userEmployeeId);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                        idShedule.Add((int)rd[0]);

                    rd.Close();
                }

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка" + ex); }

            for (int i = 0; i < idShedule.Count; i++)
                foreach (Control btn in groupBoxButtonReg.Controls)
                    if (btn is Button_)
                    {
                        if (((int)btn.Tag) == idShedule[i])
                        {
                            btn.BackColor = FlatColors.Red;
                            btn.Enabled = true;
                        }
                        else
                        {
                            btn.BackColor = FlatColors.GreenDark;
                            btn.Enabled = false;
                        }
                    }

        }

        private void buttonTimeless_Click(object sender, EventArgs e)
        {
            ewTimelessForm ewtf = new ewTimelessForm(timelessIdReg);
            ewtf.Show();
            Close();
        }

        private void buttonCurrent_Click(object sender, EventArgs e)
        {
            ewCurrentForm ewcf = new ewCurrentForm(currentId, 1);
            ewcf.Show();
            Close();
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            if (Connection.userRole == "adm") // Admin
            {
                adminStartForm asf = new adminStartForm();
                asf.Show();
                Close();
            }
            if (Connection.userRole == "ewr") // ew Worker
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
