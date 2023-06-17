using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24강_대화상자
{
    public partial class Form2 : Form
    {
        public int x, y;//public

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            Close();//대화상자 닫힘->WM_CLOSE 메세지
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //속성
            DialogResult = DialogResult.Yes;
        }
    }
}
