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
    public partial class GemiddeldeMDI : Form
    {
        
        public GemiddeldeMDI()
        {
            InitializeComponent();
        }



        private void NewNumberBtn_Click(object sender, EventArgs e)
        {
            DialoogVenster dialogWindow = new DialoogVenster();
            dialogWindow.ShowDialog();

            if (dialogWindow.DialogResult == DialogResult.OK)
            {
                ToevoegenLijst(dialogWindow.number);
                berekenGemiddelde();
                dialogWindow.Dispose();
            }
        }



        public void ToevoegenLijst(double number)
        {
            ListBoxGem.Items.Add(number);
        }


        public void berekenGemiddelde()
        {
            double total = 0;


            for (int i = 0; i < ListBoxGem.Items.Count; i++)
            {
                total = total + double.Parse(ListBoxGem.Items[i].ToString());
            }

            total = (total / ListBoxGem.Items.Count);


            GemiddeldeTB.Text = total.ToString();
        }
    }
}
