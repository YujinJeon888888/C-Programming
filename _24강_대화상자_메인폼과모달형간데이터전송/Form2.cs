using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24강_대화상자_메인폼과모달형간데이터전송
{

    public partial class Form2 : Form
    {

        string Message;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 MainForm= (Form1)Owner;//Owner에 MainForm의 참조가 저장되어있다. 
            Message=MainForm.Message;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(Message, Font, Brushes.Black, 10, 30);
        }
    }
}
