
namespace VFCS.Forms.Template
{
    partial class Template
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Template));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.panelTop.SuspendLayout();
            this.panelDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelDateTime);
            this.panelTop.Controls.Add(this.pictureBoxLogo);
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 30);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 45);
            this.panelTop.TabIndex = 0;
            // 
            // panelDateTime
            // 
            this.panelDateTime.Controls.Add(this.labelDate);
            this.panelDateTime.Controls.Add(this.labelTime);
            this.panelDateTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDateTime.Location = new System.Drawing.Point(687, 0);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(113, 45);
            this.panelDateTime.TabIndex = 2;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDate.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(0, 25);
            this.labelDate.Margin = new System.Windows.Forms.Padding(0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(90, 16);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "01 January 1990 y.";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTime.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(0, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(82, 25);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "00:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.ErrorImage")));
            this.pictureBoxLogo.Image = global::VFCS.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(15, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(61, 45);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 45);
            this.panel1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTop);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Template";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Admin Menu";
            this.panelTop.ResumeLayout(false);
            this.panelDateTime.ResumeLayout(false);
            this.panelDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        public System.Windows.Forms.PictureBox pictureBoxLogo;
        public System.Windows.Forms.Panel panelTop;
    }
}