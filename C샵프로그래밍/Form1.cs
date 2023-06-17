using System.Drawing.Configuration;

namespace C샵프로그래밍
{
    public partial class Form1 : Form
    {
        string strMsg;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //   MessageBox.Show("KeyDown");
            /*if (e.KeyCode == Keys.A && e.Shift && e.Control)//이 중 하나라도 false면 실행x
            {
                MessageBox.Show("A+ SHIFT+ CONTROL");
            }*/
/*
            switch (e.KeyCode)
            {
                case Keys.A:
                    MessageBox.Show("A");
                    break;
                case Keys.B:
                    MessageBox.Show("B");
                    break;
            }*/

            //Modifiers 
          /*  if (e.Modifiers == (Keys.Shift | Keys.Control)) {
                MessageBox.Show("Modifier + Shift+ Control");
            }

            if ((e.KeyCode == Keys.A) && e.Modifiers == (Keys.Shift | Keys.Alt))
            {
                MessageBox.Show("A+ Shift+ Alt");
            }*/

            if(e.KeyData==(Keys.A|Keys.Shift|Keys.Control)) {
                MessageBox.Show("A+ Shift+ Control");
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* MessageBox.Show("KeyPress");*/
            strMsg += e.KeyChar;//이걸 이용해 문자열 계속 붙인다. 
            Invalidate();//이걸 호출함으로써 내부적으로 WM_PAINT메세지 발생
        }
    
        //WM_PAINT 메세지 발생->
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(strMsg, Font, Brushes.Black, 10, 10);
        }
    }
}