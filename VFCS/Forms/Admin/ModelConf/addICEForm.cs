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
    public partial class addICEForm : Template
    {
        int idTypeFuel = 0;

        public addICEForm()
        {
            InitializeComponent();
        }

        private void addICEForm_Load(object sender, EventArgs e)
        {
            if (Setting_.themeStyle == "Dark")
            {
                textBoxCapacity.BackColor = FlatColors.LightGray;
                textBoxCapacity.BorderColor = Color.White;

                textBoxHorsePower.BackColor = FlatColors.LightGray;
                textBoxHorsePower.BorderColor = Color.White;

                textBoxName.BackColor = FlatColors.LightGray;
                textBoxName.BorderColor = Color.White;
            }

            metroComboBoxFuelType.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [fuel_name], [id_type_fuel] FROM [dbo].[Type_Fuel]";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                    while (rd.Read())
                        metroComboBoxFuelType.Items.Add((string)rd[0]);

                rd.Close();

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            metroComboBoxFuelType.SelectedIndex = 0;
        }

        private void metroComboBoxFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTypeFuel = metroComboBoxFuelType.SelectedIndex;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
                MessageBox.Show("Заполните поле \"Название двигателя\"");
            else if (textBoxHorsePower.Text == "")
                MessageBox.Show("Заполните поле \"Лошадиные силы\"");
            else if (metroComboBoxFuelType.Text == "")
                MessageBox.Show("Выберете тип топлива");
            else if (textBoxCapacity.Text == "")
                MessageBox.Show("Заполните поле \"Объём двигателя\"");
            else
            {
                if (Convert.ToDouble(textBoxCapacity.Text) < 10.0 &&
                    Convert.ToDouble(textBoxCapacity.Text) > 0.0 &&
                    Convert.ToDouble(textBoxHorsePower.Text) > 0.0) //TODO Проверка соблюдения условий введённых значений для дальнейшего добовления в БД
                {
                    string name = textBoxName.Text;
                    double horsepower = Convert.ToDouble(textBoxHorsePower.Text);
                    double capacity = Convert.ToDouble(textBoxCapacity.Text);
                    int fuelID = ++idTypeFuel;

                    addConfForm acf = new addConfForm(name, horsepower, capacity, fuelID);
                    acf.Show();
                    Close();
                }
                else
                    MessageBox.Show("Данные были введены неверно");
            }
        }

        private void addICEForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char)e.KeyChar == (Char)Keys.Enter)
                buttonAdd_Click(this, null);
        }

        private void textBoxCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxHorsePower_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO
            if (!Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxCapacity_TextChanged(object sender, EventArgs e)
        {
            //TODO
            if (textBoxName.Text.Count() < 2)
                textBoxName.Text += ",";
            if (textBoxName.Text.Count() > 3)
                textBoxCapacity.Text.Remove(3, textBoxName.Text.Length);
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
                adminStartForm asf = new adminStartForm();
                asf.Show();
                Close();
        }
    }
}
