namespace _23강_시간과날짜
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            textBox1.Text=dateTimePicker1.Value.ToLongDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text= dateTimePicker1.Value.ToLongDateString();
        }
    }
}