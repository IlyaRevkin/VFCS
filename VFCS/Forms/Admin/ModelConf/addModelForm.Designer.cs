
namespace VFCS
{
    partial class addModelForm
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
            this.textBoxModelName = new VFCS.TextBox_();
            this.buttonNext = new VFCS.Button_();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(285, 45);
            // 
            // textBoxModelName
            // 
            this.textBoxModelName.BackColor = System.Drawing.Color.White;
            this.textBoxModelName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBoxModelName.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxModelName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxModelName.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxModelName.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBoxModelName.ForeColor = System.Drawing.Color.Black;
            this.textBoxModelName.Location = new System.Drawing.Point(45, 97);
            this.textBoxModelName.Name = "textBoxModelName";
            this.textBoxModelName.PasswordChar = false;
            this.textBoxModelName.Size = new System.Drawing.Size(195, 35);
            this.textBoxModelName.TabIndex = 1;
            this.textBoxModelName.TextInput = "";
            this.textBoxModelName.TextPreview = "Название модели";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonNext.BackColorAdditional = System.Drawing.Color.Gray;
            this.buttonNext.BackColorGradientEnabled = false;
            this.buttonNext.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonNext.BorderColorEnabled = false;
            this.buttonNext.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonNext.BorderColorOnHoverEnabled = false;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(45, 147);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.RippleColor = System.Drawing.Color.Black;
            this.buttonNext.RoundingEnable = true;
            this.buttonNext.Size = new System.Drawing.Size(195, 25);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Далее";
            this.buttonNext.TextHover = null;
            this.buttonNext.UseDownPressEffectOnClick = false;
            this.buttonNext.UseRippleEffect = true;
            this.buttonNext.UseZoomEffectOnHover = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
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
            this.iconButtonExit.Location = new System.Drawing.Point(255, 75);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(30, 30);
            this.iconButtonExit.TabIndex = 7;
            this.iconButtonExit.Tag = "Выход";
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = false;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // addModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 186);
            this.Controls.Add(this.iconButtonExit);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxModelName);
            this.Name = "addModelForm";
            this.Text = "addModelForm";
            this.Load += new System.EventHandler(this.addModelForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addModelForm_KeyPress);
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.textBoxModelName, 0);
            this.Controls.SetChildIndex(this.buttonNext, 0);
            this.Controls.SetChildIndex(this.iconButtonExit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox_ textBoxModelName;
        private Button_ buttonNext;
        private FontAwesome.Sharp.IconButton iconButtonExit;
    }
}