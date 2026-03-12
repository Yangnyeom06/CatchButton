using System.Media;

namespace Winform2
{
    public partial class Form1 : Form
    {
        int score = 1000;
        int life = 20;

        public Form1()
        {
            InitializeComponent();
            InitGame(); // 초기 시작
        }

        private void button1_MouseEnter(object sender, EventArgs e) // 나를 잡아봐 버튼에 마우스가 들어올 때 이벤트
        {
            score -= 10;
            life -= 1;
            if (life <= 0)
            {
                label1.Text = "Game Over";
                button1.Enabled = false;
                button2.Enabled = true;
            }
            Random rd = new Random();
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;
            int nextX = rd.Next(0, maxX); int nextY = rd.Next(0, maxY);
            button1.Location = new Point(nextX, nextY);
            this.Text = $"버튼위치: ({nextX}, {nextY}), 점수 : {score}";
        }



        private void button1_Click(object sender, EventArgs e) // 나를 잡아봐 버튼 클릭시 이벤트
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

        private void button2_Click(object sender, EventArgs e) // 다시하기 버튼 클릭시 재시작
        {
            InitGame();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e) // 버튼을 클릭할때 label1 안보이게
        {
            label1.Text = "";
        }

        public void InitGame() // 게임 초기 시작 및 재시작
        {
            score = 1000;
            life = 20;
            button1.Enabled = true;
            button2.Enabled = false;
            label1.Text = "";

            Random rd = new Random();
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;
            int nextX = rd.Next(0, maxX); int nextY = rd.Next(0, maxY);
            button1.Location = new Point(nextX, nextY);
            this.Text = $"버튼위치: ({nextX}, {nextY}), 점수 : {score}";
        }
    }
}
