
namespace VFCS
{
    partial class addConfForm
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
            this.metroComboBoxTypeWD = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxTransmission = new MetroFramework.Controls.MetroComboBox();
            this.buttonNext = new VFCS.Button_();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(405, 45);
            // 
            // metroComboBoxTypeWD
            // 
            this.metroComboBoxTypeWD.FormattingEnabled = true;
            this.metroComboBoxTypeWD.ItemHeight = 23;
            this.metroComboBoxTypeWD.Location = new System.Drawing.Point(15, 95);
            this.metroComboBoxTypeWD.Name = "metroComboBoxTypeWD";
            this.metroComboBoxTypeWD.Size = new System.Drawing.Size(180, 29);
            this.metroComboBoxTypeWD.TabIndex = 1;
            this.metroComboBoxTypeWD.UseSelectable = true;
            this.metroComboBoxTypeWD.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxTypeWD_SelectedIndexChanged);
            // 
            // metroComboBoxTransmission
            // 
            this.metroComboBoxTransmission.FormattingEnabled = true;
            this.metroComboBoxTransmission.ItemHeight = 23;
            this.metroComboBoxTransmission.Location = new System.Drawing.Point(210, 95);
            this.metroComboBoxTransmission.Name = "metroComboBoxTransmission";
            this.metroComboBoxTransmission.Size = new System.Drawing.Size(180, 29);
            this.metroComboBoxTransmission.TabIndex = 2;
            this.metroComboBoxTransmission.UseSelectable = true;
            this.metroComboBoxTransmission.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxTransmission_SelectedIndexChanged);
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
            this.buttonNext.Location = new System.Drawing.Point(15, 140);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.RippleColor = System.Drawing.Color.Black;
            this.buttonNext.RoundingEnable = true;
            this.buttonNext.Size = new System.Drawing.Size(375, 25);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Далее";
            this.buttonNext.TextHover = null;
            this.buttonNext.UseDownPressEffectOnClick = false;
            this.buttonNext.UseRippleEffect = true;
            this.buttonNext.UseZoomEffectOnHover = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            this.buttonNext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonNext_KeyPress);
            // 
            // addConfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 186);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.metroComboBoxTransmission);
            this.Controls.Add(this.metroComboBoxTypeWD);
            this.Name = "addConfForm";
            this.Text = "addConfForm";
            this.Load += new System.EventHandler(this.addConfForm_Load);
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.metroComboBoxTypeWD, 0);
            this.Controls.SetChildIndex(this.metroComboBoxTransmission, 0);
            this.Controls.SetChildIndex(this.buttonNext, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBoxTypeWD;
        private MetroFramework.Controls.MetroComboBox metroComboBoxTransmission;
        private Button_ buttonNext;
    }
}