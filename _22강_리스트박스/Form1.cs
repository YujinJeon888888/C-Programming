namespace _22강_리스트박스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text=listBox1.SelectedIndex.ToString();
            textBox2.Text=listBox1.Text;
        }
    }
}