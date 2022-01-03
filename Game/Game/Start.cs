using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
	public partial class Start : Form
	{
		public Start()
		{
			InitializeComponent();
		}

		private void Highscores_Click(object sender, EventArgs e)
		{
			Scores s = new Scores();
			s.Show();
			this.Hide();
		}

		private void Play_Click(object sender, EventArgs e)
		{
			Difficultly d = new Difficultly();
			d.Show();
			this.Hide();
		}
	}
}
