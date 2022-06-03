
namespace VFCS
{
    partial class modelConfForm
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
            this.buttonAddModel = new VFCS.Button_();
            this.buttonAddICE = new VFCS.Button_();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(285, 45);
            // 
            // buttonAddModel
            // 
            this.buttonAddModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAddModel.BackColorAdditional = System.Drawing.Color.Gray;
            this.buttonAddModel.BackColorGradientEnabled = false;
            this.buttonAddModel.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonAddModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAddModel.BorderColorEnabled = false;
            this.buttonAddModel.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonAddModel.BorderColorOnHoverEnabled = false;
            this.buttonAddModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddModel.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonAddModel.ForeColor = System.Drawing.Color.White;
            this.buttonAddModel.Location = new System.Drawing.Point(32, 100);
            this.buttonAddModel.Name = "buttonAddModel";
            this.buttonAddModel.RippleColor = System.Drawing.Color.Black;
            this.buttonAddModel.RoundingEnable = true;
            this.buttonAddModel.Size = new System.Drawing.Size(220, 27);
            this.buttonAddModel.TabIndex = 1;
            this.buttonAddModel.Text = "Добавить модель";
            this.buttonAddModel.TextHover = null;
            this.buttonAddModel.UseDownPressEffectOnClick = false;
            this.buttonAddModel.UseRippleEffect = true;
            this.buttonAddModel.UseZoomEffectOnHover = false;
            this.buttonAddModel.Click += new System.EventHandler(this.buttonAddModel_Click);
            // 
            // buttonAddICE
            // 
            this.buttonAddICE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddICE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAddICE.BackColorAdditional = System.Drawing.Color.Gray;
            this.buttonAddICE.BackColorGradientEnabled = false;
            this.buttonAddICE.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonAddICE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAddICE.BorderColorEnabled = false;
            this.buttonAddICE.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonAddICE.BorderColorOnHoverEnabled = false;
            this.buttonAddICE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddICE.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonAddICE.ForeColor = System.Drawing.Color.White;
            this.buttonAddICE.Location = new System.Drawing.Point(32, 133);
            this.buttonAddICE.Name = "buttonAddICE";
            this.buttonAddICE.RippleColor = System.Drawing.Color.Black;
            this.buttonAddICE.RoundingEnable = true;
            this.buttonAddICE.Size = new System.Drawing.Size(220, 27);
            this.buttonAddICE.TabIndex = 6;
            this.buttonAddICE.Text = "Добавить конфигурацию";
            this.buttonAddICE.TextHover = null;
            this.buttonAddICE.UseDownPressEffectOnClick = false;
            this.buttonAddICE.UseRippleEffect = true;
            this.buttonAddICE.UseZoomEffectOnHover = false;
            this.buttonAddICE.Click += new System.EventHandler(this.buttonAddICE_Click);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonExit.IconColor = System.Drawing.Color.Black;
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.IconSize = 27;
            this.iconButtonExit.Location = new System.Drawing.Point(258, 75);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(27, 27);
            this.iconButtonExit.TabIndex = 11;
            this.iconButtonExit.Tag = "";
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = false;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // modelConfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 186);
            this.Controls.Add(this.iconButtonExit);
            this.Controls.Add(this.buttonAddICE);
            this.Controls.Add(this.buttonAddModel);
            this.Name = "modelConfForm";
            this.Text = "modelConfForm";
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.buttonAddModel, 0);
            this.Controls.SetChildIndex(this.buttonAddICE, 0);
            this.Controls.SetChildIndex(this.iconButtonExit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button_ buttonAddModel;
        private Button_ buttonAddICE;
        private FontAwesome.Sharp.IconButton iconButtonExit;
    }
}