
namespace VFCS
{
    partial class ewCurrentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNameClient = new System.Windows.Forms.Label();
            this.labelModelConf = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.buttonComplite = new VFCS.Button_();
            this.metroTextBoxWorkDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBoxEmployee = new MetroFramework.Controls.MetroComboBox();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(600, 45);
            // 
            // labelNameClient
            // 
            this.labelNameClient.AutoSize = true;
            this.labelNameClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameClient.Location = new System.Drawing.Point(3, 3);
            this.labelNameClient.Name = "labelNameClient";
            this.labelNameClient.Size = new System.Drawing.Size(100, 18);
            this.labelNameClient.TabIndex = 1;
            this.labelNameClient.Text = "Имя клиента";
            // 
            // labelModelConf
            // 
            this.labelModelConf.AutoSize = true;
            this.labelModelConf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModelConf.Location = new System.Drawing.Point(3, 32);
            this.labelModelConf.Name = "labelModelConf";
            this.labelModelConf.Size = new System.Drawing.Size(253, 18);
            this.labelModelConf.TabIndex = 2;
            this.labelModelConf.Text = "Данные о моделе и конфигурации";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelService.Location = new System.Drawing.Point(3, 57);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(76, 18);
            this.labelService.TabIndex = 3;
            this.labelService.Text = "Сервесы";
            // 
            // buttonComplite
            // 
            this.buttonComplite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonComplite.BackColorAdditional = System.Drawing.Color.Gray;
            this.buttonComplite.BackColorGradientEnabled = false;
            this.buttonComplite.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonComplite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonComplite.BorderColorEnabled = false;
            this.buttonComplite.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonComplite.BorderColorOnHoverEnabled = false;
            this.buttonComplite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComplite.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonComplite.ForeColor = System.Drawing.Color.White;
            this.buttonComplite.Location = new System.Drawing.Point(15, 335);
            this.buttonComplite.Name = "buttonComplite";
            this.buttonComplite.RippleColor = System.Drawing.Color.Black;
            this.buttonComplite.RoundingEnable = true;
            this.buttonComplite.Size = new System.Drawing.Size(150, 30);
            this.buttonComplite.TabIndex = 4;
            this.buttonComplite.Text = "Далее";
            this.buttonComplite.TextHover = null;
            this.buttonComplite.UseDownPressEffectOnClick = false;
            this.buttonComplite.UseRippleEffect = true;
            this.buttonComplite.UseZoomEffectOnHover = false;
            this.buttonComplite.Click += new System.EventHandler(this.buttonComplite_Click);
            // 
            // metroTextBoxWorkDescription
            // 
            // 
            // 
            // 
            this.metroTextBoxWorkDescription.CustomButton.Image = null;
            this.metroTextBoxWorkDescription.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.metroTextBoxWorkDescription.CustomButton.Name = "";
            this.metroTextBoxWorkDescription.CustomButton.Size = new System.Drawing.Size(125, 125);
            this.metroTextBoxWorkDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxWorkDescription.CustomButton.TabIndex = 1;
            this.metroTextBoxWorkDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxWorkDescription.CustomButton.UseSelectable = true;
            this.metroTextBoxWorkDescription.CustomButton.Visible = false;
            this.metroTextBoxWorkDescription.Lines = new string[0];
            this.metroTextBoxWorkDescription.Location = new System.Drawing.Point(15, 202);
            this.metroTextBoxWorkDescription.MaxLength = 32767;
            this.metroTextBoxWorkDescription.Name = "metroTextBoxWorkDescription";
            this.metroTextBoxWorkDescription.PasswordChar = '\0';
            this.metroTextBoxWorkDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxWorkDescription.SelectedText = "";
            this.metroTextBoxWorkDescription.SelectionLength = 0;
            this.metroTextBoxWorkDescription.SelectionStart = 0;
            this.metroTextBoxWorkDescription.ShortcutsEnabled = true;
            this.metroTextBoxWorkDescription.Size = new System.Drawing.Size(570, 127);
            this.metroTextBoxWorkDescription.TabIndex = 5;
            this.metroTextBoxWorkDescription.UseSelectable = true;
            this.metroTextBoxWorkDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxWorkDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroComboBoxEmployee
            // 
            this.metroComboBoxEmployee.FormattingEnabled = true;
            this.metroComboBoxEmployee.ItemHeight = 23;
            this.metroComboBoxEmployee.Location = new System.Drawing.Point(15, 167);
            this.metroComboBoxEmployee.Name = "metroComboBoxEmployee";
            this.metroComboBoxEmployee.Size = new System.Drawing.Size(150, 29);
            this.metroComboBoxEmployee.TabIndex = 6;
            this.metroComboBoxEmployee.UseSelectable = true;
            this.metroComboBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxEmployee_SelectedIndexChanged);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonExit.IconColor = System.Drawing.Color.Black;
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.IconSize = 25;
            this.iconButtonExit.Location = new System.Drawing.Point(485, 335);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(100, 30);
            this.iconButtonExit.TabIndex = 20;
            this.iconButtonExit.Tag = "Выход";
            this.iconButtonExit.Text = "Выход";
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = false;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.labelService);
            this.panel2.Controls.Add(this.labelNameClient);
            this.panel2.Controls.Add(this.labelModelConf);
            this.panel2.Location = new System.Drawing.Point(15, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 80);
            this.panel2.TabIndex = 21;
            // 
            // ewCurrentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.iconButtonExit);
            this.Controls.Add(this.metroComboBoxEmployee);
            this.Controls.Add(this.metroTextBoxWorkDescription);
            this.Controls.Add(this.buttonComplite);
            this.Name = "ewCurrentForm";
            this.Text = "ewCurrentForm";
            this.Load += new System.EventHandler(this.ewCurrentForm_Load);
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.buttonComplite, 0);
            this.Controls.SetChildIndex(this.metroTextBoxWorkDescription, 0);
            this.Controls.SetChildIndex(this.metroComboBoxEmployee, 0);
            this.Controls.SetChildIndex(this.iconButtonExit, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameClient;
        private System.Windows.Forms.Label labelModelConf;
        private System.Windows.Forms.Label labelService;
        private Button_ buttonComplite;
        private MetroFramework.Controls.MetroTextBox metroTextBoxWorkDescription;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEmployee;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private System.Windows.Forms.Panel panel2;
    }
}