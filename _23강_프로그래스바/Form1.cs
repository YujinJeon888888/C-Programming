namespace _23강_프로그래스바
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                progressBar1.Value= 0;
            }

            textBox1.Text=progressBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}