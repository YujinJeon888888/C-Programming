namespace _22강_트랙바
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text= trackBar1.Value.ToString();
        }
    }
}