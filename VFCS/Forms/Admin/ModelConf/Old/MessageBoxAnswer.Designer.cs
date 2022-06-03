
namespace VFCS
{
    partial class MessageBoxAnswer
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.buttonAddNew = new VFCS.Button_();
            this.buttonAddExist = new VFCS.Button_();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(55, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(265, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Выберете что вы хотите сделать";
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAddNew.BackColorAdditional = System.Drawing.Color.Gray;
            this.buttonAddNew.BackColorGradientEnabled = false;
            this.buttonAddNew.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonAddNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAddNew.BorderColorEnabled = false;
            this.buttonAddNew.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonAddNew.BorderColorOnHoverEnabled = false;
            this.buttonAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddNew.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonAddNew.ForeColor = System.Drawing.Color.White;
            this.buttonAddNew.Location = new System.Drawing.Point(200, 63);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.RippleColor = System.Drawing.Color.Black;
            this.buttonAddNew.RoundingEnable = true;
            this.buttonAddNew.Size = new System.Drawing.Size(150, 55);
            this.buttonAddNew.TabIndex = 1;
            this.buttonAddNew.Text = "Добавить новую конфигурацию";
            this.buttonAddNew.TextHover = null;
            this.buttonAddNew.UseDownPressEffectOnClick = false;
            this.buttonAddNew.UseRippleEffect = true;
            this.buttonAddNew.UseZoomEffectOnHover = false;
            // 
            // buttonAddExist
            // 
            this.buttonAddExist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAddExist.BackColorAdditional = System.Drawing.Color.Gray;
            this.buttonAddExist.BackColorGradientEnabled = false;
            this.buttonAddExist.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonAddExist.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAddExist.BorderColorEnabled = false;
            this.buttonAddExist.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonAddExist.BorderColorOnHoverEnabled = false;
            this.buttonAddExist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddExist.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonAddExist.ForeColor = System.Drawing.Color.White;
            this.buttonAddExist.Location = new System.Drawing.Point(25, 63);
            this.buttonAddExist.Name = "buttonAddExist";
            this.buttonAddExist.RippleColor = System.Drawing.Color.Black;
            this.buttonAddExist.RoundingEnable = true;
            this.buttonAddExist.Size = new System.Drawing.Size(150, 55);
            this.buttonAddExist.TabIndex = 0;
            this.buttonAddExist.Text = "Добавить к существующей конфигурации";
            this.buttonAddExist.TextHover = null;
            this.buttonAddExist.UseDownPressEffectOnClick = false;
            this.buttonAddExist.UseRippleEffect = true;
            this.buttonAddExist.UseZoomEffectOnHover = false;
            // 
            // MessageBoxAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 130);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.buttonAddExist);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxAnswer";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button_ buttonAddExist;
        private Button_ buttonAddNew;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}