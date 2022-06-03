
namespace VFCS
{
    partial class addModelConf
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
            this.metroRadioButtonAddExist = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonCreateNew = new MetroFramework.Controls.MetroRadioButton();
            this.buttonAddConf = new VFCS.Button_();
            this.buttonAddModel = new VFCS.Button_();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.textBoxTransmission = new VFCS.TextBox_();
            this.textBoxWD = new VFCS.TextBox_();
            this.textBoxName = new VFCS.TextBox_();
            this.textBoxModel = new VFCS.TextBox_();
            this.textBoxCapacity = new VFCS.TextBox_();
            this.textBoxHorsePower = new VFCS.TextBox_();
            this.textBoxType = new VFCS.TextBox_();
            this.metroComboBoxModel = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxConf = new MetroFramework.Controls.MetroComboBox();
            this.buttonAdd = new VFCS.Button_();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroRadioButtonAddExist
            // 
            this.metroRadioButtonAddExist.AutoSize = true;
            this.metroRadioButtonAddExist.Location = new System.Drawing.Point(408, 273);
            this.metroRadioButtonAddExist.Name = "metroRadioButtonAddExist";
            this.metroRadioButtonAddExist.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButtonAddExist.TabIndex = 1;
            this.metroRadioButtonAddExist.Text = "metroRadioButton1";
            this.metroRadioButtonAddExist.UseSelectable = true;
            this.metroRadioButtonAddExist.CheckedChanged += new System.EventHandler(this.metroRadioButtonAddExist_CheckedChanged);
            // 
            // metroRadioButtonCreateNew
            // 
            this.metroRadioButtonCreateNew.AutoSize = true;
            this.metroRadioButtonCreateNew.Location = new System.Drawing.Point(408, 294);
            this.metroRadioButtonCreateNew.Name = "metroRadioButtonCreateNew";
            this.metroRadioButtonCreateNew.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButtonCreateNew.TabIndex = 2;
            this.metroRadioButtonCreateNew.Text = "metroRadioButton2";
            this.metroRadioButtonCreateNew.UseSelectable = true;
            this.metroRadioButtonCreateNew.CheckedChanged += new System.EventHandler(this.metroRadioButtonCreateNew_CheckedChanged);
            // 
            // buttonAddConf
            // 
            this.buttonAddConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAddConf.BackColorAdditional = System.Drawing.Color.Gray;
            this.buttonAddConf.BackColorGradientEnabled = false;
            this.buttonAddConf.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.buttonAddConf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.buttonAddConf.BorderColorEnabled = false;
            this.buttonAddConf.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonAddConf.BorderColorOnHoverEnabled = false;
            this.buttonAddConf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddConf.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonAddConf.ForeColor = System.Drawing.Color.White;
            this.buttonAddConf.Location = new System.Drawing.Point(201, 236);
            this.buttonAddConf.Name = "buttonAddConf";
            this.buttonAddConf.RippleColor = System.Drawing.Color.Black;
            this.buttonAddConf.RoundingEnable = false;
            this.buttonAddConf.Size = new System.Drawing.Size(131, 52);
            this.buttonAddConf.TabIndex = 3;
            this.buttonAddConf.Text = "Добавить кофигурацию";
            this.buttonAddConf.TextHover = null;
            this.buttonAddConf.UseDownPressEffectOnClick = false;
            this.buttonAddConf.UseRippleEffect = true;
            this.buttonAddConf.UseZoomEffectOnHover = false;
            this.buttonAddConf.Click += new System.EventHandler(this.buttonAddConf_Click);
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
            this.buttonAddModel.Location = new System.Drawing.Point(467, 236);
            this.buttonAddModel.Name = "buttonAddModel";
            this.buttonAddModel.RippleColor = System.Drawing.Color.Black;
            this.buttonAddModel.RoundingEnable = false;
            this.buttonAddModel.Size = new System.Drawing.Size(131, 52);
            this.buttonAddModel.TabIndex = 4;
            this.buttonAddModel.Text = "Добавить Модель";
            this.buttonAddModel.TextHover = null;
            this.buttonAddModel.UseDownPressEffectOnClick = false;
            this.buttonAddModel.UseRippleEffect = true;
            this.buttonAddModel.UseZoomEffectOnHover = false;
            this.buttonAddModel.Click += new System.EventHandler(this.buttonAddModel_Click);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonExit.IconColor = System.Drawing.Color.Black;
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.IconSize = 25;
            this.iconButtonExit.Location = new System.Drawing.Point(687, 81);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(104, 30);
            this.iconButtonExit.TabIndex = 7;
            this.iconButtonExit.Tag = "Выход";
            this.iconButtonExit.Text = "iconButton3";
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // textBoxTransmission
            // 
            this.textBoxTransmission.BackColor = System.Drawing.Color.White;
            this.textBoxTransmission.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBoxTransmission.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxTransmission.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTransmission.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxTransmission.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBoxTransmission.ForeColor = System.Drawing.Color.Black;
            this.textBoxTransmission.Location = new System.Drawing.Point(408, 151);
            this.textBoxTransmission.Name = "textBoxTransmission";
            this.textBoxTransmission.PasswordChar = false;
            this.textBoxTransmission.Size = new System.Drawing.Size(190, 35);
            this.textBoxTransmission.TabIndex = 8;
            this.textBoxTransmission.TextInput = "";
            this.textBoxTransmission.TextPreview = "Трансмиссия";
            // 
            // textBoxWD
            // 
            this.textBoxWD.BackColor = System.Drawing.Color.White;
            this.textBoxWD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBoxWD.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxWD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxWD.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxWD.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBoxWD.ForeColor = System.Drawing.Color.Black;
            this.textBoxWD.Location = new System.Drawing.Point(105, 308);
            this.textBoxWD.Name = "textBoxWD";
            this.textBoxWD.PasswordChar = false;
            this.textBoxWD.Size = new System.Drawing.Size(190, 35);
            this.textBoxWD.TabIndex = 9;
            this.textBoxWD.TextInput = "";
            this.textBoxWD.TextPreview = "Привод";
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
            this.textBoxName.Location = new System.Drawing.Point(105, 96);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = false;
            this.textBoxName.Size = new System.Drawing.Size(190, 35);
            this.textBoxName.TabIndex = 10;
            this.textBoxName.TextInput = "";
            this.textBoxName.TextPreview = "Название";
            // 
            // textBoxModel
            // 
            this.textBoxModel.BackColor = System.Drawing.Color.White;
            this.textBoxModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBoxModel.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxModel.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxModel.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBoxModel.ForeColor = System.Drawing.Color.Black;
            this.textBoxModel.Location = new System.Drawing.Point(408, 96);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.PasswordChar = false;
            this.textBoxModel.Size = new System.Drawing.Size(190, 35);
            this.textBoxModel.TabIndex = 11;
            this.textBoxModel.TextInput = "";
            this.textBoxModel.TextPreview = "Модель";
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
            this.textBoxCapacity.Location = new System.Drawing.Point(105, 151);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.PasswordChar = false;
            this.textBoxCapacity.Size = new System.Drawing.Size(190, 35);
            this.textBoxCapacity.TabIndex = 12;
            this.textBoxCapacity.TextInput = "";
            this.textBoxCapacity.TextPreview = "Объём";
            // 
            // textBoxHorsePower
            // 
            this.textBoxHorsePower.BackColor = System.Drawing.Color.White;
            this.textBoxHorsePower.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBoxHorsePower.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxHorsePower.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxHorsePower.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxHorsePower.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBoxHorsePower.ForeColor = System.Drawing.Color.Black;
            this.textBoxHorsePower.Location = new System.Drawing.Point(105, 207);
            this.textBoxHorsePower.Name = "textBoxHorsePower";
            this.textBoxHorsePower.PasswordChar = false;
            this.textBoxHorsePower.Size = new System.Drawing.Size(190, 35);
            this.textBoxHorsePower.TabIndex = 13;
            this.textBoxHorsePower.TextInput = "";
            this.textBoxHorsePower.TextPreview = "Лошадиные силы";
            // 
            // textBoxType
            // 
            this.textBoxType.BackColor = System.Drawing.Color.White;
            this.textBoxType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBoxType.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxType.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxType.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBoxType.ForeColor = System.Drawing.Color.Black;
            this.textBoxType.Location = new System.Drawing.Point(105, 253);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.PasswordChar = false;
            this.textBoxType.Size = new System.Drawing.Size(190, 35);
            this.textBoxType.TabIndex = 14;
            this.textBoxType.TextInput = "";
            this.textBoxType.TextPreview = "Топливо";
            // 
            // metroComboBoxModel
            // 
            this.metroComboBoxModel.FormattingEnabled = true;
            this.metroComboBoxModel.ItemHeight = 23;
            this.metroComboBoxModel.Location = new System.Drawing.Point(408, 102);
            this.metroComboBoxModel.Name = "metroComboBoxModel";
            this.metroComboBoxModel.Size = new System.Drawing.Size(172, 29);
            this.metroComboBoxModel.TabIndex = 15;
            this.metroComboBoxModel.UseSelectable = true;
            // 
            // metroComboBoxConf
            // 
            this.metroComboBoxConf.FormattingEnabled = true;
            this.metroComboBoxConf.ItemHeight = 23;
            this.metroComboBoxConf.Location = new System.Drawing.Point(105, 102);
            this.metroComboBoxConf.Name = "metroComboBoxConf";
            this.metroComboBoxConf.Size = new System.Drawing.Size(172, 29);
            this.metroComboBoxConf.TabIndex = 16;
            this.metroComboBoxConf.UseSelectable = true;
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
            this.buttonAdd.Location = new System.Drawing.Point(314, 357);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.RippleColor = System.Drawing.Color.Black;
            this.buttonAdd.RoundingEnable = false;
            this.buttonAdd.Size = new System.Drawing.Size(131, 52);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.TextHover = null;
            this.buttonAdd.UseDownPressEffectOnClick = false;
            this.buttonAdd.UseRippleEffect = true;
            this.buttonAdd.UseZoomEffectOnHover = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // addModelConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.metroComboBoxConf);
            this.Controls.Add(this.metroComboBoxModel);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxHorsePower);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxWD);
            this.Controls.Add(this.textBoxTransmission);
            this.Controls.Add(this.iconButtonExit);
            this.Controls.Add(this.buttonAddConf);
            this.Controls.Add(this.metroRadioButtonCreateNew);
            this.Controls.Add(this.metroRadioButtonAddExist);
            this.Controls.Add(this.buttonAddModel);
            this.Name = "addModelConf";
            this.Text = "addModelConf";
            this.Load += new System.EventHandler(this.addModelConf_Load);
            this.Controls.SetChildIndex(this.buttonAddModel, 0);
            this.Controls.SetChildIndex(this.panelTop, 0);
            this.Controls.SetChildIndex(this.metroRadioButtonAddExist, 0);
            this.Controls.SetChildIndex(this.metroRadioButtonCreateNew, 0);
            this.Controls.SetChildIndex(this.buttonAddConf, 0);
            this.Controls.SetChildIndex(this.iconButtonExit, 0);
            this.Controls.SetChildIndex(this.textBoxTransmission, 0);
            this.Controls.SetChildIndex(this.textBoxWD, 0);
            this.Controls.SetChildIndex(this.textBoxName, 0);
            this.Controls.SetChildIndex(this.textBoxModel, 0);
            this.Controls.SetChildIndex(this.textBoxCapacity, 0);
            this.Controls.SetChildIndex(this.textBoxHorsePower, 0);
            this.Controls.SetChildIndex(this.textBoxType, 0);
            this.Controls.SetChildIndex(this.metroComboBoxModel, 0);
            this.Controls.SetChildIndex(this.metroComboBoxConf, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton metroRadioButtonAddExist;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonCreateNew;
        private Button_ buttonAddConf;
        private Button_ buttonAddModel;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private TextBox_ textBoxTransmission;
        private TextBox_ textBoxWD;
        private TextBox_ textBoxName;
        private TextBox_ textBoxModel;
        private TextBox_ textBoxCapacity;
        private TextBox_ textBoxHorsePower;
        private TextBox_ textBoxType;
        private MetroFramework.Controls.MetroComboBox metroComboBoxModel;
        private MetroFramework.Controls.MetroComboBox metroComboBoxConf;
        private Button_ buttonAdd;
    }
}