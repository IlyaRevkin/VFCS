
namespace VFCS
{
    partial class sswServiceForm
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
            this.panelService = new VFCS.Classes.Style.Controls.Panel_();
            this.buttonAddService = new VFCS.Button_();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(329, 45);
            // 
            // panelService
            // 
            this.panelService.Location = new System.Drawing.Point(15, 81);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(299, 211);
            this.panelService.TabIndex = 1;
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
            this.buttonAddService.Location = new System.Drawing.Point(15, 298);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.RippleColor = System.Drawing.Color.Black;
            this.buttonAddService.RoundingEnable = true;
            this.buttonAddService.Size = new System.Drawing.Size(299, 25);
            this.buttonAddService.TabIndex = 2;
            this.buttonAddService.Text = "Добавить";
            this.buttonAddService.TextHover = null;
            this.buttonAddService.UseDownPressEffectOnClick = false;
            this.buttonAddService.UseRippleEffect = true;
            this.buttonAddService.UseZoomEffectOnHover = false;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
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
            this.iconButtonExit.Location = new System.Drawing.Point(214, 329);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(100, 30);
            this.iconButtonExit.TabIndex = 21;
            this.iconButtonExit.Tag = "Выход";
            this.iconButtonExit.Text = "Выход";
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = false;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // sswServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 368);
            this.Controls.Add(this.iconButtonExit);
            this.Controls.Add(this.buttonAddService);
            this.Controls.Add(this.panelService);
            this.Name = "sswServiceForm";
            this.Text = "sswServiceForm";
            this.Load += new System.EventHandler(this.sswServiceForm_Load);
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.panelService, 0);
            this.Controls.SetChildIndex(this.buttonAddService, 0);
            this.Controls.SetChildIndex(this.iconButtonExit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Classes.Style.Controls.Panel_ panelService;
        private Button_ buttonAddService;
        private FontAwesome.Sharp.IconButton iconButtonExit;
    }
}