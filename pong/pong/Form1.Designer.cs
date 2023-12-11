namespace pong
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			cpu = new PictureBox();
			ball = new PictureBox();
			player = new PictureBox();
			gameTimer = new System.Windows.Forms.Timer(components);
			cpuLabel = new Label();
			playerScore = new Label();
			((System.ComponentModel.ISupportInitialize)cpu).BeginInit();
			((System.ComponentModel.ISupportInitialize)ball).BeginInit();
			((System.ComponentModel.ISupportInitialize)player).BeginInit();
			SuspendLayout();
			// 
			// cpu
			// 
			cpu.BackColor = Color.White;
			cpu.ImageLocation = "";
			cpu.Location = new Point(897, 230);
			cpu.Name = "cpu";
			cpu.Size = new Size(27, 127);
			cpu.TabIndex = 0;
			cpu.TabStop = false;
			// 
			// ball
			// 
			ball.BackColor = SystemColors.Window;
			ball.Location = new Point(434, 239);
			ball.Name = "ball";
			ball.Size = new Size(27, 26);
			ball.TabIndex = 1;
			ball.TabStop = false;
			// 
			// player
			// 
			player.BackColor = Color.White;
			player.Location = new Point(12, 186);
			player.Name = "player";
			player.Size = new Size(27, 127);
			player.TabIndex = 2;
			player.TabStop = false;
			// 
			// gameTimer
			// 
			gameTimer.Enabled = true;
			gameTimer.Interval = 20;
			gameTimer.Tick += timerTick;
			// 
			// cpuLabel
			// 
			cpuLabel.AutoSize = true;
			cpuLabel.BackColor = SystemColors.Desktop;
			cpuLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			cpuLabel.ForeColor = Color.Red;
			cpuLabel.Location = new Point(735, 9);
			cpuLabel.Name = "cpuLabel";
			cpuLabel.Size = new Size(48, 32);
			cpuLabel.TabIndex = 3;
			cpuLabel.Text = "00";
			cpuLabel.TextAlign = ContentAlignment.TopRight;
			// 
			// playerScore
			// 
			playerScore.AutoSize = true;
			playerScore.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			playerScore.ForeColor = Color.Lime;
			playerScore.Location = new Point(105, 9);
			playerScore.Name = "playerScore";
			playerScore.Size = new Size(48, 32);
			playerScore.TabIndex = 4;
			playerScore.Text = "00";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Desktop;
			ClientSize = new Size(926, 566);
			Controls.Add(playerScore);
			Controls.Add(cpuLabel);
			Controls.Add(player);
			Controls.Add(ball);
			Controls.Add(cpu);
			Name = "Form1";
			Text = "Pong Game ";
			Load += Form1_Load;
			KeyDown += keyisdown;
			KeyUp += keyisup;
			((System.ComponentModel.ISupportInitialize)cpu).EndInit();
			((System.ComponentModel.ISupportInitialize)ball).EndInit();
			((System.ComponentModel.ISupportInitialize)player).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox cpu;
		private PictureBox ball;
		private PictureBox player;
		private System.Windows.Forms.Timer gameTimer;
		private Label cpuLabel;
		private Label playerScore;
	}
}
