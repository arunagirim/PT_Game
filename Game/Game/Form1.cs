using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Game
{
	
	public partial class Form1 : Form
	{
		int sec = 0;
		public Form1()
		{

			InitializeComponent();
			
		}
		public Form1(int s)
		{
			InitializeComponent();
			this.speed = s;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		int speed ;
		int slide_speed = 10;

		int vdir = +1;

		bool gameover = false;
		long score;
		


		private void Vert_Tick(object sender, EventArgs e)
		{
			

			if (ball.Top < 0)
			{
				vdir = +1;
			}
			else if (ball.Top > (this.Height - ball.Height-slide.Height))
			{

				if (ball.Left < slide.Left || ((ball.Left + ball.Width) > (slide.Left + slide.Width)))
				{
					vert.Enabled = horz.Enabled = false;
					gameover = true;

					pausepanel.BackColor = Color.DarkRed;
					paused = false;
					label1.Text = "GAME OVER";
					score = sec*100;
					string name = Interaction.InputBox("Your score is " + score  + " Enter your name", "Score", " ", -1, -1);


					String connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\giria\Downloads\hi.mdf;Integrated Security=True;Connect Timeout=30";

					SqlConnection cnn;
					cnn = new SqlConnection(connection);
					cnn.Open();
					using (cnn)
					{
						String query = "INSERT INTO [Scores] (name,score) VALUES (@name,@score)";

						using (SqlCommand command = new SqlCommand(query, cnn))
						{

							command.Parameters.AddWithValue("@name", name);
							command.Parameters.AddWithValue("@score", score);
							int result = command.ExecuteNonQuery();

							// Check Error
							if (result < 0)
								Console.WriteLine("Error inserting data into Database!");
							else
							{
								this.Close();
							}

						}

					}
				}


				vdir = -1;
			}
			ball.Top += (vdir*speed);
		}


		int hdir = +1;

		private void Horz_Tick(object sender, EventArgs e)
		{

			if (ball.Left < 0)
			{
				hdir = +1;
			}
			else if (ball.Left > (this.Width - ball.Height))
			{
				hdir = -1;
			}
			ball.Left += (hdir*speed);
		}

		private void Key_watch_Tick(object sender, EventArgs e)
		{
			if (_right && slide.Left < (this.Width - slide.Width))
			{
				slide.Left = slide.Left + 10;
			}
			else if (_left && slide.Left > 0)
			{
				slide.Left = slide.Left - 10;
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{

		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
			//Environment.Exit(0);
			this.Close();

		}

		private void Ball_Click(object sender, EventArgs e)
		{

		}

		private void Slide_Click(object sender, EventArgs e)
		{

		}

		bool _left = false, _right = false;
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			//active
			if(e.KeyCode==Keys.D)
			{
				_right = true;
			}
			else if (e.KeyCode == Keys.A)
			{
				_left = true;
			}
			else if (e.KeyCode == Keys.Escape)
			{
				//pause game
				vert.Enabled = horz.Enabled = paused= false;
			}
			else if (e.KeyCode == Keys.End)
			{
				//resume game
				vert.Enabled = horz.Enabled=paused = true;
			}
		}

		bool paused
		{
			get
			{
				return !pausepanel.Visible;
			}
			set
			{
				pausepanel.Visible = !value;
			}
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			sec++;
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			//inactive
			if (e.KeyCode == Keys.D || e.KeyCode == Keys.A)
			{
				_right = _left = false;//disable all
			}
		}

		

		
	}
}
