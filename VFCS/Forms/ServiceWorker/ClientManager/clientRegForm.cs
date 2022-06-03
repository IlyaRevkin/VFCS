using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VFCS.Classes.Style;
using VFCS.Classes.Style.Controls;
using VFCS.Forms;
using VFCS.Forms.Template;

namespace VFCS
{
    public partial class clientRegForm : Template
    {
        List<Tuple<int, TimeSpan, TimeSpan>> date = new List<Tuple<int, TimeSpan, TimeSpan>>();
        
        List<int> employees = new List<int>();
        int employee;

        List<int> models = new List<int>();
        int model;

        List<int> confs = new List<int>();
        int conf;

        List<(CheckBox, int)> services = new List<(CheckBox, int)>();

        List<(CheckBox, int)> promos = new List<(CheckBox, int)>();

        int idReg;

        int price = 0;

        bool done = false;

        public clientRegForm()
        {
            InitializeComponent();
        }

        private void clientRegForm_Load(object sender, EventArgs e)
        {
            groupBoxButtonReg.Visible = false;

            if (Setting_.themeStyle == "Dark")
            {
                textBoxName.BackColor = FlatColors.LightGray;
                textBoxName.BorderColor = Color.White;
            }

            iconButtonExit.Text = "Выход";
            metroComboBoxConf.Enabled = false;
            panelService.AutoScroll = true;
            panelPromo.AutoScroll = true;

            dateTimePicker1.Enabled = false;
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
                    MessageBox.Show("Ошибка получения доступного времени");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            //Change btn text tag in groupBoxButtonReg
            int i = 0;
            foreach (Control btn in groupBoxButtonReg.Controls)
                if (btn is Button_)
                {
                    btn.Text = date[i].Item2.ToString().Remove(5) + 
                        " - " + date[i].Item3.ToString().Remove(5);
                    btn.Click += new EventHandler(btnTimeReg_Click);
                    btn.Enabled = false;
                    btn.Tag = ++i;
                }

            //Add items in comboBoxEmployee
            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [first_name], [last_name], [dbo].[Employee].[id_employee] " +
                    " FROM [dbo].[Employee]" +
                    " join [dbo].[Login] ON [dbo].[Employee].[id_employee] = [dbo].[Login].[id_employee]" +
                    " join [dbo].[Position] ON [dbo].[Login].[id_position] = [dbo].[Position].[id_position]" +
                    " WHERE [role] = 'ewr'";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        metroComboBoxEmployee.Items.Add((string)rd[0] + " " + (string)rd[1]);
                        employees.Add((int)rd[2]);
                    }
                    rd.Close();
                }
                else
                    MessageBox.Show("Ошибка получения данных о менеджерах приёмки");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            //Add items in comboBoxModel
            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT * FROM [dbo].[Model]";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        metroComboBoxModel.Items.Add((string)rd[1]);
                        models.Add((int)rd[0]);
                    }
                    rd.Close();
                }
                else
                    MessageBox.Show("Ошибка получения моделей");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка" + ex); }

            //Add checkBox in panelService
            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT * FROM [dbo].[Service]";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        //TODO перенос панелей
                        Panel_ pan = new Panel_();
                        pan.Height = 50;
                        pan.Dock = DockStyle.Top;

                        if (!(Convert.ToDouble(rd[0]) / 2 == Math.Truncate(Convert.ToDouble(rd[0]) / 2)))
                                pan.BackColor = FlatColors.GrayLight2;
                        else
                            pan.BackColor = Color.WhiteSmoke;

                        Label lb1 = new Label();
                        lb1.Dock = DockStyle.Top;
                        lb1.AutoSize = true;
                        lb1.Text = "Услуга: " + rd[1].ToString() +
                             "\nЦена: " + rd[2].ToString() + " руб";

                        CheckBox ch = new CheckBox();
                        ch.Dock = DockStyle.Bottom;
                        ch.Tag = rd[0];
                        services.Add((ch, (int)rd[2]));

                        if ((int)rd[0] != 1)
                        {     
                            pan.Controls.Add(ch);
                            pan.Controls.Add(lb1);

                            panelService.Controls.Add(pan);
                        }
                    }
                    rd.Close();
                }
                else
                    MessageBox.Show("Ошибка получения доступных сервисов");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            //Add checkBox in panelPromo
            //(рядом с акцией можно добавить кнопу по которой будет показана вся информация по акции)
            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [id_promotion], [name_promotion]," +
                    " [short_description_promotion], [full_description_promotion], " +
                    " [active_status], [sale] " +
                    " FROM [dbo].[Promotion]";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                        if (Convert.ToInt32(rd[4]) == 1)
                        {
                            //TODO перенос панелей
                            Panel_ pan = new Panel_();
                            pan.Height = 65;
                            pan.Dock = DockStyle.Top;

                            if (!(Convert.ToDouble(rd[0]) / 2 == Math.Truncate(Convert.ToDouble(rd[0]) / 2)))
                                pan.BackColor = FlatColors.GrayLight2;
                            else
                                pan.BackColor = Color.WhiteSmoke;

                            Label lb1 = new Label();
                            lb1.Dock = DockStyle.Top;
                            lb1.AutoSize = true;
                            lb1.Text = "Акция: " + rd[1].ToString()
                                + "\nОписание: " + rd[2].ToString()
                                + "\nЦена: " + rd[5].ToString();

                            //Button_ btn = new Button_();
                            //btn.Dock = DockStyle.Fill;
                            //btn.Text = "More info";

                            //TODO buttonClick
                            //btn += ;

                            CheckBox ch = new CheckBox();
                            ch.Dock = DockStyle.Bottom;
                            ch.Tag = rd[0];

                            if (rd[5] != DBNull.Value)
                                promos.Add((ch, (int)rd[5]));
                            else
                                promos.Add((ch, 0));

                            if (Convert.ToBoolean(rd[5]) != false)
                            {
                                pan.Controls.Add(ch);
                                pan.Controls.Add(lb1);

                                panelPromo.Controls.Add(pan);
                            }
                        }

                    rd.Close();
                }
                else
                    MessageBox.Show("Ошибка получения данных об акциях");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            dateToday();
        }

        private void btnTimeReg_Click(object sender, EventArgs e)
        {
                var btnTime = (Button_)sender;
                int idTime = (int)btnTime.Tag;

            // INSERT INTO Registration
            try
            {
                Connection.connection.Open();

                for (int i = 0; i < services.Count; i++)
                    if (services[i].Item1.Checked)
                        price += services[i].Item2;

                for (int i = 0; i < promos.Count; i++)
                    if (promos[i].Item1.Checked)
                        price -= promos[i].Item2;

                string sqlExp = "INSERT INTO [dbo].[Registration] VALUES" +
                    " ((SELECT CAST(GETDATE() AS DATE)), " +
                    "@idSchedule, @dateService, @idEmployee, " +
                    " @idConf, @price, 1, @nameClient, @idModel);";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@idSchedule", idTime);
                cmd.Parameters.AddWithValue("@dateService", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@idEmployee", employee);
                cmd.Parameters.AddWithValue("@idConf", conf);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@nameClient", textBoxName.Text);
                cmd.Parameters.AddWithValue("@idModel", model);

                if (cmd.ExecuteNonQuery() != 0)
                {
                    // Get id_reg
                    try
                    {
                        string sqlExpIdModel = "SELECT MAX([id_reg]) FROM [dbo].[Registration]";
                        SqlCommand cmdIdModel = new SqlCommand(sqlExpIdModel, Connection.connection);
                        SqlDataReader rd = cmdIdModel.ExecuteReader();

                        if (rd.HasRows)
                        {
                            rd.Read();
                            idReg = (int)rd[0];
                            rd.Close();
                        }
                        else
                            MessageBox.Show("Ошибка получения id_reg для связи данных");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                    if (promos.Count == 0)
                    {
                        Connection.connection.Close();

                        mergeReg_Service();
                    }
                    else
                    {
                        Connection.connection.Close();

                        mergeReg_Service();
                        mergeReg_Promo();
                    }

                    if (done == true)
                    {
                        MessageBox.Show("OK");

                        Connection.connection.Close();

                        if (Connection.userRole == "adm")
                        {
                            adminStartForm asf = new adminStartForm();
                            asf.Show();
                            Close();
                        }
                        if (Connection.userRole == "cmn")
                        {
                            clientRegForm crf = new clientRegForm();
                            crf.Show();
                            Close();
                        }
                    }
                }
                else
                    MessageBox.Show("Ошибка внесения заявки");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка" + ex); }
        }

        private void mergeReg_Service()
        {
            // INSERT INTO Service_Reg
            try
            {
                Connection.connection.Open();

                List<int> idServices = new List<int>();
                idServices.Add(1);

                for (int i = 0; i < services.Count; i++)
                    if (services[i].Item1.Checked)
                        idServices.Add((int)services[i].Item1.Tag);

                foreach (int idService in idServices)
                {
                    string sqlExp = "INSERT INTO [dbo].[Service_Reg] VALUES" +
                   " (@idService, @idReg);";
                    SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                    cmd.Parameters.AddWithValue("@idService", idService);
                    cmd.Parameters.AddWithValue("@idReg", idReg);

                    if (cmd.ExecuteNonQuery() != 0)
                        done = true;
                    else
                    {
                        done = false;
                        MessageBox.Show("Ошибка связывания заказа и сервисов");
                    }
                }

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка" + ex); }
        }

        private void mergeReg_Promo()
        {
            // INSERT INTO Promo_Reg
            try
            {
                Connection.connection.Open();

                List<int> idPromos = new List<int>();

                for (int i = 0; i < promos.Count; i++)
                    if (promos[i].Item1.Checked)
                        idPromos.Add((int)promos[i].Item1.Tag);

                foreach (int idPromo in idPromos)
                { 
                    string sqlExp = "INSERT INTO [dbo].[Promo_Reg] VALUES" +
                   " (@idPromo, @idReg);";
                    SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                    cmd.Parameters.AddWithValue("@idPromo", idPromo);
                    cmd.Parameters.AddWithValue("@idReg", idReg);

                    if (cmd.ExecuteNonQuery() != 0)
                        done = true;
                    else
                    {
                        done = false;
                        MessageBox.Show("Ошибка связи таблицы акций и заказа");
                    }
                }
                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка" + ex); }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control btn in groupBoxButtonReg.Controls)
            {
                if (btn is Button_)
                {
                    btn.BackColor = FlatColors.GreenDark;
                    //btn.Enabled = true;
                    btn.Visible = true;
                }

                if (metroComboBoxEmployee.Text == "")
                    btn.Enabled = false;
                else
                    btn.Enabled = true;
            }
            
            if (date.Count != 0)
            {
                dateToday();
                dateTimeBook();
            }

            if ((dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday)
                || (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday))
            {
                MessageBox.Show("Вы пытаетесь выбрать не рабочий день");
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void dateToday()
        {
            if (dateTimePicker1.Value.Date == DateTime.Now.Date)
            {
                int i = 0;
                foreach (Control btn in groupBoxButtonReg.Controls)
                {
                    if (btn is Button_)
                    {
                        if (date[i].Item2 <= TimeSpan.FromHours(DateTime.Now.Hour))
                        {
                            btn.BackColor = FlatColors.Red;
                            btn.Enabled = false;
                            btn.Visible = false;
                        }
                        else
                            btn.BackColor = FlatColors.GreenDark;
                        
                        i++;
                    }
                }
            }
        }

        private void dateTimeBook()
        {
            dateTimePicker1.Enabled = true;

            List<int> idShedule = new List<int>();

            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [id_schedule] " +
                    " FROM [dbo].[Registration] " +
                    " join [dbo].[Employee] ON [dbo].[Employee].[id_employee] = [dbo].[Registration].[id_employee]" +
                    " WHERE date_service = @dateService" +
                    " AND [dbo].[Registration].[id_employee] = @id_employee";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@dateService", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@id_employee", employee);

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
                        if (((int)btn.Tag) == idShedule[i])
                        {
                            btn.BackColor = FlatColors.Red;
                            btn.Enabled = false;
                        }
        }

        private void metroComboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee = employees[metroComboBoxEmployee.SelectedIndex];

            foreach (Control btn in groupBoxButtonReg.Controls)
                if (btn is Button_)
                    btn.Enabled = true;

            dateTimeBook();
        }

        private void metroComboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroComboBoxConf.Items.Clear();
            metroComboBoxConf.Enabled = true;

            model = models[metroComboBoxModel.SelectedIndex];

            ////Add items in comboBoxConf
            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT * FROM [dbo].[Configuration]" +
                    " join [dbo].[Model_Conf] ON [dbo].[Model_Conf].[id_conf] = [dbo].[Configuration].[id_configuration]" +
                    " join [dbo].[Model] ON [dbo].[Model].[id_model] = [dbo].[Model_Conf].[id_model]" +
                    " WHERE [dbo].[Model].[id_model] = @idModel";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@idModel", model);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        metroComboBoxConf.Items.Add((int)rd[0]);
                        confs.Add((int)rd[0]);
                    }
                    rd.Close();
                }
                else
                    MessageBox.Show("Ошибка плучения конфигураций модели");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка" + ex); }
        }

        private void metroComboBoxConf_SelectedIndexChanged(object sender, EventArgs e)
        {
            conf = confs[metroComboBoxConf.SelectedIndex];
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            if (Connection.userRole == "adm") // Admin
            {
                adminStartForm asf = new adminStartForm();
                asf.Show();
                Close();
            }
            if (Connection.userRole == "cmn") // Client Manager
            {
                //Connection.userLogin = "";
                Connection.userRole = "";

                mainForm mf = new mainForm();
                mf.Show();
                Close();
            }
        }

        private void buttonTimeVisible_Click(object sender, EventArgs e)
        {
            if (metroComboBoxConf.Text == "" ||
                metroComboBoxEmployee.Text == "" ||
                metroComboBoxModel.Text == "" ||
                textBoxName.Text == "")
                MessageBox.Show("Не вся поля были заполнены");
            else
            {
                groupBoxButtonReg.Visible = true;

                foreach (Control btn in groupBoxButtonReg.Controls)
                    if (btn is Button_)
                        btn.Visible = true;
            }

            groupBoxButtonReg.Invalidate();
        }
    }
}
