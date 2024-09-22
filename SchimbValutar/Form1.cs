using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;


namespace SchimbValutar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cursDin = boxDin.SelectedItem.ToString();
            string cursIn = boxIn.SelectedItem.ToString();

            double suma;
            if(!double.TryParse(txtSuma.Text, out suma)) 
            {
                MessageBox.Show("Vă rog scrieți o sumă validă pentru a se putea face conversia.","Eroare", MessageBoxButtons.OK);
                return;
            }

            double cursdeschimb;
            try
            {
                cursdeschimb = ObtineCursulValutar(cursDin, cursIn);

            }
            catch 
            {
                MessageBox.Show("A apărut o eroare la preluarea cursului de schimb.", "Eroare - Eroare API", MessageBoxButtons.OK);
                return;
            }

            double sumaSchimbata = suma * cursdeschimb;
            lblSumaSchimbata.Text = "Suma schimbată" + cursIn + lblSumaSchimbata.ToString();
            lblCurs.Text = $"Cursul de schimb: 1{cursDin} = {1 * cursdeschimb}{cursIn}";
        }
        private void lblSVT_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private double ObtineCursulValutar(string cursDin, string cursIn)
        {
            string json;

            using (var client = new WebClient())
            {
                json=client.DownloadString($"https://api.exchangerate-api.com/v4/lastest/{cursDin}");
            }
            var data = JObject.Parse(json);
            var rate = (double)data["rates"][cursIn];

            return rate;
        }
    }
}




