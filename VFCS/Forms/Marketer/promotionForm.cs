using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VFCS.Classes.Style;
using VFCS.Classes.Style.Animation;
using VFCS.Classes.Style.Controls;
using VFCS.Forms.Marketer;
using VFCS.Forms.Template;

namespace VFCS
{
    public partial class promotionForm : Template
    {
        private Card selectCard = null;

        private int borderSize = 2;

        private List<Card> activePromo = new List<Card>();

        private bool activePromoPage = true;

        public promotionForm()
        {
            InitializeComponent();

            CollapseMenu();
        }

        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void iconButtonMenu_Click_1(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (panelMenu.Width > 100)
            {
                panelMenu.Width = 50;
                //button_1.Visible = false;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    //iconButtonSetting.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
                    //menuButton.ForeColor = FlatColors.Blue;
                    menuButton.BackColor = FlatColors.Blue;
                    menuButton.FlatStyle = FlatStyle.Flat;
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 165;
                //button_1.Visible = true;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    //iconButtonSetting.IconChar = FontAwesome.Sharp.IconChar.EllipsisH;
                    //menuButton.ForeColor = FlatColors.Blue;
                    menuButton.BackColor = FlatColors.Blue;
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            if (Connection.userRole == "adm") // Admin
            {
                adminStartForm asf = new adminStartForm();
                asf.Show();
                Close();
            }
            if (Connection.userRole == "prm") // Promotion
            {
                //Connection.userLogin = "";
                Connection.userRole = "";
                Connection.userEmployeeId = 0;

                mainForm mf = new mainForm();
                mf.Show();
                Close();
            }
        }

        private void promotionForm_Load(object sender, EventArgs e)
        {
            buttonAdd.BackColor = FlatColors.Blue;

            Padding = new Padding(borderSize);
            BackColor = Color.FromArgb(98, 102, 244);

            panelMenu.BackColor = FlatColors.Blue;

            panelColor1.BackColor = FlatColors.Blue;

            MinimumSize = new Size(800, 450);

            panelTop.Dock = DockStyle.Top;
            panelMenu.Dock = DockStyle.Left;
            panelWorkSpace.Dock = DockStyle.Fill;

            //buttonDelete.Visible = false;
            //buttonAdd.Visible = false;
            //buttonEdit.Visible = false;
            //buttonArchive.Visible = false;

            //buttonActivePromotion.BackColor = FlatColors.LightGray;


            //Reverse = value < Value ? true : false;
            if (Connection.userRole != "adm")
            {
                buttonDelete.Enabled = false;
            }

            if (selectCard == null)
            {
                buttonDelete.Enabled = false;
                buttonArchive.Enabled = false;
                buttonEdit.Enabled = false;
            }

            //activePromoPage = true;

            panelMain.AutoScroll = true;
            panelMain.Controls.Clear();

            if (activePromoPage)
            {
                buttonArchive.Text = "Архивировать";
            }
            if (!activePromoPage)
            {
                buttonArchive.Text = "Активировать";
            }

            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [id_promotion], [name_promotion], " +
                    " [short_description_promotion], [photo_name], [active_status] " +
                    " FROM [dbo].[Promotion]";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    int i = 1;

                    while (reader.Read())
                    {
                        if ((bool)reader[4] == activePromoPage)
                        {
                            Panel panEmpty = new Panel();
                            panEmpty.Height = 20;
                            panEmpty.Dock = DockStyle.Top;

                            Panel_ pan = new Panel_();
                            pan.Height = 200;
                            pan.Dock = DockStyle.Top;

                            Card card = new Card();
                            card.Dock = DockStyle.Fill;
                            card.FontHeader = new Font("Arial", 22, FontStyle.Bold);
                            card.FontDescrition = new Font("Arial", 14);

                            if (!((double)i / 2 == Math.Truncate((double)i / 2)))
                                card.BackColor = FlatColors.GrayLight2;

                            PictureBox photoPromo = new PictureBox();
                            photoPromo.Dock = DockStyle.Left;
                            photoPromo.Height = 200;
                            photoPromo.Width = 200;
                            photoPromo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                            photoPromo.SizeMode = PictureBoxSizeMode.Zoom;

                            if (reader[3] == DBNull.Value)
                                photoPromo.Image = Properties.Resources.no_photo;
                            else
                                photoPromo.Image = Properties.Resources.ResourceManager.GetObject((string)reader[3]) as Image;


                            card.BackColorCurtain = FlatColors.Blue;
                            card.TextHeader = (string)reader[1];
                            card.TextDescrition = (string)reader[2];

                            //pan.Controls.Add(namePromo);
                            //pan.Controls.Add(descriptionPromo);

                            //card.BringToFront();

                            pan.Controls.Add(card);
                            pan.Controls.Add(photoPromo);

                            panelMain.Controls.Add(panEmpty);
                            panelMain.Controls.Add(pan);

                            card.Tag = (reader[0]).ToString();
                            card.Click += new EventHandler(promoCard_Click);

                            activePromo.Add(card);

                            i++;
                        }
                    }
                    reader.Close();
                }
                else
                    MessageBox.Show("Erroe read DB");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            Connection.connection.Close();
        }

