using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Api
{

    public partial class Form1 : Form
    {
        private ViesAll viesAll;

        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            viesAll = new ViesAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static string RemoveHtmlTags(string input)
        {
            // Remove HTML tags
            string withoutTags = Regex.Replace(input, "<.*?>", string.Empty);

            // Remove consecutive newline characters
            string withoutNewLines = Regex.Replace(withoutTags, @"(\r?\n){2,}", "\n");

            return withoutNewLines.Trim(); // Trim to remove leading and trailing whitespace
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            string call = "https://ec.europa.eu/taxation_customs/vies/rest-api/ms/" + textBoxViesCountyAdd.Text + "/vat/" + textBoxAddVies.Text;
            try
            {
                string response = await client.GetStringAsync(call);

                Vies data = JsonConvert.DeserializeObject<Vies>(response);
                Vies existsVies = viesAll.viesAll.Find(data.vatNumber);
                if (existsVies != null)
                {

                }
                else
                {
                    viesAll.viesAll.Add(data);
                    viesAll.SaveChanges();
                }

                if (data != null)
                {
                    MessageBox.Show("Data downloaded");
                }
                else
                {
                    MessageBox.Show("Data not downloaded");
                }

            }
            catch (Exception ex) { }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vies dane = (Vies)listBox1.SelectedItem;
            richTextBox1.Text = dane.ToStringAll();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonShowDb_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = viesAll.viesAll.ToList<Vies>();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string name = textBoxFindName.Text;
            Vies dane = viesAll.viesAll.FirstOrDefault(v => v.name == name);
            if (dane != null)
            {
                richTextBox1.Text = dane.ToStringAll();
            }
            else
            {
                richTextBox1.Text = "Not found";
            }
        }
    }
}
