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
	public partial class Difficultly : Form
	{
		public Difficultly()
		{
			InitializeComponent();
		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void Easy_Click(object sender, EventArgs e)
		{
			Form1 f = new Form1(5);
			f.Show();
			//this.Hide();
		}

		private void Medium_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1(10);
			f1.Show();
			//this.Hide();
		}

		private void Hard_Click(object sender, EventArgs e)
		{
			Form1 f2 = new Form1(15);
			f2.Show();
			//this.Hide();
		}

		private void Back_Click(object sender, EventArgs e)
		{
			Start s = new Start();
			s.Show();
			this.Close();
		}
	}
}
