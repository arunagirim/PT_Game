namespace Game
{
	partial class Start
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
			this.play = new System.Windows.Forms.Button();
			this.highscores = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// play
			// 
			this.play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.play.Cursor = System.Windows.Forms.Cursors.Hand;
			this.play.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.play.Location = new System.Drawing.Point(169, 59);
			this.play.Name = "play";
			this.play.Size = new System.Drawing.Size(172, 75);
			this.play.TabIndex = 0;
			this.play.Text = "Play Game";
			this.play.UseVisualStyleBackColor = false;
			this.play.Click += new System.EventHandler(this.Play_Click);
			// 
			// highscores
			// 
			this.highscores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.highscores.Cursor = System.Windows.Forms.Cursors.Hand;
			this.highscores.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highscores.Location = new System.Drawing.Point(169, 202);
			this.highscores.Name = "highscores";
			this.highscores.Size = new System.Drawing.Size(172, 80);
			this.highscores.TabIndex = 0;
			this.highscores.Text = "High Scores";
			this.highscores.UseVisualStyleBackColor = false;
			this.highscores.Click += new System.EventHandler(this.Highscores_Click);
			// 
			// Start
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(505, 366);
			this.Controls.Add(this.highscores);
			this.Controls.Add(this.play);
			this.Name = "Start";
			this.Text = "Start";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button play;
		private System.Windows.Forms.Button highscores;
	}
}