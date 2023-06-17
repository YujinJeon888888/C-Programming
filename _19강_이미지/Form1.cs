using Accessibility;
using System.Windows.Forms.PropertyGridInternal;

namespace _19강_이미지
{
    public partial class Form1 : Form
    {
        /*  Bitmap bitmap;*/

        //객체 2개
        BufferedGraphicsContext context;
        BufferedGraphics graphics;
        
        Image myImage;

        public Form1()
        {
            InitializeComponent();

            /*  //비트맵 생성
              bitmap = new Bitmap(400, 300);
              SetClientSizeCore(400, 300);*/

            /*            //참조
            context = BufferedGraphicsManager.Current;
            //버퍼 크기 설정
            context.MaximumBuffer = new Size(800, 600);
            //버퍼 그래픽스 객체 생성 및 참조
            //Allocate(CreateGraphics(): 현재 폼에 있는 그래픽스를 셋업. new Rectangle: 그것과 동일한 크기 가진 버퍼를 생성
            graphics = context.Allocate(CreateGraphics(), new Rectangle(0, 0, 800, 600));
            //버퍼 지우기
            //백버퍼가 노란색으로 지워진다. 
            graphics.Graphics.Clear(Color.Yellow);

            myImage = Image.FromFile("C:\\Users\\전문경\\Desktop\\이화배경\\1.jpg");
            SetClientSizeCore(800, 600);
*/       
            
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*            Image myImage = Image.FromFile("C:\\Users\\전문경\\Desktop\\이화배경\\1.jpg");
                        e.Graphics.DrawImage(myImage, 0, 0);
            */
            /*
                        //비트맵
                        //1. 이미지 로드
                        Bitmap myBitmap= new Bitmap("C:\\Users\\전문경\\Desktop\\이화배경\\1.jpg");
                        //2, 클라이언트 영역 지정(가로, 세로길이)
                        SetClientSizeCore(myBitmap.Width, myBitmap.Height);
                        e.Graphics.DrawImage(myBitmap, 0, 0);
            */

            /*            //메모리에서 그려지는 부분
            //static이어서 클래스 네임으로 가져올 수 있다. 
            Graphics bitmapGraphics = Graphics.FromImage(bitmap);
            //어떤색? 
            bitmapGraphics.Clear(Color.Yellow);
            for (int i = 0; i < 10; i++)
            {
                bitmapGraphics.DrawString("C# programing", Font, Brushes.Black, 10, 10+(20*i));
            }
            bitmapGraphics.DrawRectangle(Pens.Black, 100, 10, 200, 100);
            //폼에 출력
            e.Graphics.DrawImage(bitmap, 0, 0);
*/        
        
            /*  //더블 버퍼에 출력
            Random rand=new Random();
            for(int i = 0; i < 100; i++)
            {
                graphics.Graphics.DrawImage(myImage, rand.Next(0, 700), rand.Next(0, 500));
            }

            //화면에 출력
            //복사해주거나 주 메모리, 백버퍼 간 메모리 주소 바꿔주는 방법 쓰든,.. 
            //정확한 건 모르나 이 두 가지 방법 중 하나 썼을 것
            graphics.Render(e.Graphics);*/
        }
    }
}