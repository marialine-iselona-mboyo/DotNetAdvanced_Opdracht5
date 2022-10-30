namespace Oefening3
{
    public partial class Form1 : Form
    {

        private int x = 0;
        private int y = 25;
        private int breedte = 0;
        private int hoogte = 0;

        public static int teller;
        public static int rijTeller;
        public static int colTeller;

        public static List<int> colorRedList = new List<int>();
        public static List<int> colorBlueList = new List<int>();
        public static List<int> colorGreenList = new List<int>();
        public static List<int> colorAlphaList = new List<int>();
        public static List<TextBox> textBoxesList = new List<TextBox>();

        public static TextBox textBoxes = new TextBox();
        public static int textBox;

        private Kleur kleur;



        public Form1()
        {
            InitializeComponent();
        }

        private void toevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = teller;

            for(int i = 0; i < teller; i++)
            {
                this.Controls.RemoveAt(count);
                count--;
            }


            teller++;
            rijTeller = 0;
            colTeller = 0;
            for (int i = 0; i < teller; i++) { 
                colorAlphaList.Add(35);
                colorRedList.Add(255);
                colorGreenList.Add(128);
                colorBlueList.Add(128);

                Measurements();
                TextBox rechthoek = new TextBox();
                rechthoek.Multiline = true;
                rechthoek.Location = new Point(x, y);
                rechthoek.Size = new Size(breedte, hoogte);
                rechthoek.BackColor = Color.FromArgb(colorAlphaList[i], colorBlueList[i], colorGreenList[i], colorRedList[i]);
                this.Controls.Add(rechthoek);
                textBoxesList.Add(rechthoek);
            }
        }

        private void verwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int countdown = teller;
            for( int i = 0; i < teller; i++)
            {
                this.Controls.RemoveAt(countdown);
                countdown--;
            }

            for (int i = 0; i < teller; i++)
            {
                Measurements();
                TextBox rechthoek = new TextBox();
                rechthoek.Multiline = true;
                rechthoek.Location = new Point(x, y);
                rechthoek.Size = new Size(breedte, hoogte);
                rechthoek.BackColor = Color.FromArgb(colorAlphaList[i], colorBlueList[i], colorGreenList[i], colorRedList[i]);
                this.Controls.Add(rechthoek);
                textBoxesList.Add(rechthoek);
            }
        }





        public void Measurements()
        {
            int berekTeller = 1; 

            if(teller == 1)
            {
                berekTeller = 1;
            } else if (teller >= 2)
            {
                berekTeller = (int)Math.Ceiling(Math.Sqrt(teller));
            }

            breedte = (this.Size.Width - 19) / berekTeller;
            hoogte = (this.Size.Height - 76) / berekTeller;

            if(colTeller < berekTeller)
            {
                x = (this.Size.Width - 19) * rijTeller / berekTeller;
                y = (this.Size.Height - 76) * colTeller / berekTeller + 28;
            }

            colTeller++;

            if(colTeller == berekTeller)
            {
                rijTeller++;
                colTeller = 0;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int count = teller;
            for(int i = 0; i < teller; i++)
            {
                this.Controls.RemoveAt(count);
                count--;
            }

            colTeller = 0;
            rijTeller = 0;
            for(int j = 0; j < teller; j++)
            {
                Measurements();
                TextBox rechthoek = new TextBox();
                rechthoek.Multiline = true;
                rechthoek.Location = new Point(x, y);
                rechthoek.Size = new Size(breedte, hoogte);
                rechthoek.BackColor = Color.FromArgb(colorAlphaList[j], colorBlueList[j], colorGreenList[j], colorRedList[j]);
                this.Controls.Add(rechthoek);
                textBoxesList.Add(rechthoek);
            }
        }
    }
}