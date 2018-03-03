namespace doka
{
    partial class MainWormCrm
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
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(80, 823);
            this.panelMainMenu.TabIndex = 0;
            // 
            // panelUser
            // 
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(80, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(915, 77);
            this.panelUser.TabIndex = 1;
            // 
            // MainWormCrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 823);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panelMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWormCrm";
            this.Text = "MainWormCrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel panelUser;
    }
}