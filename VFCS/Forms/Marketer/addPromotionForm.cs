using MetroFramework.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFCS.Forms.Marketer
{
    public partial class addPromotionForm : MetroFramework.Forms.MetroForm
    {
        public addPromotionForm()
        {
            InitializeComponent();

            imgCheck("no_photo");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            metroTextBoxNamePromo.Text = "";
            metroTextBoxShortDescription.Text = "";
            metroTextBoxFullDescription.Text = "";
            metroTextBoxNameImg.Text = "";
            metroTextBoxSale.Text = "";
            pictureBoxPromoImg.Image = Properties.Resources.no_photo;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            promotionForm pf = new promotionForm();
            pf.Show();
            Close();
        }

        private void buttonCheckImg_Click(object sender, EventArgs e)
        {
            if (imgCheck(metroTextBoxNameImg.Text))
                MessageBox.Show("Изображение существует в ресурсах");
            else
                MessageBox.Show("Изображение отсутствует в ресурсах");
        }

        private bool imgCheck(string img)
        {
            //ResourceManager MyResourceClass =
            //    new ResourceManager(typeof(Resources));

            //ResourceSet resourceSet =
            //    MyResourceClass.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            //foreach (DictionaryEntry entry in resourceSet)
            //{
            //    string resourceKey = entry.Key.ToString();

            //    if (resourceKey == img)
            //        return true;
            //}

            //var assembly = Assembly.GetExecutingAssembly();

            //foreach (var resourceName in assembly.GetManifestResourceNames())
            //    MessageBox.Show(resourceName);

            return false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.connection.Open();

                string sqlExp = "INSERT INTO [dbo].[Active_Promotions] " +
                    "VALUES(@name, @short, @full, @ph_name, 1, @sale)";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                if (metroTextBoxNamePromo.Text.Length > 25 ||
                    metroTextBoxNamePromo.Text.Length == 0 ||
                    metroTextBoxShortDescription.Text.Length > 110 ||
                    metroTextBoxShortDescription.Text.Length == 0 ||
                    metroTextBoxFullDescription.Text.Length > 5000 ||
                    metroTextBoxFullDescription.Text.Length == 0)
                    MessageBox.Show("Данные введены неверно");
                else
                {
                    cmd.Parameters.AddWithValue("@name", metroTextBoxNamePromo.Text);
                    cmd.Parameters.AddWithValue("@short", metroTextBoxShortDescription.Text);
                    cmd.Parameters.AddWithValue("@full", metroTextBoxFullDescription.Text);
                    
                    if (metroTextBoxSale.Text == "")
                        cmd.Parameters.AddWithValue("@sale", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@sale", metroTextBoxSale.Text);

                    if (metroTextBoxNameImg.Text == "")
                        cmd.Parameters.AddWithValue("@ph_name", DBNull.Value);
                    if (imgCheck(metroTextBoxNameImg.Text))
                        cmd.Parameters.AddWithValue("@ph_name", metroTextBoxNameImg.Text);
                    else
                        MessageBox.Show("Ошибка внесения изображения");

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Данные были внесены");

                        Connection.connection.Close();

                        promotionForm pf = new promotionForm();
                        pf.Show();
                        Close();
                    }
                    else
                        MessageBox.Show("Ошибка внесения данных");
                }

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void metroTextBoxSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO is digital
        }
    }
}
