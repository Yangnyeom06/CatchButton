using System.Media;

namespace Winform2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rd = new Random();
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;
            int nextX = rd.Next(0, maxX); int nextY = rd.Next(0, maxY);
            button1.Location = new Point(nextX, nextY);
            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "축하합니다~!";
            Random rd = new Random();
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;
            int nextX = rd.Next(0, maxX); int nextY = rd.Next(0, maxY);
            button1.Location = new Point(nextX, nextY);
            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "";
        }
    }
}
