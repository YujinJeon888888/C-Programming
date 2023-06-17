using System.Drawing.Drawing2D;

namespace _19강_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*            string str = "Alpha : " + Color.Blue.A + " Red: " + Color.Blue.R
                            + "Green: " + Color.Blue.G + "Blue: " + Color.Blue.B;
                        e.Graphics.DrawString(str, Font, Brushes.Black, 10, 10);
            */

            /*            Color myColor = Color.FromArgb(255, 0, 0);
                        Pen newPen = new Pen(myColor, 5.0f);
                        e.Graphics.DrawLine(newPen, 10, 10, 100, 10);
                        //Pens: 기본 제공 펜
                        e.Graphics.DrawLine(Pens.Blue, 10, 20, 100, 20);
                        newPen.DashStyle = DashStyle.Dot;
                        e.Graphics.DrawLine(newPen, 10, 30, 100, 30);

                        newPen.Dispose();*/


            /*  SolidBrush myBrush = new SolidBrush(Color.Blue);
              e.Graphics.FillEllipse(myBrush, 10, 10, 100, 100);
              myBrush.Dispose();*/

            HatchBrush Hash = new HatchBrush(HatchStyle.Plaid, Color.Red, Color.Blue);
            e.Graphics.FillRectangle(Hash, 10,10,200,200); 
        }

    }
}
