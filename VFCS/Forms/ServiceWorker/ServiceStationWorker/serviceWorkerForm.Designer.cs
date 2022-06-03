
namespace VFCS
{
    partial class serviceWorkerForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelModelConf = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.buttonAddService = new VFCS.Button_();
            this.buttonOrder = new VFCS.Button_();
            this.buttonCompleteReg = new VFCS.Button_();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(500, 45);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(3, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 18);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            // 
            // labelModelConf
            // 
            this.labelModelConf.AutoSize = true;
            this.labelModelConf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModelConf.Location = new System.Drawing.Point(3, 49);
            this.labelModelConf.Name = "labelModelConf";
            this.labelModelConf.Size = new System.Drawing.Size(50, 18);
            this.labelModelConf.TabIndex = 2;
            this.labelModelConf.Text = "label1";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelService.Location = new System.Drawing.Point(3, 86);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(50, 18);
            this.labelService.TabIndex = 3;
            this.labelService.Text = "label1";
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
            this.buttonAddService.Location = new System.Drawing.Point(6, 6);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.RippleColor = System.Drawing.Color.Black;
            this.buttonAddService.RoundingEnable = true;
            this.buttonAddService.Size = new System.Drawing.Size(150, 25);
            this.buttonAddService.TabIndex = 1;
            this.buttonAddService.Text = "Добавить сервисы";
            this.buttonAddService.TextHover = null;
            this.buttonAddService.UseDownPressEffectOnClick = false;
            this.buttonAddService.UseRippleEffect = true;
            this.buttonAddService.UseZoomEffectOnHover = false;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonOrder.BackColorAdditional = System.Drawing.Color.Gray;
            this.buttonOrder.BackColorGradientEnabled = false;
            this.buttonOrder.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonOrder.BorderColorEnabled = false;
            this.buttonOrder.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonOrder.BorderColorOnHoverEnabled = false;
            this.buttonOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrder.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonOrder.ForeColor = System.Drawing.Color.White;
            this.buttonOrder.Location = new System.Drawing.Point(176, 6);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.RippleColor = System.Drawing.Color.Black;
            this.buttonOrder.RoundingEnable = true;
            this.buttonOrder.Size = new System.Drawing.Size(150, 25);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Заказать детали";
            this.buttonOrder.TextHover = null;
            this.buttonOrder.UseDownPressEffectOnClick = false;
            this.buttonOrder.UseRippleEffect = true;
            this.buttonOrder.UseZoomEffectOnHover = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonCompleteReg
            // 
            this.buttonCompleteReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonCompleteReg.BackColorAdditional = System.Drawing.Color.Gray;
            this.buttonCompleteReg.BackColorGradientEnabled = false;
            this.buttonCompleteReg.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonCompleteReg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonCompleteReg.BorderColorEnabled = false;
            this.buttonCompleteReg.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonCompleteReg.BorderColorOnHoverEnabled = false;
            this.buttonCompleteReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCompleteReg.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonCompleteReg.ForeColor = System.Drawing.Color.White;
            this.buttonCompleteReg.Location = new System.Drawing.Point(347, 6);
            this.buttonCompleteReg.Name = "buttonCompleteReg";
            this.buttonCompleteReg.RippleColor = System.Drawing.Color.Black;
            this.buttonCompleteReg.RoundingEnable = true;
            this.buttonCompleteReg.Size = new System.Drawing.Size(150, 25);
            this.buttonCompleteReg.TabIndex = 3;
            this.buttonCompleteReg.Text = "Завершить заказ";
            this.buttonCompleteReg.TextHover = null;
            this.buttonCompleteReg.UseDownPressEffectOnClick = false;
            this.buttonCompleteReg.UseRippleEffect = true;
            this.buttonCompleteReg.UseZoomEffectOnHover = false;
            this.buttonCompleteReg.Click += new System.EventHandler(this.buttonCompleteReg_Click);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonExit.IconColor = System.Drawing.Color.Black;
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.IconSize = 25;
            this.iconButtonExit.Location = new System.Drawing.Point(470, -1);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(30, 30);
            this.iconButtonExit.TabIndex = 4;
            this.iconButtonExit.Tag = "Выход";
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.labelModelConf);
            this.panel2.Controls.Add(this.iconButtonExit);
            this.panel2.Controls.Add(this.labelService);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 122);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonAddService);
            this.panel3.Controls.Add(this.buttonOrder);
            this.panel3.Controls.Add(this.buttonCompleteReg);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 197);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 38);
            this.panel3.TabIndex = 6;
            // 
            // serviceWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 235);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "serviceWorkerForm";
            this.Text = "serviceWorkerForm";
            this.Load += new System.EventHandler(this.serviceWorkerForm_Load);
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelModelConf;
        private System.Windows.Forms.Label labelService;
        private Button_ buttonAddService;
        private Button_ buttonOrder;
        private Button_ buttonCompleteReg;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}