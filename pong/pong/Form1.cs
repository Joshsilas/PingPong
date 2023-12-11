namespace pong
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		bool goup; 
		bool godown; 
		int cpuSpeed = 5;
		int ballHozSpeed = 5; 
		int ballVerSpeed = 5; 
		int score = 0;
		int cpuPoint = 0;

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void keyisdown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				goup = true;
			}
			if (e.KeyCode == Keys.Down)
			{
				godown = true;
			}
		}

		private void keyisup(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				goup = false;
			}
			if (e.KeyCode == Keys.Down)
			{
				godown = false;
			}
		}

		private void timerTick(object sender, EventArgs e)
		{
			playerScore.Text = "" + score; 
			cpuLabel.Text = "" + cpuPoint;
			ball.Top -= ballVerSpeed; 
			ball.Left -= ballHozSpeed; 
			cpu.Top += cpuSpeed;
			if (score < 0)
			{
				if (cpu.Top < 0)
				{
					cpu.Top = 0;
					cpuSpeed = 8;  
				}
				else if (cpu.Top > 455)
				{
					cpu.Top = 455;
					cpuSpeed = -8; 
				}
			}
				if (cpu.Top < 0)
				{
					cpu.Top = 0;
					cpuSpeed = 6;  
				}
				else if (cpu.Top > 455)
				{
					cpu.Top = 455;
					cpuSpeed = -6;  
				}
			if (ball.Left < 0)
			{
				ball.Left = 434;
				ballHozSpeed = -ballHozSpeed; 
				ballHozSpeed -= 1; 
				cpuPoint++; 
			}
			if (ball.Left + ball.Width > ClientSize.Width)
			{
				ball.Left = 434;  
				ballHozSpeed = -ballHozSpeed;
				ballHozSpeed += 1; 
				score++; 
			}
			if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
			{
				ballVerSpeed = -ballVerSpeed;
			}
			if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
			{
				ballHozSpeed = -ballHozSpeed;
			}
			if (goup == true && player.Top > 0)
			{
				player.Top -= 8;
			}

			if (godown == true && player.Top < 455)
			{
				player.Top += 8;
			}
			if (score > 10)
			{
				gameTimer.Stop();
				MessageBox.Show("You win this game");
			}
			if (cpuPoint > 10)
			{
				gameTimer.Stop();
				MessageBox.Show("CPU wins, you lose");
			}
		}
	}
}

