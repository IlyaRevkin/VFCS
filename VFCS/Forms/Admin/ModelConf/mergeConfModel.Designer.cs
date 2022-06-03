
namespace VFCS
{
    partial class mergeConfModel
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
            this.buttonAdd = new VFCS.Button_();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelBottomButton = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottomButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAdd.BackColorAdditional = System.Drawing.Color.Gray;
            this.buttonAdd.BackColorGradientEnabled = false;
            this.buttonAdd.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAdd.BorderColorEnabled = false;
            this.buttonAdd.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonAdd.BorderColorOnHoverEnabled = false;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(183, 10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.RippleColor = System.Drawing.Color.Black;
            this.buttonAdd.RoundingEnable = true;
            this.buttonAdd.Size = new System.Drawing.Size(180, 35);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Связать";
            this.buttonAdd.TextHover = null;
            this.buttonAdd.UseDownPressEffectOnClick = false;
            this.buttonAdd.UseRippleEffect = true;
            this.buttonAdd.UseZoomEffectOnHover = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 75);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(130, 375);
            this.panelLeft.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(670, 75);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(130, 375);
            this.panelRight.TabIndex = 4;
            // 
            // panelBottomButton
            // 
            this.panelBottomButton.Controls.Add(this.buttonAdd);
            this.panelBottomButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomButton.Location = new System.Drawing.Point(130, 395);
            this.panelBottomButton.Name = "panelBottomButton";
            this.panelBottomButton.Size = new System.Drawing.Size(540, 55);
            this.panelBottomButton.TabIndex = 5;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(130, 75);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(540, 320);
            this.panelMain.TabIndex = 6;
            // 
            // mergeConfModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottomButton);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "mergeConfModel";
            this.Text = "mergeConfModel";
            this.Load += new System.EventHandler(this.mergeConfModel_Load);
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.panelLeft, 0);
            this.Controls.SetChildIndex(this.panelRight, 0);
            this.Controls.SetChildIndex(this.panelBottomButton, 0);
            this.Controls.SetChildIndex(this.panelMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelBottomButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button_ buttonAdd;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelBottomButton;
        private System.Windows.Forms.Panel panelMain;
    }
}