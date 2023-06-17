namespace _20강_폼과타이머
{
    public partial class Form1 : Form
    {

        Rectangle[] rectangle;
        
        public Form1()
        {
            InitializeComponent();
            rectangle=new Rectangle[100];
           
            this.Width= 500;
            this.Height= 500;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Load event");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("종료하시겠습니까?","종료",MessageBoxButtons.YesNo)==DialogResult.No)
                e.Cancel = true;//종료하지 못하게. 
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //폼 크기 
            //폼 크기 고정되어버림, 원위치 못 돌아감
          /*  Control control =(Control)sender;
            control.Width = 500;
            control.Height = 500;*/

            this.Width = 500;
            this.Height = 500;
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            MessageBox.Show("layout");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //1초 동안 호출해줄 메서드.
            //타이머와 폼이 연결되어 무언가를 주고받을 수 있도록. 
            Random random= new Random();
            for(int i = 0; i < 100; i++)
            {
                rectangle[i].X = random.Next(200);
                rectangle[i].Y = random.Next(200);
                rectangle[i].Width = 60;
                rectangle[i].Height = 60;   
            }
            //중요!
            //Paint 다시 호출하도록.
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //그리는 것은 페인트의 역할
            for(int i = 0; i < 100; i++)
            {
                e.Graphics.DrawRectangle(Pens.Black, rectangle[i]);
            }
        }
    }
}