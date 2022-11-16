using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening3
{
    public partial class Kleur : Form
    {
        public Kleur()
        {
            InitializeComponent();
        }

        private void Kleur_Load(object sender, EventArgs e)
        {
            numericUpDownRed.Value = Form1.colorRedList[Form1.textBox];
            numericUpDownBlue.Value = Form1.colorBlueList[Form1.textBox];
            numericUpDownGreen.Value = Form1.colorGreenList[Form1.textBox];
            numericUpDownAlpha.Value = Form1.colorAlphaList[Form1.textBox];
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Form1.colorRedList[Form1.textBox] = (int)numericUpDownRed.Value;
            Form1.textBoxes.BackColor = Color.FromArgb(Form1.colorAlphaList[Form1.textBox], Form1.colorRedList[Form1.textBox], Form1.colorGreenList[Form1.textBox], Form1.colorBlueList[Form1.textBox]);
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            Form1.colorGreenList[Form1.textBox] = (int)numericUpDownGreen.Value;
            Form1.textBoxes.BackColor = Color.FromArgb(Form1.colorAlphaList[Form1.textBox], Form1.colorRedList[Form1.textBox], Form1.colorGreenList[Form1.textBox], Form1.colorBlueList[Form1.textBox]);
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            Form1.colorBlueList[Form1.textBox] = (int)numericUpDownBlue.Value;
            Form1.textBoxes.BackColor = Color.FromArgb(Form1.colorAlphaList[Form1.textBox], Form1.colorRedList[Form1.textBox], Form1.colorGreenList[Form1.textBox], Form1.colorBlueList[Form1.textBox]);
        }

        private void numericUpDownAlpha_ValueChanged(object sender, EventArgs e)
        {
            Form1.colorAlphaList[Form1.textBox] = (int)numericUpDownAlpha.Value;
            Form1.textBoxes.BackColor = Color.FromArgb(Form1.colorAlphaList[Form1.textBox], Form1.colorRedList[Form1.textBox], Form1.colorGreenList[Form1.textBox], Form1.colorBlueList[Form1.textBox]);
        }
    }
}
