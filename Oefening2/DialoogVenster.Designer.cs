namespace Oefening2
{
    partial class DialoogVenster
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbWaarde = new System.Windows.Forms.TextBox();
            this.btnWaarde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waarde: ";
            // 
            // tbWaarde
            // 
            this.tbWaarde.Location = new System.Drawing.Point(346, 181);
            this.tbWaarde.Name = "tbWaarde";
            this.tbWaarde.Size = new System.Drawing.Size(150, 31);
            this.tbWaarde.TabIndex = 1;
            // 
            // btnWaarde
            // 
            this.btnWaarde.Location = new System.Drawing.Point(366, 255);
            this.btnWaarde.Name = "btnWaarde";
            this.btnWaarde.Size = new System.Drawing.Size(112, 34);
            this.btnWaarde.TabIndex = 2;
            this.btnWaarde.Text = "OK";
            this.btnWaarde.UseVisualStyleBackColor = true;
            this.btnWaarde.Click += new System.EventHandler(this.btnWaarde_Click);
            // 
            // DialoogVenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWaarde);
            this.Controls.Add(this.tbWaarde);
            this.Controls.Add(this.label1);
            this.Name = "DialoogVenster";
            this.Text = "DialoogVenster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbWaarde;
        private Button btnWaarde;
    }
}