        private void promoCard_Click(object sender, EventArgs e)
        {
            

            var card = (Card)sender;

            for (int i = activePromo.Count - 1; i > -1; i--)
            {
                activePromo[i].BackColorCurtain = FlatColors.Blue;
                activePromo[i].Invalidate();
            }

            if (selectCard == card)
            {
                if (Connection.userRole == "adm")
                {
                    buttonDelete.Enabled = false;
                    buttonDelete.BackColor = FlatColors.LightGray;
                }

                selectCard = null;
                buttonArchive.BackColor = FlatColors.GrayDark;
                buttonEdit.BackColor = FlatColors.GrayDark;
                buttonArchive.Enabled = false;
                buttonEdit.Enabled = false;
            }
            else
            {
                if (Connection.userRole == "adm")
                {
                    buttonDelete.Enabled = true;
                    buttonDelete.BackColor = FlatColors.Blue;
                } 

                selectCard = card;
                card.BackColorCurtain = FlatColors.Red;
                //pan.LineColor = FlatColors.Red;
                //pan.LineWidth = 4.0F;

                buttonArchive.Enabled = true;
                buttonEdit.Enabled = true;
                buttonArchive.BackColor = FlatColors.Blue;
                buttonEdit.BackColor = FlatColors.Blue;
            }
            card.Invalidate();

            //MessageBox.Show(selectCard.Tag.ToString());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectCard != null)
            {
                editPromotionForm epf = new editPromotionForm(Convert.ToInt32(selectCard.Tag));
                epf.Show();
                Close();
            }
            else
                MessageBox.Show("Выбирете акцию для того чтобы изменить ее");
        }

        private void iconButtonArchivePromotion_Click(object sender, EventArgs e)
        {
            activePromoPage = false;
            promotionForm_Load(sender, e);
        }

        private void iconButtonActivePromotion_Click(object sender, EventArgs e)
        {
            activePromoPage = true;
            promotionForm_Load(sender, e);
        }

        [Obsolete]
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectCard != null && Connection.userRole == "adm")
            {
                try
                {
                    Connection.connection.Open();

                    string sqlExp = "DELETE FROM [dbo].[Active_Promotions] WHERE [id_promotion] = @id_promo";
                    SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                    cmd.Parameters.Add("@id_promo", Convert.ToInt32(selectCard.Tag));

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Delete successful");
                        Connection.connection.Close();
                        promotionForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Delete error");
                        selectCard = null;
                        Connection.connection.Close();
                        promotionForm_Load(sender, e);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        [Obsolete]
        private void buttonArchive_Click(object sender, EventArgs e)
        {
            int activeStatus;

            if (activePromoPage)
            {
                activeStatus = 0;
            }
            else
            {
                activeStatus = 1;
            }

            if (selectCard != null)
            {
                try
                {
                    Connection.connection.Open();

                    string sqlExp = "UPDATE [dbo].[Promotion] SET [active_status] = @status WHERE [id_promotion] = @id_promo;";
                    SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                    cmd.Parameters.AddWithValue("@status", activeStatus);
                    cmd.Parameters.Add("@id_promo", Convert.ToInt32(selectCard.Tag));

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Change status successful");
                        Connection.connection.Close();

                        buttonEdit.BackColor = FlatColors.GrayDark;
                        buttonArchive.BackColor = FlatColors.GrayDark;
                        buttonDelete.BackColor = FlatColors.GrayDark;

                        promotionForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Archive error");
                        selectCard = null;
                        Connection.connection.Close();
                        promotionForm_Load(sender, e);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addPromotionForm adf = new addPromotionForm();
            adf.Show();
            Close();
        }
    }
}
