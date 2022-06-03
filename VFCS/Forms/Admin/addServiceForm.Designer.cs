
namespace VFCS
{
    partial class addServiceForm
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
            this.textBoxName = new VFCS.TextBox_();
            this.buttonAddService = new VFCS.Button_();
            this.textBoxPrice = new VFCS.TextBox_();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(285, 45);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBoxName.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxName.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.Location = new System.Drawing.Point(51, 81);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = false;
            this.textBoxName.Size = new System.Drawing.Size(180, 38);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextInput = "";
            this.textBoxName.TextPreview = "Название сервиса";
            // 
            // buttonAddService
            // 
            this.buttonAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAddService.BackColorAdditional = System.Drawing.Color.Gray;
            this.buttonAddService.BackColorGradientEnabled = false;
            this.buttonAddService.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonAddService.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAddService.BorderColorEnabled = false;
            this.buttonAddService.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonAddService.BorderColorOnHoverEnabled = false;
            this.buttonAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddService.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonAddService.ForeColor = System.Drawing.Color.White;
            this.buttonAddService.Location = new System.Drawing.Point(51, 165);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.RippleColor = System.Drawing.Color.Black;
            this.buttonAddService.RoundingEnable = true;
            this.buttonAddService.Size = new System.Drawing.Size(180, 25);
            this.buttonAddService.TabIndex = 3;
            this.buttonAddService.Text = "Добавить";
            this.buttonAddService.TextHover = null;
            this.buttonAddService.UseDownPressEffectOnClick = false;
            this.buttonAddService.UseRippleEffect = true;
            this.buttonAddService.UseZoomEffectOnHover = false;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.White;
            this.textBoxPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBoxPrice.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPrice.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxPrice.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBoxPrice.ForeColor = System.Drawing.Color.Black;
            this.textBoxPrice.Location = new System.Drawing.Point(51, 125);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.PasswordChar = false;
            this.textBoxPrice.Size = new System.Drawing.Size(180, 34);
            this.textBoxPrice.TabIndex = 2;
            this.textBoxPrice.TextInput = "";
            this.textBoxPrice.TextPreview = "Цена";
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonExit.IconColor = System.Drawing.Color.Black;
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.IconSize = 25;
            this.iconButtonExit.Location = new System.Drawing.Point(255, 75);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(30, 30);
            this.iconButtonExit.TabIndex = 4;
            this.iconButtonExit.Tag = "Выход";
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = false;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // addServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 200);
            this.Controls.Add(this.iconButtonExit);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonAddService);
            this.Controls.Add(this.textBoxName);
            this.Name = "addServiceForm";
            this.Text = "addServiceForm";
            this.Load += new System.EventHandler(this.addServiceForm_Load);
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.textBoxName, 0);
            this.Controls.SetChildIndex(this.buttonAddService, 0);
            this.Controls.SetChildIndex(this.textBoxPrice, 0);
            this.Controls.SetChildIndex(this.iconButtonExit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox_ textBoxName;
        private Button_ buttonAddService;
        private TextBox_ textBoxPrice;
        private FontAwesome.Sharp.IconButton iconButtonExit;
    }
}