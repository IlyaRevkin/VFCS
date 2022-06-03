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
    public partial class addConfForm : Template
    {
        #region--Переменные
        private string name;
        private double horsepower;
        private double capacity;
        private int idFuel;

        private int idTypeWD = 0;
        private int idTransmission = 0;
        #endregion

        public addConfForm()
        {
            InitializeComponent(); 
        }

        public addConfForm(string name, double horsepower, double capacity, int idFuel)
        {
            InitializeComponent();

            this.name = name;
            this.horsepower = horsepower;
            this.capacity = capacity;
            this.idFuel = idFuel;
        }

        private void addConfForm_Load(object sender, EventArgs e)
        {
            metroComboBoxTransmission.DropDownStyle = ComboBoxStyle.DropDownList;
            metroComboBoxTypeWD.DropDownStyle = ComboBoxStyle.DropDownList;

            // Load data about transmission
            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [transmission_name] FROM [dbo].[Transmission]";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                    while (rd.Read())
                        metroComboBoxTransmission.Items.Add((string)rd[0]);
                else
                {
                    MessageBox.Show("Ошибка получения данных о доступных КПП!");

                    adminStartForm asf = new adminStartForm();
                    asf.Show();
                    Close();
                }

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            // Load data about typeWD
            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [type_WD_name] FROM [dbo].[Type_WD]";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                    while (rd.Read())
                        metroComboBoxTypeWD.Items.Add((string)rd[0]);
                else
                {
                    MessageBox.Show("Ошибка получения данных о доступных приводах!");

                    adminStartForm asf = new adminStartForm();
                    asf.Show();
                    Close();
                }

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            metroComboBoxTransmission.SelectedIndex = 0;
            metroComboBoxTypeWD.SelectedIndex = 0;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (metroComboBoxTransmission.Text == "")
                MessageBox.Show("Выбирете КПП!");
            else if (metroComboBoxTypeWD.Text == "")
                MessageBox.Show("Выбирете тип привода!");
            else
            {
                mergeConfModel mcf = new 
                    mergeConfModel(name, horsepower, capacity, idFuel, idTypeWD, idTransmission);
                mcf.Show();
                Close();
            }
        }

        private void metroComboBoxTypeWD_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTypeWD = metroComboBoxTypeWD.SelectedIndex;
        }

        private void metroComboBoxTransmission_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTransmission = metroComboBoxTransmission.SelectedIndex;
        }

        private void buttonNext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char)e.KeyChar == (Char)Keys.Enter)
                buttonNext_Click(this, null);
        }
    }
}
