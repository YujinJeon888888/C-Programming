namespace _22강_콤보박스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //인덱스: 0부터 시작. 
            int Index=comboBox1.SelectedIndex;
            string FruitName=comboBox1.Text;  
            textBox1.Text = Index.ToString();
            textBox2.Text = FruitName;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}