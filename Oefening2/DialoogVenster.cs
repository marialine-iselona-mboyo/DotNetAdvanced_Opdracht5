using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class DialoogVenster : Form
    {
        GemiddeldeMDI gemiddelde = new GemiddeldeMDI;


        public double number { get; set; }

        public DialoogVenster()
        {
            InitializeComponent();
        }

        private void btnWaarde_Click(object sender, EventArgs e)
        {
            this.number = double.Parse(tbWaarde.Text);
        }
    }
}
