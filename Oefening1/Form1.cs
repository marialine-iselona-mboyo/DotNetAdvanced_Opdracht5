using System;
using System.Drawing;
using System.Windows.Forms;

namespace Oefening1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void redCtrlRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.ForeColor = Color.Red;
            InputText.BackColor = Color.Red;
        }

        private void greenCtrlGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.ForeColor = Color.Green;
            InputText.BackColor = Color.Green;
        }

        private void blueCtrlBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.ForeColor = Color.Blue;
            InputText.BackColor = Color.Blue;
        }





        private void smallCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Font = Font = new Font(InputText.Font.Name, 6,
                    InputText.Font.Style, InputText.Font.Unit);
        }

        private void normalCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Font = Font = new Font(InputText.Font.Name, 12,
                    InputText.Font.Style, InputText.Font.Unit);
        }

        private void largeCtrlLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Font = Font = new Font(InputText.Font.Name, 24,
                    InputText.Font.Style, InputText.Font.Unit);
        }






    }
}