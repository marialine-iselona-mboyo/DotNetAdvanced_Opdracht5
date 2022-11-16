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

            double number = dialogWindow.number;
            bool noNumber = dialogWindow.noNumber;

            if (noNumber == false)
            {
                ListBoxGem.Items.Add(number);
 
            }

            int listGem = ListBoxGem.Items.Count;
            double total = 0;

            for (int i = 0; i < listGem; i++)
            {
                total += Convert.ToDouble(ListBoxGem.Items[i]);
            }

            total = (total / listGem);


            GemiddeldeTB.Text = total.ToString();
        }



        public void ToevoegenLijst(double number)
        {
            ListBoxGem.Items.Add(number);
        }
    }
}
