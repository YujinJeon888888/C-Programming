namespace _25강_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 폼1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 MdiChildForm1 = new Form2();
            MdiChildForm1.MdiParent= this;//엄마가 나다.
            MdiChildForm1.Show();
        }
    }
}