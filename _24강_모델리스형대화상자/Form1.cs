namespace _24강_모델리스형대화상자
{
    public partial class Form1 : Form
    {
        Form2 Dlg = null;//아직 생성 안 됐구나. 

        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dlg == null)
            {
                Dlg=new Form2();//없으면 만든다. 
                Dlg.Show();//출력
                //dispose()필요에따라 적절히.
            }
        }
    }
}