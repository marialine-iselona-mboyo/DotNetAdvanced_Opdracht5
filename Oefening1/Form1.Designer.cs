namespace Oefening1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redCtrlRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenCtrlGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueCtrlBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeCtrlLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redCtrlRToolStripMenuItem,
            this.greenCtrlGToolStripMenuItem,
            this.blueCtrlBToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // redCtrlRToolStripMenuItem
            // 
            this.redCtrlRToolStripMenuItem.Name = "redCtrlRToolStripMenuItem";
            this.redCtrlRToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.redCtrlRToolStripMenuItem.Text = "Red    Ctrl+R";
            // 
            // greenCtrlGToolStripMenuItem
            // 
            this.greenCtrlGToolStripMenuItem.Name = "greenCtrlGToolStripMenuItem";
            this.greenCtrlGToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.greenCtrlGToolStripMenuItem.Text = "Green  Ctrl+G";
            // 
            // blueCtrlBToolStripMenuItem
            // 
            this.blueCtrlBToolStripMenuItem.Name = "blueCtrlBToolStripMenuItem";
            this.blueCtrlBToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.blueCtrlBToolStripMenuItem.Text = "Blue     Ctrl+B";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.redToolStripMenuItem.Text = "Red";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.greenToolStripMenuItem.Text = "Green";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.blueToolStripMenuItem.Text = "Blue";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallCtrlSToolStripMenuItem,
            this.normalCtrlNToolStripMenuItem,
            this.largeCtrlLToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // smallCtrlSToolStripMenuItem
            // 
            this.smallCtrlSToolStripMenuItem.Name = "smallCtrlSToolStripMenuItem";
            this.smallCtrlSToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.smallCtrlSToolStripMenuItem.Text = "Small  Ctrl+S";
            // 
            // normalCtrlNToolStripMenuItem
            // 
            this.normalCtrlNToolStripMenuItem.Name = "normalCtrlNToolStripMenuItem";
            this.normalCtrlNToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.normalCtrlNToolStripMenuItem.Text = "Normal  Ctrl+N";
            // 
            // largeCtrlLToolStripMenuItem
            // 
            this.largeCtrlLToolStripMenuItem.Name = "largeCtrlLToolStripMenuItem";
            this.largeCtrlLToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.largeCtrlLToolStripMenuItem.Text = "Large  Ctrl+L";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1202, 620);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem redCtrlRToolStripMenuItem;
        private ToolStripMenuItem greenCtrlGToolStripMenuItem;
        private ToolStripMenuItem blueCtrlBToolStripMenuItem;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem smallCtrlSToolStripMenuItem;
        private ToolStripMenuItem normalCtrlNToolStripMenuItem;
        private ToolStripMenuItem largeCtrlLToolStripMenuItem;
    }
}