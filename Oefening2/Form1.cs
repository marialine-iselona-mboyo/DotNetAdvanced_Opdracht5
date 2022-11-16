namespace Oefening2
{
    public partial class Form1 : Form
    {

        GemiddeldeMDI gemiddeldeChild = new GemiddeldeMDI();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gemiddeldeChild.MdiParent = this;
            gemiddeldeChild.Size = this.Size;
            gemiddeldeChild.Show();
        }
    }
}