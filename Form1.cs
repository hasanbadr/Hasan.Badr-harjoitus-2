namespace Hasan.Badr_harjoitus_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            string teksti = ViestiTB.Text;
            TulostussLB.Text = teksti;//TulostusLB.txt = viestiTB.text;
            TulostussLB.Visible = true;
        }
    }
}