using System.Media;

namespace Winform2
{
    public partial class Form1 : Form
    {
        int score = 1000;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            score -= 10;

            Random rd = new Random();
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;
            int nextX = rd.Next(0, maxX); int nextY = rd.Next(0, maxY);
            button1.Location = new Point(nextX, nextY);
            this.Text = $"버튼위치: ({nextX}, {nextY}), 점수 : {score}";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "축하합니다~!";
            score += 100;

            Random rd = new Random();
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;
            int nextX = rd.Next(0, maxX); int nextY = rd.Next(0, maxY);
            button1.Location = new Point(nextX, nextY);
            this.Width = (int)(this.Width * 0.9);
            this.Height = (int)(this.Height * 0.9);
            this.Text = $"버튼위치: ({nextX}, {nextY}), 점수 : {score}";
        }



    }
}
