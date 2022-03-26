using MetroFramework.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
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
            if (tbLogin.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите логин");
            }
            else
            {
                if (false) //TODO Wrong Login
                {
                    MessageBox.Show("Логин введён неверно");
                    tbLogin.Text = "";
                }
                else
                {
                    if (tbPassword.Text == "")
                    {
                        MessageBox.Show("Пожалуйста, введит пароль");
                    }
                    else
                    {
                        if (false) //TODO Wrong Password
                        {
                            MessageBox.Show("Пароль введён неверно");
                            tbPassword.Text = "";
                        }
                        else
                        {
                            switch (true)
                            {
                                case false:
                                   Hide();
                                   break;

                                case true:
                                    adminStartForm asf = new adminStartForm();
                                    asf.Show();
                                    Hide();
                                    break;

                                default:
                                    MessageBox.Show("Данному пользователю не присвоина роль");
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(this, null);
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
    }
}