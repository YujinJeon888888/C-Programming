namespace _25강_스크롤
{
    public partial class Form1 : Form
    {
        Image myImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myImage = Image.FromFile("C:\\Users\\전문경\\Desktop\\그림.jpg");
            this.AutoScrollMinSize = myImage.Size;//스크롤바 출현
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //x,y값 넣어주면 자동으로 스크롤 영역만 출력
            e.Graphics.DrawImage(myImage, AutoScrollPosition.X, AutoScrollPosition.Y);
        }
    }
}