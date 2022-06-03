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
using VFCS.Classes.Style.Controls;
using VFCS.Forms.Template;

namespace VFCS
{
    public partial class mergeConfModel : Template
    {
        #region --Переменные
        //data to insert model
        private string nameModel = null;

        // data to insert conf
        private string nameICE;
        private double horsepower;
        private double capacity;
        private int idFuel;
        private int idTypeWD;
        private int idTransmission;

        // complete insert
        private bool done;
        #endregion

        List<CheckBox> chList = new List<CheckBox>();

        public mergeConfModel()
        {
            InitializeComponent();
        }

        // merge new conf with model
        public mergeConfModel(string nameICE, double horsepower, 
            double capacity, int idFuel,
            int idTypeWD, int idTransmission)
        {
            InitializeComponent();

            this.nameICE = nameICE;
            this.horsepower = horsepower;
            this.capacity = capacity;
            this.idFuel = idFuel;
            this.idTypeWD = idTypeWD;
            this.idTransmission = idTransmission;
        }

        // merge new model with conf  
        public mergeConfModel(string nameModel)
        {
            InitializeComponent();

            this.nameModel = nameModel;
        }

        private void mergeConfModel_Load(object sender, EventArgs e)
        {
            panelMain.AutoScroll = true;
            panelMain.Controls.Clear();

            try
            {
                Connection.connection.Open();

                //panels with conf select
                if (nameModel != null)
                {
                    string sqlExp = "SELECT [id_configuration], [ICE_name], [ICE_horsepower], [ICE_capacity]," +
                        " [fuel_name], [type_WD_name] FROM [dbo].[Configuration]" +
                        " join [dbo].[ICE] ON [dbo].[Configuration].[id_ICE] = [dbo].[ICE].[id_ICE]" +
                        " join [dbo].[Type_Fuel] ON [dbo].[ICE].[id_type_fuel] = [dbo].[Type_Fuel].[id_type_fuel]" +
                        " join [dbo].[Type_WD] ON [dbo].[Configuration].[id_type_WD] = [dbo].[Type_WD].[id_type_WD]";
                    SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            Panel_ pan = new Panel_();
                            pan.Height = 100;
                            pan.Dock = DockStyle.Top;

                            if (!((double)rd[0] / 2 == Math.Truncate((double)rd[0] / 2)))
                                pan.BackColor = FlatColors.GrayLight2;

                            Label lb1 = new Label();
                            lb1.Dock = DockStyle.Top;
                            lb1.Text = "" + (string)rd[1] + (string)rd[2] + (string)rd[3] + (string)rd[4] + (string)rd[5];

                            CheckBox ch = new CheckBox();
                            ch.Dock = DockStyle.Bottom;
                            ch.Tag = rd[0];
                            chList.Add(ch);

                            pan.Controls.Add(ch);
                            pan.Controls.Add(lb1);

                            panelMain.Controls.Add(pan);
                        }
                        rd.Close();
                    }
                }
                // panels with model select
                else
                {
                    string sqlExp = "SELECT [id_model], [model_name], [photo_name]" +
                        " FROM [dbo].[Model]";
                    SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);
                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            Panel_ pan = new Panel_();
                            pan.Height = 100;
                            pan.Dock = DockStyle.Top;

                            if (!(Convert.ToDouble(rd[0]) / 2 == Math.Truncate(Convert.ToDouble(rd[0]) / 2)))
                                pan.BackColor = FlatColors.GrayLight2;

                            Label lb1 = new Label();
                            lb1.Dock = DockStyle.Top;
                            lb1.Text = rd[1].ToString();

                            PictureBox photoPromo = new PictureBox();
                            photoPromo.Dock = DockStyle.Left;
                            photoPromo.Height = 100;
                            photoPromo.Width = 100;
                            photoPromo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            photoPromo.SizeMode = PictureBoxSizeMode.Zoom;

                            if (rd[2] == DBNull.Value)
                                photoPromo.Image = Properties.Resources.no_photo;
                            else
                                photoPromo.Image = Properties.Resources.ResourceManager.GetObject((string)rd[2]) as Image;


                            CheckBox ch = new CheckBox();
                            ch.Dock = DockStyle.Bottom;
                            ch.Tag = rd[0];
                            chList.Add(ch);

                            pan.Controls.Add(ch);
                            pan.Controls.Add(lb1);

