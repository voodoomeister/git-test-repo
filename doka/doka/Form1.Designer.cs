namespace doka
{
    partial class FormAuthorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.TextboxLogin = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TextboxPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ButtonAuthorization = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelDoka = new System.Windows.Forms.Label();
            this.labelSoft = new System.Windows.Forms.Label();
            this.ProgressBarConection = new Bunifu.Framework.UI.BunifuProgressBar();
            this.AuthLog = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TextboxLogin
            // 
            this.TextboxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextboxLogin.BackColor = System.Drawing.SystemColors.Control;
            this.TextboxLogin.BorderColorFocused = System.Drawing.Color.Black;
            this.TextboxLogin.BorderColorIdle = System.Drawing.SystemColors.ControlDarkDark;
            this.TextboxLogin.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.TextboxLogin.BorderThickness = 3;
            this.TextboxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxLogin.ForeColor = System.Drawing.Color.Black;
            this.TextboxLogin.isPassword = false;
            this.TextboxLogin.Location = new System.Drawing.Point(14, 202);
            this.TextboxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxLogin.Name = "TextboxLogin";
            this.TextboxLogin.Size = new System.Drawing.Size(368, 44);
            this.TextboxLogin.TabIndex = 0;
            this.TextboxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextboxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.TextboxPassword.BorderColorFocused = System.Drawing.Color.Black;
            this.TextboxPassword.BorderColorIdle = System.Drawing.Color.DimGray;
            this.TextboxPassword.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.TextboxPassword.BorderThickness = 3;
            this.TextboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxPassword.ForeColor = System.Drawing.Color.Black;
            this.TextboxPassword.isPassword = true;
            this.TextboxPassword.Location = new System.Drawing.Point(14, 282);
            this.TextboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(368, 44);
            this.TextboxPassword.TabIndex = 1;
            this.TextboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ButtonAuthorization
            // 
            this.ButtonAuthorization.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonAuthorization.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonAuthorization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAuthorization.BorderRadius = 0;
            this.ButtonAuthorization.ButtonText = "Вход";
            this.ButtonAuthorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAuthorization.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonAuthorization.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonAuthorization.Iconimage = null;
            this.ButtonAuthorization.Iconimage_right = null;
            this.ButtonAuthorization.Iconimage_right_Selected = null;
            this.ButtonAuthorization.Iconimage_Selected = null;
            this.ButtonAuthorization.IconMarginLeft = 0;
            this.ButtonAuthorization.IconMarginRight = 0;
            this.ButtonAuthorization.IconRightVisible = true;
            this.ButtonAuthorization.IconRightZoom = 0D;
            this.ButtonAuthorization.IconVisible = true;
            this.ButtonAuthorization.IconZoom = 90D;
            this.ButtonAuthorization.IsTab = false;
            this.ButtonAuthorization.Location = new System.Drawing.Point(119, 396);
            this.ButtonAuthorization.Name = "ButtonAuthorization";
            this.ButtonAuthorization.Normalcolor = System.Drawing.SystemColors.Control;
            this.ButtonAuthorization.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.ButtonAuthorization.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonAuthorization.selected = false;
            this.ButtonAuthorization.Size = new System.Drawing.Size(156, 48);
            this.ButtonAuthorization.TabIndex = 2;
            this.ButtonAuthorization.Text = "Вход";
            this.ButtonAuthorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonAuthorization.Textcolor = System.Drawing.Color.Black;
            this.ButtonAuthorization.TextFont = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAuthorization.Click += new System.EventHandler(this.ButtonAuthorization_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(356, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelDoka
            // 
            this.labelDoka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDoka.AutoSize = true;
            this.labelDoka.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoka.Location = new System.Drawing.Point(156, 83);
            this.labelDoka.Name = "labelDoka";
            this.labelDoka.Size = new System.Drawing.Size(104, 46);
            this.labelDoka.TabIndex = 5;
            this.labelDoka.Text = "Дока";
            // 
            // labelSoft
            // 
            this.labelSoft.AutoSize = true;
            this.labelSoft.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSoft.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelSoft.Location = new System.Drawing.Point(240, 77);
            this.labelSoft.Name = "labelSoft";
            this.labelSoft.Size = new System.Drawing.Size(46, 24);
            this.labelSoft.TabIndex = 6;
            this.labelSoft.Text = "CRM";
            // 
            // ProgressBarConection
            // 
            this.ProgressBarConection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBarConection.BackColor = System.Drawing.SystemColors.Highlight;
            this.ProgressBarConection.BorderRadius = 5;
            this.ProgressBarConection.ForeColor = System.Drawing.SystemColors.Control;
            this.ProgressBarConection.Location = new System.Drawing.Point(13, 498);
            this.ProgressBarConection.MaximumValue = 100;
            this.ProgressBarConection.Name = "ProgressBarConection";
            this.ProgressBarConection.ProgressColor = System.Drawing.SystemColors.Highlight;
            this.ProgressBarConection.Size = new System.Drawing.Size(368, 10);
            this.ProgressBarConection.TabIndex = 7;
            this.ProgressBarConection.Value = 0;
            // 
            // AuthLog
            // 
            this.AuthLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthLog.AutoSize = true;
            this.AuthLog.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthLog.Location = new System.Drawing.Point(161, 461);
            this.AuthLog.Name = "AuthLog";
            this.AuthLog.Size = new System.Drawing.Size(0, 18);
            this.AuthLog.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль";
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(398, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuthLog);
            this.Controls.Add(this.ProgressBarConection);
            this.Controls.Add(this.labelSoft);
            this.Controls.Add(this.labelDoka);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonAuthorization);
            this.Controls.Add(this.TextboxPassword);
            this.Controls.Add(this.TextboxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ДОКА CRM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxLogin;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxPassword;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonAuthorization;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSoft;
        private System.Windows.Forms.Label labelDoka;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressBarConection;
        private System.Windows.Forms.Label AuthLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

