namespace Game
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.vert = new System.Windows.Forms.Timer(this.components);
			this.ball = new System.Windows.Forms.PictureBox();
			this.slide = new System.Windows.Forms.PictureBox();
			this.horz = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.key_watch = new System.Windows.Forms.Timer(this.components);
			this.pausepanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.stopwatch = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.slide)).BeginInit();
			this.pausepanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// vert
			// 
			this.vert.Enabled = true;
			this.vert.Interval = 1;
			this.vert.Tick += new System.EventHandler(this.Vert_Tick);
			// 
			// ball
			// 
			this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
			this.ball.Location = new System.Drawing.Point(2, 0);
			this.ball.Name = "ball";
			this.ball.Size = new System.Drawing.Size(79, 75);
			this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ball.TabIndex = 0;
			this.ball.TabStop = false;
			this.ball.Click += new System.EventHandler(this.Ball_Click);
			// 
			// slide
			// 
			this.slide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.slide.BackColor = System.Drawing.Color.Red;
			this.slide.Location = new System.Drawing.Point(170, 378);
			this.slide.Name = "slide";
			this.slide.Size = new System.Drawing.Size(227, 10);
			this.slide.TabIndex = 1;
			this.slide.TabStop = false;
			this.slide.Click += new System.EventHandler(this.Slide_Click);
			// 
			// horz
			// 
			this.horz.Enabled = true;
			this.horz.Interval = 1;
			this.horz.Tick += new System.EventHandler(this.Horz_Tick);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Location = new System.Drawing.Point(671, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(44, 48);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click_1);
			// 
			// key_watch
			// 
			this.key_watch.Enabled = true;
			this.key_watch.Interval = 1;
			this.key_watch.Tick += new System.EventHandler(this.Key_watch_Tick);
			// 
			// pausepanel
			// 
			this.pausepanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pausepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pausepanel.Controls.Add(this.label1);
			this.pausepanel.Location = new System.Drawing.Point(129, 0);
			this.pausepanel.Name = "pausepanel";
			this.pausepanel.Size = new System.Drawing.Size(432, 48);
			this.pausepanel.TabIndex = 3;
			this.pausepanel.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(117, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "GAME PAUSED";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// stopwatch
			// 
			this.stopwatch.Enabled = true;
			this.stopwatch.Interval = 1000;
			this.stopwatch.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(714, 386);
			this.Controls.Add(this.pausepanel);
			this.Controls.Add(this.ball);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.slide);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.slide)).EndInit();
			this.pausepanel.ResumeLayout(false);
			this.pausepanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox ball;
		private System.Windows.Forms.PictureBox slide;
		private System.Windows.Forms.Timer horz;
		private System.Windows.Forms.Timer vert;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer key_watch;
		private System.Windows.Forms.Panel pausepanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer stopwatch;
	}
}

