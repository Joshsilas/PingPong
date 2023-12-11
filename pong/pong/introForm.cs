using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace pong
{
	public partial class introForm : Form
	{
		public introForm()
		{
			InitializeComponent();
		}
		private void startButton_Click(object sender, EventArgs e)
		{
			// Create an instance of the new form
			Form1 form1 = new();

			form1.Show();
			this.Hide();
		}
	}
}