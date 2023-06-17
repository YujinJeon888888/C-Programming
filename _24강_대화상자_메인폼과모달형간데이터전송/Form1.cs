namespace _24강_대화상자_메인폼과모달형간데이터전송
{
    public partial class Form1 : Form
    {
        public string Message;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Dig = new Form2();
            Dig.Owner = this;//메인 폼. Form1를 참조할 수 있는 this를 보낸다.
            //Owner를 통해 메세지에 접근할 수 있게 된다. 
            Message = textBox1.Text;
            Dig.ShowDialog();//화면 출력
            Dig.Dispose();//해제
        }
    }
}