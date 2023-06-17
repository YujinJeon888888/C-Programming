namespace _22강_텍스트박스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CLang = Convert.ToInt32(textBox1.Text);
            int CPlus = Convert.ToInt32(textBox2.Text);
            int CShap = Convert.ToInt32(textBox3.Text);
        
            float Average=(CLang+CPlus+CShap)/3.0f;
            string Result=Average.ToString("f1");//소수 첫째자리까지
            MessageBox.Show(Result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Clear();//같은 결과
        }
    }
}