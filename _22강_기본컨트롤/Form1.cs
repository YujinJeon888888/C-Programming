namespace _22강_기본컨트롤
{
    public partial class Form1 : Form
    {
        RadioButton selectedRadio;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "체크 1: " + checkBox1.CheckState +
                " 체크 2: " + checkBox2.CheckState +
                " 체크 3: " + checkBox3.CheckState;
            MessageBox.Show(result);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //컨트롤에 대한 변화가 발생했을 때
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //방법 1
            if (radioButton1.Checked)
                MessageBox.Show("radio 1선택");
            //방법 2
            //RadioButton selectedRadio;
            if (selectedRadio == radioButton2)
                MessageBox.Show("radio 2선택");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadio = (RadioButton)sender;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadio = (RadioButton)sender;
        }
    }
}