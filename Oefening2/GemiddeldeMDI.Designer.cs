namespace Oefening2
{
    partial class GemiddeldeMDI
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NewNumberBtn = new System.Windows.Forms.Button();
            this.GemiddeldeTB = new System.Windows.Forms.TextBox();
            this.labelGemiddelde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 229);
            this.listBox1.TabIndex = 0;
            // 
            // NewNumberBtn
            // 
            this.NewNumberBtn.Location = new System.Drawing.Point(458, 78);
            this.NewNumberBtn.Name = "NewNumberBtn";
            this.NewNumberBtn.Size = new System.Drawing.Size(147, 34);
            this.NewNumberBtn.TabIndex = 1;
            this.NewNumberBtn.Text = "Nieuw Getal";
            this.NewNumberBtn.UseVisualStyleBackColor = true;
            this.NewNumberBtn.Click += new System.EventHandler(this.NewNumberBtn_Click);
            // 
            // GemiddeldeTB
            // 
            this.GemiddeldeTB.Location = new System.Drawing.Point(567, 173);
            this.GemiddeldeTB.Name = "GemiddeldeTB";
            this.GemiddeldeTB.Size = new System.Drawing.Size(150, 31);
            this.GemiddeldeTB.TabIndex = 2;
            // 
            // labelGemiddelde
            // 
            this.labelGemiddelde.AutoSize = true;
            this.labelGemiddelde.Location = new System.Drawing.Point(416, 176);
            this.labelGemiddelde.Name = "labelGemiddelde";
            this.labelGemiddelde.Size = new System.Drawing.Size(117, 25);
            this.labelGemiddelde.TabIndex = 3;
            this.labelGemiddelde.Text = "Gemiddelde: ";
            // 
            // GemiddeldeMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGemiddelde);
            this.Controls.Add(this.GemiddeldeTB);
            this.Controls.Add(this.NewNumberBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "GemiddeldeMDI";
            this.Text = "GemiddeldeMDI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button NewNumberBtn;
        private TextBox GemiddeldeTB;
        private Label labelGemiddelde;
    }
}