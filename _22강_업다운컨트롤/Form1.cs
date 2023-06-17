namespace _22강_업다운컨트롤
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            domainUpDown1.SelectedIndex = 0;
            textBox2.Text = domainUpDown1.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            textBox2.Text = domainUpDown1.Text;
        }
    }
}