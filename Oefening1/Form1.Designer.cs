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
            this.InputText = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(844, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 40);
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
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(96, 34);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redCtrlRToolStripMenuItem,
            this.greenCtrlGToolStripMenuItem,
            this.blueCtrlBToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // redCtrlRToolStripMenuItem
            // 
            this.redCtrlRToolStripMenuItem.Name = "redCtrlRToolStripMenuItem";
            this.redCtrlRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.redCtrlRToolStripMenuItem.Size = new System.Drawing.Size(259, 40);
            this.redCtrlRToolStripMenuItem.Text = "Red";
            this.redCtrlRToolStripMenuItem.Click += new System.EventHandler(this.redCtrlRToolStripMenuItem_Click);
            // 
            // greenCtrlGToolStripMenuItem
            // 
            this.greenCtrlGToolStripMenuItem.Name = "greenCtrlGToolStripMenuItem";
            this.greenCtrlGToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.greenCtrlGToolStripMenuItem.Size = new System.Drawing.Size(259, 40);
            this.greenCtrlGToolStripMenuItem.Text = "Green";
            this.greenCtrlGToolStripMenuItem.Click += new System.EventHandler(this.greenCtrlGToolStripMenuItem_Click);
            // 
            // blueCtrlBToolStripMenuItem
            // 
            this.blueCtrlBToolStripMenuItem.Name = "blueCtrlBToolStripMenuItem";
            this.blueCtrlBToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.blueCtrlBToolStripMenuItem.Size = new System.Drawing.Size(259, 40);
            this.blueCtrlBToolStripMenuItem.Text = "Blue";
            this.blueCtrlBToolStripMenuItem.Click += new System.EventHandler(this.blueCtrlBToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallCtrlSToolStripMenuItem,
            this.normalCtrlNToolStripMenuItem,
            this.largeCtrlLToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // smallCtrlSToolStripMenuItem
            // 
            this.smallCtrlSToolStripMenuItem.Name = "smallCtrlSToolStripMenuItem";
            this.smallCtrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.smallCtrlSToolStripMenuItem.Size = new System.Drawing.Size(275, 40);
            this.smallCtrlSToolStripMenuItem.Text = "Small";
            this.smallCtrlSToolStripMenuItem.Click += new System.EventHandler(this.smallCtrlSToolStripMenuItem_Click);
            // 
            // normalCtrlNToolStripMenuItem
            // 
            this.normalCtrlNToolStripMenuItem.Name = "normalCtrlNToolStripMenuItem";
            this.normalCtrlNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.normalCtrlNToolStripMenuItem.Size = new System.Drawing.Size(275, 40);
            this.normalCtrlNToolStripMenuItem.Text = "Normal";
            this.normalCtrlNToolStripMenuItem.Click += new System.EventHandler(this.normalCtrlNToolStripMenuItem_Click);
            // 
            // largeCtrlLToolStripMenuItem
            // 
            this.largeCtrlLToolStripMenuItem.Name = "largeCtrlLToolStripMenuItem";
            this.largeCtrlLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.largeCtrlLToolStripMenuItem.Size = new System.Drawing.Size(275, 40);
            this.largeCtrlLToolStripMenuItem.Text = "Large";
            this.largeCtrlLToolStripMenuItem.Click += new System.EventHandler(this.largeCtrlLToolStripMenuItem_Click);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(12, 36);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(373, 395);
            this.InputText.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(844, 443);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

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
        private TextBox InputText;

        #endregion 
    }
}