namespace _22강_픽쳐박스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //폼 아무데나 더블 클릭하면 된다. 
        private void Form1_Load(object sender, EventArgs e)
        {
            //사이즈 모드를 설정해줄 수 있다. 
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = Image.FromFile("C:\\Users\\전문경\\Desktop\\스피릿페어러사진\\아흐려졌다.png");
        }
    }
}