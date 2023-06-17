namespace _19강_GDI
{
   
    public partial class Form1 : Form
    {
        //좌표기억
        Point[] ptCircle;
        int nCount;
        public Form1()
        {
            InitializeComponent();
            ptCircle = new Point[100];
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < nCount; i++)
            {
                //매개변수e를 통해 Graphics를 얻을 수 있다. 
                e.Graphics.DrawEllipse(Pens.Black, ptCircle[i].X - 10, ptCircle[i].Y - 10, 20, 20);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //e를 통해 이벤트 발생 좌표 가져올 수 있다. 
            ptCircle[nCount].X= e.X;
            ptCircle[nCount].Y= e.Y;

           // Graphics g=CreateGraphics();
           //g.DrawEllipse(Pens.Black, ptCircle[i].X - 10, ptCircle[i].Y - 10, 20, 20);


            nCount++;
            Invalidate();//화면 다시 그려주세요: 이 함수를 통해 Paint를 실행. 
            //g.Dispose();
        }
    }
}