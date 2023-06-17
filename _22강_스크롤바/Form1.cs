namespace _22강_스크롤바
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text=hScrollBar1.Value.ToString();  
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text=hScrollBar1.Value.ToString();
        }
    }
}