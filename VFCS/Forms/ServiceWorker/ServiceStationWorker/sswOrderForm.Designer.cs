
namespace VFCS
{
    partial class sswOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.metroTextBoxDescriptionOrder = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBoxStatus = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxPrice = new MetroFramework.Controls.MetroTextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelStatusInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonAddOrder = new VFCS.Button_();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(552, 45);
            // 
            // metroTextBoxDescriptionOrder
            // 
            // 
            // 
            // 
            this.metroTextBoxDescriptionOrder.CustomButton.Image = null;
            this.metroTextBoxDescriptionOrder.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.metroTextBoxDescriptionOrder.CustomButton.Name = "";
            this.metroTextBoxDescriptionOrder.CustomButton.Size = new System.Drawing.Size(193, 193);
            this.metroTextBoxDescriptionOrder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxDescriptionOrder.CustomButton.TabIndex = 1;
            this.metroTextBoxDescriptionOrder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxDescriptionOrder.CustomButton.UseSelectable = true;
            this.metroTextBoxDescriptionOrder.CustomButton.Visible = false;
            this.metroTextBoxDescriptionOrder.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxDescriptionOrder.Lines = new string[0];
            this.metroTextBoxDescriptionOrder.Location = new System.Drawing.Point(15, 81);
            this.metroTextBoxDescriptionOrder.MaxLength = 32767;
            this.metroTextBoxDescriptionOrder.Name = "metroTextBoxDescriptionOrder";
            this.metroTextBoxDescriptionOrder.PasswordChar = '\0';
            this.metroTextBoxDescriptionOrder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDescriptionOrder.SelectedText = "";
            this.metroTextBoxDescriptionOrder.SelectionLength = 0;
            this.metroTextBoxDescriptionOrder.SelectionStart = 0;
            this.metroTextBoxDescriptionOrder.ShortcutsEnabled = true;
            this.metroTextBoxDescriptionOrder.Size = new System.Drawing.Size(260, 195);
            this.metroTextBoxDescriptionOrder.TabIndex = 1;
            this.metroTextBoxDescriptionOrder.UseSelectable = true;
            this.metroTextBoxDescriptionOrder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxDescriptionOrder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxDescriptionOrder.Click += new System.EventHandler(this.metroTextBoxDescriptionOrder_Click);
            // 
            // metroComboBoxStatus
            // 
            this.metroComboBoxStatus.FormattingEnabled = true;
            this.metroComboBoxStatus.ItemHeight = 23;
            this.metroComboBoxStatus.Location = new System.Drawing.Point(281, 81);
            this.metroComboBoxStatus.Name = "metroComboBoxStatus";
            this.metroComboBoxStatus.Size = new System.Drawing.Size(260, 29);
            this.metroComboBoxStatus.TabIndex = 2;
            this.metroComboBoxStatus.UseSelectable = true;
            this.metroComboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxStatus_SelectedIndexChanged);
            // 
            // metroTextBoxPrice
            // 
            // 
            // 
            // 
            this.metroTextBoxPrice.CustomButton.Image = null;
            this.metroTextBoxPrice.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.metroTextBoxPrice.CustomButton.Name = "";
            this.metroTextBoxPrice.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBoxPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPrice.CustomButton.TabIndex = 1;
            this.metroTextBoxPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPrice.CustomButton.UseSelectable = true;
            this.metroTextBoxPrice.CustomButton.Visible = false;
            this.metroTextBoxPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxPrice.Lines = new string[0];
            this.metroTextBoxPrice.Location = new System.Drawing.Point(281, 189);
            this.metroTextBoxPrice.MaxLength = 32767;
            this.metroTextBoxPrice.Name = "metroTextBoxPrice";
            this.metroTextBoxPrice.PasswordChar = '\0';
            this.metroTextBoxPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPrice.SelectedText = "";
            this.metroTextBoxPrice.SelectionLength = 0;
            this.metroTextBoxPrice.SelectionStart = 0;
            this.metroTextBoxPrice.ShortcutsEnabled = true;
            this.metroTextBoxPrice.Size = new System.Drawing.Size(260, 29);
            this.metroTextBoxPrice.TabIndex = 3;
            this.metroTextBoxPrice.UseSelectable = true;
            this.metroTextBoxPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPrice.WaterMarkFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroTextBoxPrice.TextChanged += new System.EventHandler(this.metroTextBoxPrice_TextChanged);
            this.metroTextBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxPrice_KeyPress);
            this.metroTextBoxPrice.MouseEnter += new System.EventHandler(this.metroTextBoxPrice_MouseEnter);
            this.metroTextBoxPrice.MouseLeave += new System.EventHandler(this.metroTextBoxPrice_MouseLeave);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(281, 221);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(50, 18);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "label1";
            // 
            // labelStatusInfo
            // 
            this.labelStatusInfo.AutoSize = true;
            this.labelStatusInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatusInfo.Location = new System.Drawing.Point(281, 113);
            this.labelStatusInfo.Name = "labelStatusInfo";
            this.labelStatusInfo.Size = new System.Drawing.Size(50, 18);
            this.labelStatusInfo.TabIndex = 5;
            this.labelStatusInfo.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAddOrder.BackColorAdditional = System.Drawing.Color.Gray;
            this.buttonAddOrder.BackColorGradientEnabled = false;
            this.buttonAddOrder.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonAddOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAddOrder.BorderColorEnabled = false;
            this.buttonAddOrder.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonAddOrder.BorderColorOnHoverEnabled = false;
            this.buttonAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddOrder.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonAddOrder.ForeColor = System.Drawing.Color.White;
            this.buttonAddOrder.Location = new System.Drawing.Point(281, 247);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.RippleColor = System.Drawing.Color.Black;
            this.buttonAddOrder.RoundingEnable = true;
            this.buttonAddOrder.Size = new System.Drawing.Size(113, 29);
            this.buttonAddOrder.TabIndex = 4;
            this.buttonAddOrder.Text = "Заказать";
            this.buttonAddOrder.TextHover = null;
            this.buttonAddOrder.UseDownPressEffectOnClick = false;
            this.buttonAddOrder.UseRippleEffect = true;
            this.buttonAddOrder.UseZoomEffectOnHover = false;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
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
            this.iconButtonExit.Location = new System.Drawing.Point(443, 247);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(100, 30);
            this.iconButtonExit.TabIndex = 5;
            this.iconButtonExit.Tag = "Выход";
            this.iconButtonExit.Text = "Выход";
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = false;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // sswOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 294);
            this.Controls.Add(this.iconButtonExit);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.labelStatusInfo);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.metroTextBoxPrice);
            this.Controls.Add(this.metroComboBoxStatus);
            this.Controls.Add(this.metroTextBoxDescriptionOrder);
            this.Name = "sswOrderForm";
            this.Text = "sswOrderForm";
            this.Load += new System.EventHandler(this.sswOrderForm_Load);
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.metroTextBoxDescriptionOrder, 0);
            this.Controls.SetChildIndex(this.metroComboBoxStatus, 0);
            this.Controls.SetChildIndex(this.metroTextBoxPrice, 0);
            this.Controls.SetChildIndex(this.labelPrice, 0);
            this.Controls.SetChildIndex(this.labelStatusInfo, 0);
            this.Controls.SetChildIndex(this.buttonAddOrder, 0);
            this.Controls.SetChildIndex(this.iconButtonExit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxDescriptionOrder;
        private MetroFramework.Controls.MetroComboBox metroComboBoxStatus;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelStatusInfo;
        private System.Windows.Forms.Timer timer1;
        private Button_ buttonAddOrder;
        private FontAwesome.Sharp.IconButton iconButtonExit;
    }
}