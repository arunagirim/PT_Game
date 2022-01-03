namespace Game
{
	partial class Difficultly
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
			this.label1 = new System.Windows.Forms.Label();
			this.easy = new System.Windows.Forms.Button();
			this.medium = new System.Windows.Forms.Button();
			this.hard = new System.Windows.Forms.Button();
			this.back = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(113, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "DIFFICULTY : ";
			// 
			// easy
			// 
			this.easy.BackColor = System.Drawing.Color.Red;
			this.easy.Cursor = System.Windows.Forms.Cursors.Hand;
			this.easy.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.easy.Location = new System.Drawing.Point(231, 153);
			this.easy.Name = "easy";
			this.easy.Size = new System.Drawing.Size(119, 56);
			this.easy.TabIndex = 1;
			this.easy.Text = "Easy";
			this.easy.UseVisualStyleBackColor = false;
			this.easy.Click += new System.EventHandler(this.Easy_Click);
			// 
			// medium
			// 
			this.medium.BackColor = System.Drawing.Color.Red;
			this.medium.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medium.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.medium.ForeColor = System.Drawing.Color.Black;
			this.medium.Location = new System.Drawing.Point(231, 246);
			this.medium.Name = "medium";
			this.medium.Size = new System.Drawing.Size(119, 58);
			this.medium.TabIndex = 2;
			this.medium.Text = "Medium";
			this.medium.UseVisualStyleBackColor = false;
			this.medium.Click += new System.EventHandler(this.Medium_Click);
			// 
			// hard
			// 
			this.hard.BackColor = System.Drawing.Color.Red;
			this.hard.Cursor = System.Windows.Forms.Cursors.Hand;
			this.hard.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hard.Location = new System.Drawing.Point(231, 343);
			this.hard.Name = "hard";
			this.hard.Size = new System.Drawing.Size(119, 56);
			this.hard.TabIndex = 3;
			this.hard.Text = "Hard";
			this.hard.UseVisualStyleBackColor = false;
			this.hard.Click += new System.EventHandler(this.Hard_Click);
			// 
			// back
			// 
			this.back.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.back.Cursor = System.Windows.Forms.Cursors.Hand;
			this.back.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back.Location = new System.Drawing.Point(512, 246);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(139, 58);
			this.back.TabIndex = 4;
			this.back.Text = "<< BACK";
			this.back.UseVisualStyleBackColor = false;
			this.back.Click += new System.EventHandler(this.Back_Click);
			// 
			// Difficultly
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(718, 460);
			this.Controls.Add(this.back);
			this.Controls.Add(this.hard);
			this.Controls.Add(this.medium);
			this.Controls.Add(this.easy);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "Difficultly";
			this.Text = "Difficultly";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button easy;
		private System.Windows.Forms.Button medium;
		private System.Windows.Forms.Button hard;
		private System.Windows.Forms.Button back;
	}
}