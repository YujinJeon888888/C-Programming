namespace _21강_메뉴
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("열기");
        }

        //컨텍스트 메뉴
        private void 열기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("컨텍스트 메뉴 열기");

        }
    }
}