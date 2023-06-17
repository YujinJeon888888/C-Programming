namespace _23강_리스트뷰
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
            int CLanguage = int.Parse(textBox1.Text);
            int CPlus = int.Parse(textBox2.Text);
            int CShap= int.Parse(textBox3.Text);
            int total = CLanguage + CPlus + CShap;
            float average = total / 3.0f;
            //아이템에 생성해서 넣어준다. 
            //new string[]배열 
            //생성과 동시에 초기화. 
            listView1.Items.Add(new ListViewItem(new string[]
            {
                CLanguage.ToString(),CPlus.ToString(),CShap.ToString(),
                total.ToString(),average.ToString("f1")
            }));
            
            //들어갔기 때문에 텍스트박스는 클리어.
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CLanguage = int.Parse(textBox1.Text);
            int CPlus = int.Parse(textBox2.Text);
            int CShap = int.Parse(textBox3.Text);
            int total = CLanguage + CPlus + CShap;
            float average = total / 3.0f;

            listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
            listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
            listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
            listView1.SelectedItems[0].SubItems[3].Text = total.ToString() ;
            listView1.SelectedItems[0].SubItems[4].Text = average.ToString("f1");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int CLanguage = int.Parse(textBox1.Text);
            int CPlus = int.Parse(textBox2.Text);
            int CShap = int.Parse(textBox3.Text);
            int total = CLanguage + CPlus + CShap;
            float average = total / 3.0f;

            int index = listView1.SelectedIndices[0];
            listView1.Items.Insert(index, new ListViewItem(
                new string[]
                {
                    CLanguage.ToString(),CPlus.ToString(),
                    CShap.ToString(),total.ToString(),average.ToString("f1")
                }
                ));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(0);
        }
    }
}