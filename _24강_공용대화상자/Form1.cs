namespace _24강_공용대화상자
{
    public partial class Form1 : Form
    {
        int Number = 12;
        string Message = "Hello World!";
        public Form1()
        {
            InitializeComponent();
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Stream myStream;
            saveFileDialog1.DefaultExt = "dat";
            saveFileDialog1.Filter = "데이터(*.dat) | *.dat";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //파일처리
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    //using: 쓰고난 후 close() 까먹는 거 방지하기 위해
                    //close() 자동호출. 
                    //이진 형태로 저장. 

                    using (BinaryWriter bw = new BinaryWriter(myStream))
                    {
                        bw.Write(Number);
                        bw.Write(Message);
                    }

                }
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            saveFileDialog1.Filter = "데이터(*.dat) | *.dat";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //파일처리
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    //using: 쓰고난 후 close() 까먹는 거 방지하기 위해
                    //close() 자동호출. 
                    //이진 형태로 저장. 

                    using (BinaryReader br = new BinaryReader(myStream))
                    {
                        Number =br.ReadInt32();
                        Message = br.ReadString();
                        Invalidate();
                    }

                }
            }
        }

        private void 열기ToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(Number.ToString(), Font, Brushes.Black, 10, 30);
            e.Graphics.DrawString(Message, Font, Brushes.Black, 10, 50);
        }
    }
}