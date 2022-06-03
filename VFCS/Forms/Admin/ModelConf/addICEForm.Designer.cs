
namespace VFCS
{
    partial class addICEForm
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
            this.textBoxHorsePower = new VFCS.TextBox_();
            this.textBoxName = new VFCS.TextBox_();
            this.textBoxCapacity = new VFCS.TextBox_();
            this.metroComboBoxFuelType = new MetroFramework.Controls.MetroComboBox();
            this.buttonAdd = new VFCS.Button_();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(321, 45);
            // 
            // textBoxHorsePower
            // 
            this.textBoxHorsePower.BackColor = System.Drawing.Color.White;
            this.textBoxHorsePower.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBoxHorsePower.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxHorsePower.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxHorsePower.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHorsePower.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBoxHorsePower.ForeColor = System.Drawing.Color.Black;
            this.textBoxHorsePower.Location = new System.Drawing.Point(32, 95);
            this.textBoxHorsePower.Name = "textBoxHorsePower";
            this.textBoxHorsePower.PasswordChar = false;
            this.textBoxHorsePower.Size = new System.Drawing.Size(120, 35);
            this.textBoxHorsePower.TabIndex = 1;
            this.textBoxHorsePower.TextInput = "";
            this.textBoxHorsePower.TextPreview = "Л.с.";
            this.textBoxHorsePower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHorsePower_KeyPress);
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
            this.textBoxName.Location = new System.Drawing.Point(168, 95);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = false;
            this.textBoxName.Size = new System.Drawing.Size(120, 35);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextInput = "";
            this.textBoxName.TextPreview = "Название";
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.BackColor = System.Drawing.Color.White;
            this.textBoxCapacity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBoxCapacity.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCapacity.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxCapacity.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBoxCapacity.ForeColor = System.Drawing.Color.Black;
            this.textBoxCapacity.Location = new System.Drawing.Point(32, 136);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.PasswordChar = false;
            this.textBoxCapacity.Size = new System.Drawing.Size(120, 35);
            this.textBoxCapacity.TabIndex = 3;
            this.textBoxCapacity.TextInput = "";
            this.textBoxCapacity.TextPreview = "Объём";
            this.textBoxCapacity.TextChanged += new System.EventHandler(this.textBoxCapacity_TextChanged);
            this.textBoxCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCapacity_KeyPress);
            // 
            // metroComboBoxFuelType
            // 
            this.metroComboBoxFuelType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBoxFuelType.FormattingEnabled = true;
            this.metroComboBoxFuelType.ItemHeight = 23;
            this.metroComboBoxFuelType.Location = new System.Drawing.Point(168, 142);
            this.metroComboBoxFuelType.Name = "metroComboBoxFuelType";
            this.metroComboBoxFuelType.Size = new System.Drawing.Size(120, 29);
            this.metroComboBoxFuelType.TabIndex = 4;
            this.metroComboBoxFuelType.UseSelectable = true;
            this.metroComboBoxFuelType.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxFuelType_SelectedIndexChanged);
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
            this.buttonAdd.Location = new System.Drawing.Point(32, 177);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.RippleColor = System.Drawing.Color.Black;
            this.buttonAdd.RoundingEnable = true;
            this.buttonAdd.Size = new System.Drawing.Size(256, 25);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Далее";
            this.buttonAdd.TextHover = null;
            this.buttonAdd.UseDownPressEffectOnClick = false;
            this.buttonAdd.UseRippleEffect = true;
            this.buttonAdd.UseZoomEffectOnHover = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.iconButtonExit.Location = new System.Drawing.Point(294, 74);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(30, 27);
            this.iconButtonExit.TabIndex = 6;
            this.iconButtonExit.Tag = "Выход";
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = false;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // addICEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 217);
            this.Controls.Add(this.iconButtonExit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.metroComboBoxFuelType);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxHorsePower);
            this.Name = "addICEForm";
            this.Text = "addICEForm";
            this.Load += new System.EventHandler(this.addICEForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addICEForm_KeyPress);
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.textBoxHorsePower, 0);
            this.Controls.SetChildIndex(this.textBoxName, 0);
            this.Controls.SetChildIndex(this.textBoxCapacity, 0);
            this.Controls.SetChildIndex(this.metroComboBoxFuelType, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.iconButtonExit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox_ textBoxHorsePower;
        private TextBox_ textBoxName;
        private TextBox_ textBoxCapacity;
        private MetroFramework.Controls.MetroComboBox metroComboBoxFuelType;
        private Button_ buttonAdd;
        private FontAwesome.Sharp.IconButton iconButtonExit;
    }
}