                            panelMain.Controls.Add(pan);
                        }
                        rd.Close();
                    }
                }
                Connection.connection.Close();
            }
            catch (Exception ex){ MessageBox.Show(ex.ToString()); }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // INSERT Conf
            if (nameModel == null)
            {
                //INSERT ICE 
                try
                {
                    Connection.connection.Open();

                    string sqlExp = "INSERT INTO [dbo].[ICE] VALUES " +
                        " (@name, @horsepower, @capacity, @id_type_fuel)";
                    SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                    cmd.Parameters.AddWithValue("@name", nameICE);
                    cmd.Parameters.AddWithValue("@horsepower", horsepower);
                    cmd.Parameters.AddWithValue("@capacity", capacity);
                    cmd.Parameters.AddWithValue("@id_type_fuel", idFuel);

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        done = true;
                    }
                    else
                    {
                        done = false;

                        MessageBox.Show("Ошибка внесения в [dbo].[ICE], " +
                            "вы будете возвращены на заплнения данных [dbo].[ICE] заново");

                        addICEForm aif = new addICEForm();
                        aif.Show();
                        Close();
                    }
                    Connection.connection.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                //INSERT Configuration
                try
                {
                    Connection.connection.Open();

                    int idICE;

                    string sqlExpSel = "SELECT MAX(id_ICE) FROM [dbo].[ICE]";
                    SqlCommand cmdSel = new SqlCommand(sqlExpSel, Connection.connection);

                    SqlDataReader rd = cmdSel.ExecuteReader();

                    if (rd.HasRows)
                    {
                        rd.Read();
                        idICE = (int)rd[0];
                        rd.Close();

                        string sqlExp = "INSERT INTO [dbo].[Configuration] VALUES " +
                        " (@id_ICE, @id_type_WD, @id_transmission)";
                        SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                        cmd.Parameters.AddWithValue("@id_ICE", idICE);
                        cmd.Parameters.AddWithValue("@id_type_WD", ++idTypeWD);
                        cmd.Parameters.AddWithValue("@id_transmission", ++idTransmission);

                        if (cmd.ExecuteNonQuery() != 0 && done)
                        {
                            int idConf;

                            string sqlExpIdModel = "SELECT MAX([id_configuration]) FROM [dbo].[Configuration]";
                            SqlCommand cmdIdModel = new SqlCommand(sqlExpIdModel, Connection.connection);

                            rd = cmdIdModel.ExecuteReader();

                            if (rd.HasRows)
                            {
                                rd.Read();
                                idConf = (int)rd[0];
                                rd.Close();

                                List<int> idModels = new List<int>();
                                for (int i = 0; i < chList.Count; i++)
                                    if (chList[i].Checked)
                                        idModels.Add((int)chList[i].Tag);

                                foreach (int idModel in idModels)
                                {
                                    sqlExp = "INSERT INTO [dbo].[Model_Conf] VALUES " +
                                        " (@model_id, @id_conf)";
                                    cmd = new SqlCommand(sqlExp, Connection.connection);

                                    cmd.Parameters.AddWithValue("@model_id", idModel);
                                    cmd.Parameters.AddWithValue("@id_conf", idConf);

                                    if (cmd.ExecuteNonQuery() != 0)
                                    {
                                        MessageBox.Show("Данные были внесены успешно!");

                                        adminStartForm asf = new adminStartForm();
                                        asf.Show();
                                        Close();
                                    }
                                    else
                                        MessageBox.Show("Ошибка связывания моделей с конфигурацией");
                                }
                            }
                            else
                            {
                                DelICE();
                                MessageBox.Show("Ошибка получения внесённой конфигурации. " +
                                    "Данные из [dbo].[ICE] были удалены!");
                            }
                        }
                        else
                        {
                            DelICE();
                            MessageBox.Show("Ошибка внесения данных в [dbo].[Configuration]. " +
                                "Данные внесенные в [dbo].[ICE] были удалены!");
                        }
                    }
                    else
                    {
                        DelICE();
                        MessageBox.Show("Ошибка получения данных внесённых в [dbo].[ICE]. " +
                            "Данные из [dbo].[ICE] были удалены!");
                    }

                    Connection.connection.Close();
                }
                catch (Exception ex){ MessageBox.Show(ex.ToString()); }
            }
            // INSERT Model
            else
            {
                int idModel;

                try
                {
                    Connection.connection.Open();

                    string sqlExp = "INSERT INTO [dbo].[Model] VALUES " +
                        " (@model_name, @photo_name)";
                    SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                    cmd.Parameters.AddWithValue("@model_name", nameModel);
                    //TODO
                    cmd.Parameters.AddWithValue("@photo_name", DBNull.Value);

                    //INSERT Model with smth Configuration
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        string sqlExpIdModel = "SELECT MAX([id_model]) FROM [dbo].[Model]";
                        SqlCommand cmdIdModel = new SqlCommand(sqlExpIdModel, Connection.connection);
                        SqlDataReader rd = cmdIdModel.ExecuteReader();

                        if (rd.HasRows)
                        {
                            rd.Read();
                            idModel = (int)rd[0];
                            rd.Close();

                            List<int> idConfs = new List<int>();
                            for (int i = 0; i < chList.Count; i++)
                                if (chList[i].Checked)
                                    idConfs.Add((int)chList[i].Tag);

                            foreach (int idConf in idConfs)
                            {
                                sqlExp = "INSERT INTO [dbo].[Model_Conf] VALUES " +
                                    " (@model_id, @id_conf)";
                                cmd = new SqlCommand(sqlExp, Connection.connection);

                                cmd.Parameters.AddWithValue("@id_conf", idConf);
                                cmd.Parameters.AddWithValue("@model_id", idModel);

                                if (cmd.ExecuteNonQuery() != 0)
                                {
                                    MessageBox.Show("Данные были успешно внесены!");

                                    adminStartForm asf = new adminStartForm();
                                    asf.Show();
                                    Close();
                                }
                                else
                                    MessageBox.Show("Ошибка связывания концигураций с моделью!");
                            }
                        }
                        else
                            MessageBox.Show("Ошибка получения id внесённой модели!");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка внесения модели! " +
                            "Вы будете возвращены на форму внесения модели");

                        addModelForm amf = new addModelForm();
                        amf.Show();
                        Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                Connection.connection.Close();
            }
        }

        private void DelICE()
        {
            try
            {
                Connection.connection.Open();

                string sqlExpDel = "DELETE FROM [dbo].[ICE] WHERE [id_ICE] = (SELECT MAX(id_ICE) FROM [dbo].[ICE]) ";
                SqlCommand cmdDel = new SqlCommand(sqlExpDel, Connection.connection);

                if (cmdDel.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Данные из [dbo].[ICE] были успешно удалены!");

                    addICEForm aif = new addICEForm();
                    aif.Show();
                    Close();
                }
                else
                    MessageBox.Show("Ошибка удаления данных из [dbo].[ICE]. Это гг, сломали прогу");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
