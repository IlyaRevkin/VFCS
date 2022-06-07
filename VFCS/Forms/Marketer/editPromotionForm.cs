using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFCS.Forms.Marketer
{
    public partial class editPromotionForm : MetroFramework.Forms.MetroForm
    {
        int id;

        public editPromotionForm()
        {
            InitializeComponent();
        }

        public editPromotionForm(int id)
        {
            InitializeComponent();

            this.id = id;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            promotionForm pf = new promotionForm();
            pf.Show();
            Close();
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.connection.Open();

                string sqlExp = "UPDATE [dbo].[Promotion] SET " +
                    " [name_promotion] = @name," +
                    " [short_description_promotion] = @short," +
                    " [full_description_promotion] = @full," +
                    " [photo_name] = @ph_name," +
                    " [sale] = @sale" +
                    " WHERE [id_promotion] = @id_promotion";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@id_promotion", id);

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
                        MessageBox.Show("Данные были изменены");

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

        private void editPromotionForm_Load(object sender, EventArgs e)
        {
            try 
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [id_promotion], [name_promotion], [short_description_promotion]," +
                    "[full_description_promotion], [photo_name], [sale] FROM [dbo].[Promotion]" +
                    "WHERE [id_promotion] = @id_promotion";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);
                cmd.Parameters.AddWithValue("@id_promotion",id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //metroTextBoxNamePromo.Font = new Font("Arial", 24, FontStyle.Bold);
                        metroTextBoxNamePromo.Text = (string)reader[1];
                        metroTextBoxShortDescription.Text = (string)reader[2];
                        metroTextBoxFullDescription.Text = (string)reader[3];

                        if (reader[4] == DBNull.Value)
                        {
                            metroTextBoxNameImg.Text = "";
                            pictureBoxPromoImg.Image = Properties.Resources.no_photo;
                        }
                        else
                        {
                            metroTextBoxNameImg.Text = (string)reader[4];
                            pictureBoxPromoImg.Image = Properties.Resources.ResourceManager.GetObject((string)reader[4]) as Image;
                        }

                        if (reader[5] == DBNull.Value)
                            metroTextBoxSale.Text = "";
                        else
                            metroTextBoxSale.Text = reader[5].ToString();
                    }
                    reader.Close();
                }
                else
                    MessageBox.Show("Ошибка чтения [dbo].[Promotion]");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO is digital
        }
    }
}
