namespace _22강_리스트박스_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //리스트 박스 추가
        private void button1_Click(object sender, EventArgs e)
        {
            //Item: 리스트 박스 안에 들어있는 항목을 관리하는 컬렉션 클래스
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();//클리어 안 해주면 이전 값이 남아있음. 
        }

        //리스트 박스 삭제
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        //리스트 박스 초기화
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//아이템 다 지워진다.
        }
    }
}