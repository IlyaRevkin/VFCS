
namespace VFCS
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.iconButtonSetting = new FontAwesome.Sharp.IconButton();
            this.tsShowPassword = new VFCS.ToggleSwitch();
            this.btnLogin = new VFCS.Button_();
            this.tbPassword = new VFCS.TextBox_();
            this.tbLogin = new VFCS.TextBox_();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Показать пароль";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // iconButtonSetting
            // 
            this.iconButtonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSetting.IconChar = FontAwesome.Sharp.IconChar.SlidersH;
            this.iconButtonSetting.IconColor = System.Drawing.Color.Black;
            this.iconButtonSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSetting.IconSize = 20;
            this.iconButtonSetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonSetting.Location = new System.Drawing.Point(190, 127);
            this.iconButtonSetting.Name = "iconButtonSetting";
            this.iconButtonSetting.Size = new System.Drawing.Size(25, 25);
            this.iconButtonSetting.TabIndex = 6;
            this.iconButtonSetting.UseVisualStyleBackColor = true;
            this.iconButtonSetting.Click += new System.EventHandler(this.iconButtonSetting_Click);
            // 
            // tsShowPassword
            // 
            this.tsShowPassword.BackColor = System.Drawing.Color.White;
            this.tsShowPassword.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.tsShowPassword.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.tsShowPassword.Checked = false;
            this.tsShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tsShowPassword.Font = new System.Drawing.Font("Verdana", 9F);
            this.tsShowPassword.Location = new System.Drawing.Point(15, 130);
            this.tsShowPassword.Name = "tsShowPassword";
            this.tsShowPassword.Size = new System.Drawing.Size(43, 20);
            this.tsShowPassword.TabIndex = 4;
            this.tsShowPassword.TabStop = false;
            this.tsShowPassword.TextOnChecked = "";
            this.tsShowPassword.Click += new System.EventHandler(this.tsShowPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnLogin.BackColorAdditional = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogin.BackColorGradientEnabled = false;
            this.btnLogin.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.BorderColorEnabled = false;
            this.btnLogin.BorderColorOnHover = System.Drawing.SystemColors.ControlLight;
            this.btnLogin.BorderColorOnHoverEnabled = false;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(228, 64);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RippleColor = System.Drawing.Color.White;
            this.btnLogin.RoundingEnable = true;
            this.btnLogin.Size = new System.Drawing.Size(30, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "GO";
            this.btnLogin.TextHover = "";
            this.btnLogin.UseDownPressEffectOnClick = false;
            this.btnLogin.UseRippleEffect = true;
            this.btnLogin.UseZoomEffectOnHover = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbPassword.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.tbPassword.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(15, 80);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = true;
            this.tbPassword.Size = new System.Drawing.Size(200, 40);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TextInput = "";
            this.tbPassword.TextPreview = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogin.BackColor = System.Drawing.Color.White;
            this.tbLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbLogin.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tbLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLogin.Font = new System.Drawing.Font("Arial", 12F);
            this.tbLogin.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbLogin.ForeColor = System.Drawing.Color.Black;
            this.tbLogin.Location = new System.Drawing.Point(15, 35);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PasswordChar = false;
            this.tbLogin.Size = new System.Drawing.Size(200, 40);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.TextInput = "";
            this.tbLogin.TextPreview = "Логин";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 160);
            this.Controls.Add(this.iconButtonSetting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsShowPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox_ tbLogin;
        private TextBox_ tbPassword;
        private Button_ btnLogin;
        private ToggleSwitch tsShowPassword;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private FontAwesome.Sharp.IconButton iconButtonSetting;
    }
}

