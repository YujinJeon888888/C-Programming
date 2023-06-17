namespace _24강_대화상자
{
    public partial class Form1 : Form
    {
        int Sum;

        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //로컬변수
            Form2 Dig = new Form2();
            Dig.ShowDialog();//showDialog(): 모달형 대화상자 화면 출력


            /*Form Dlg = new Form2();
             if (Dlg.ShowDialog() == DialogResult.Yes)
             {
                 MessageBox.Show("정상종료");
             }*/

            Sum = Dig.x + Dig.y;
            Dig.Dispose();//해제해주기
            Invalidate();
        }

        private void toolStripMenuItem3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("계산된 결과는 " + Sum.ToString() + " 입니다.",
                Font, Brushes.Black, 10, 30);
        }
    }
}