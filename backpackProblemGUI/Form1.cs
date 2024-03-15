using backpackProblem;
using System.Numerics;

namespace backpackProblemGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void calculate()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown1.Value);
            int seed = Convert.ToInt32(numericUpDown2.Value);
            int maxCapacity = Convert.ToInt32(numericUpDown3.Value);



            Problem problem = new Problem(n, seed, maxCapacity);
            Result result = problem.solve();
            //listView1 = new ListView();

            richTextBox1.Text = problem.ToString();
            richTextBox2.Text = result.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
