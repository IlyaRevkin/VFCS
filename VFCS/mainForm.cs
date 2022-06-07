using MetroFramework.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VFCS.Classes.Style;
using VFCS.Classes.Style.Animation;
using VFCS.Forms;

namespace VFCS
{
    //public IButtonControl AcceptButton { get; set; }
    public partial class mainForm : MetroFramework.Forms.MetroForm
    {
        public mainForm()
        {
            Icon = Properties.Resources.iconICO;

            InitializeComponent();

            Animator.Start();

            Size resolution = Screen.PrimaryScreen.Bounds.Size;

            //Size = new Size(resolution.Width / 7, resolution.Height / 6);

            MinimizeBox = true;
            //MinimizeBox = false;
            MaximizeBox = false;

            MinimumSize = new Size(270, 160);
            //MaximumSize = new Size(resolution.Width / 5, resolution.Height / 5);

            KeyPreview = true;

            Text = "";

            metroStyleManager1 = Setting_.StyleForm();

            StyleManager = metroStyleManager1;

            Icon = Properties.Resources.iconICO;

        }

        private void iconButtonSetting_Click(object sender, EventArgs e)
        {
            Setting_ setting = new Setting_();
            setting.Show();
            Close();
        }

        private void tsShowPassword_Click(object sender, EventArgs e)
        {
            if (tsShowPassword.Checked)
            {
                tbPassword.PasswordChar = false;
            }
            if (!tsShowPassword.Checked)
            {
                tbPassword.PasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                try
                {
                        Connection.connection.Open();

                        string sqlExp = "SELECT [login], [password], [role], [id_employee] FROM [dbo].[Login] " +
                    " join [dbo].[Position] ON [dbo].[Login].[id_position] = [dbo].[Position].[id_position]" +
                    " WHERE [login]=@login COLLATE Latin1_General_CS_AS";
                        SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);
                        cmd.Parameters.AddWithValue("@login", tbLogin.Text);
                        SqlDataReader reader = cmd.ExecuteReader();


                if (tbLogin.Text == "")
                {
                    MessageBox.Show("Пожалуйста, введите логин");
                }
                else
                {
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Логин введён неверно");
                        tbLogin.Text = "";
                        tbPassword.Text = "";
                    }
                    else
                    {
                        reader.Read();

                        if (tbPassword.Text == "")
                        {
                            MessageBox.Show("Пожалуйста, введит пароль");
                        }
                        else
                        {
                            if ((string)reader[1] != tbPassword.Text)
                            {
                                MessageBox.Show("Пароль введён неверно");
                                tbPassword.Text = "";
                            }
                            else
                            {
                                //Connection.userLogin = tbLogin.Text;
                                Connection.userEmployeeId = (int)reader[3];

                                switch ((string)reader[2])
                                {
                                    case "adm":
                                        Connection.userRole = (string)reader[2];
                                        Connection.connection.Close();
                                        reader.Close();

                                        adminStartForm asf = new adminStartForm();
                                        asf.Show();
                                        Close();
                                        break;

                                    case "prm":
                                        Connection.userRole = (string)reader[2];
                                        Connection.connection.Close();
                                        reader.Close();

                                        promotionForm pf = new promotionForm();
                                        pf.Show();
                                        Close();
                                        break;

                                    case "cmn":
                                        Connection.userRole = (string)reader[2];
                                        Connection.connection.Close();
                                        reader.Close();

                                        clientRegForm crf = new clientRegForm();
                                        crf.Show();
                                        Close();
                                        break;

                                    case "ewr":
                                        Connection.userRole = (string)reader[2];
                                        Connection.connection.Close();
                                        reader.Close();

                                        EvaluationWorkerForm ewf = new EvaluationWorkerForm();
                                        ewf.Show();
                                        Close();
                                        break;

                                    case "ssw":
                                        Connection.userRole = (string)reader[2];
                                        Connection.connection.Close();
                                        reader.Close();

                                        serviceWorkerForm swf = new serviceWorkerForm();
                                        swf.Show();
                                        Close();
                                        break;

                                    case null:

                                        break;

                                    default:
                                        Connection.connection.Close();
                                        MessageBox.Show("Данному пользователю не присвоина роль");
                                        break;
                                }
                            }
                        }
                    }
                }   
                reader.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            Connection.connection.Close();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Region = new Region(RoundedRect.RoundedRect1(new Rectangle(0, 0, Width, Height), 5));

            if (Setting_.themeStyle == "Dark")
            {
                tbLogin.BackColor = FlatColors.LightGray;
                tbLogin.BorderColor = Color.White;
                
                tbPassword.BackColor = FlatColors.LightGray;
                tbPassword.BorderColor = Color.White;
                
                label1.ForeColor = FlatColors.GrayLight2;

                iconButtonSetting.IconColor = FlatColors.GrayLight2;
                iconButtonSetting.ForeColor = Color.Black;
            }
            else
            {
                tbLogin.BackColor = FlatColors.GrayLight2;
                tbLogin.BorderColor = FlatColors.Blue;
                
                tbPassword.BackColor = FlatColors.GrayLight2;
                tbPassword.BorderColor = FlatColors.Blue;
                
                label1.ForeColor = Color.Black;

                iconButtonSetting.IconColor = Color.Black;
                iconButtonSetting.ForeColor = Color.White;
            } 
        }

        private void mainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char)e.KeyChar == (Char)Keys.Enter)
                btnLogin_Click(this, null);
        }
    }
}