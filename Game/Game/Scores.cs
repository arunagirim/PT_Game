using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
	public partial class Scores : Form
	{
		public Scores()
		{
			InitializeComponent();
		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void Scores_Load(object sender, EventArgs e)
		{
			SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\giria\Downloads\hi.mdf;Integrated Security=True;Connect Timeout=30");
			string query = "SELECT * FROM [Scores] ORDER BY score DESC ";
			SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void Back_Click(object sender, EventArgs e)
		{
			Start s = new Start();
			s.Show();
			this.Close();
		}
	}
}
