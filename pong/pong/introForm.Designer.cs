namespace pong
{
	partial class introForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			startButton = new Button();
			welcome = new Label();
			SuspendLayout();
			// 
			// startButton
			// 
			startButton.Location = new Point(410, 244);
			startButton.Name = "startButton";
			startButton.Size = new Size(94, 29);
			startButton.TabIndex = 1;
			startButton.Text = "Start";
			startButton.UseVisualStyleBackColor = true;
			startButton.Click += this.startButton_Click;
			// 
			// welcome
			// 
			welcome.AutoSize = true;
			welcome.ForeColor = SystemColors.ControlLightLight;
			welcome.Location = new Point(392, 149);
			welcome.Name = "welcome";
			welcome.Size = new Size(132, 60);
			welcome.TabIndex = 2;
			welcome.Text = "Weclome to Pong\r\n\r\nPush start to begin\r\n";
			// 
			// introForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Desktop;
			ClientSize = new Size(926, 566);
			Controls.Add(welcome);
			Controls.Add(startButton);
			Name = "introForm";
			Text = "Form2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button startButton;
		private Label welcome;
	}
}