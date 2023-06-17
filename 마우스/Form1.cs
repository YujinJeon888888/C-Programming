namespace 마우스
{
    public partial class Form1 : Form
    {

        /*        string strMousePos;//좌표: 문자열로 존재->멤버로서 선언 해주어야 한다.
        */
        //Point: 좌표에 대한 구조체
        //좌표 기억하기 위해 클래스 멤버로 정의
        // List<Point> ListPoint = new List<Point>();*/

        //Rectangle : 멤버로서 선언
        Rectangle recMouse;

        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            recMouse.X = e.X ;       
            recMouse.Y= e.Y ;
            recMouse.Width = 0;
            recMouse.Height=0 ;
            Invalidate();
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
                recMouse.Width = e.X - recMouse.X + 1;//+1: 길이정보기 때문. 길이: 자기자신을 포함. 
                recMouse.Height = e.Y - recMouse.Y + 1;
                Invalidate();
            }

        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {

            string str = "left: " + recMouse.X + "top: " + recMouse.Y + "right: " + recMouse.Right + "button: " + recMouse.Bottom;
            e.Graphics.DrawRectangle(Pens.Black, recMouse);
            e.Graphics.DrawString(str, Font, Brushes.Black, 10, 10);
        }



        /*        private void Form1_Paint_1(object sender, PaintEventArgs e)
                {
                    if (ListPoint.Count == 3)
                    {
                        e.Graphics.DrawLine(Pens.Black, ListPoint[0], ListPoint[1]);
                        e.Graphics.DrawLine(Pens.Black, ListPoint[1], ListPoint[2]);
                        e.Graphics.DrawLine(Pens.Black, ListPoint[2], ListPoint[0]);
                    }

                }
        */
        /*        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
                {
                    Point pt = new Point(e.X, e.Y);
                    if (ListPoint.Count == 3)//3개가 됨
                    {
                        ListPoint.Clear();//비움
                    }

                    ListPoint.Add(pt);//넣어줌: 첫 점 
                    Invalidate();//화면에 출력할 수 있도록

                }
        */


        /*       private void Form1_MouseMove_1(object sender, MouseEventArgs e)
               {
                   strMousePos = "X: " + e.X + "Y: " + e.Y;
                   Invalidate();//이 부분 주석처리되어있다면 화면에 아무것도 안 나올 것. 
                   //Invalidate 통해 Paint라는 이벤트를 다시 한 번 더 호출해준다.
                   //워낙 빨리 일어나서 우리 눈에는 동시다발적으로 일어나는 것으로 보인다. 
               }

               private void Form1_Paint_1(object sender, PaintEventArgs e)
               {
                   e.Graphics.DrawString(strMousePos, Font, Brushes.Black, 10, 10);

               }
       */

        /*        private void button1_MouseDown(object sender, MouseEventArgs e)
                {
                    //컨트롤 위에서 마우스가 눌러졌을 때
                    MessageBox.Show("버튼 눌렸네");
                }

                private void Form1_Click_1(object sender, EventArgs e)
                {
                    MessageBox.Show("Click");
                }

                private void Form1_MouseClick(object sender, MouseEventArgs e)
                {
                    MessageBox.Show("Mouse Click");
                }
        */


    }
}