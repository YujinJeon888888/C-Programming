namespace _24강_색상대화상자
{
    public partial class Form1 : Form
    {
        int Red,Green, Blue;

        private void button1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Red=Green=Blue=0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string str = "Red: " + Red + " Green: " + Green + " Blue: " + Blue;
            e.Graphics.DrawString(str, Font, Brushes.Black, 10, 20);

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color1 = colorDialog1.Color;
                Red=color1.R;Green=color1.G;Blue=color1.B;
                Invalidate();
            }    
        }
    }
}