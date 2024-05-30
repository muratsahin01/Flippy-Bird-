namespace WinFormsApp11
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
            ground = new PictureBox();
            bird = new PictureBox();
            pipedown = new PictureBox();
            pipeup = new PictureBox();
            Score = new Label();
            gametimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).BeginInit();
            SuspendLayout();
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(1, 450);
            ground.Name = "ground";
            ground.Size = new Size(612, 74);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 0;
            ground.TabStop = false;
            ground.Click += pictureBox1_Click;
            // 
            // bird
            // 
            bird.Image = Properties.Resources.bird;
            bird.Location = new Point(74, 219);
            bird.Name = "bird";
            bird.Size = new Size(61, 51);
            bird.SizeMode = PictureBoxSizeMode.StretchImage;
            bird.TabIndex = 1;
            bird.TabStop = false;
            bird.Click += bird_Click;
            // 
            // pipedown
            // 
            pipedown.Image = Properties.Resources.pipedown;
            pipedown.Location = new Point(426, 313);
            pipedown.Name = "pipedown";
            pipedown.Size = new Size(100, 138);
            pipedown.SizeMode = PictureBoxSizeMode.StretchImage;
            pipedown.TabIndex = 2;
            pipedown.TabStop = false;
            pipedown.Click += pipedown_Click;
            // 
            // pipeup
            // 
            pipeup.Image = Properties.Resources.pipe;
            pipeup.Location = new Point(390, -1);
            pipeup.Name = "pipeup";
            pipeup.Size = new Size(100, 155);
            pipeup.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeup.TabIndex = 3;
            pipeup.TabStop = false;
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.Location = new Point(12, 481);
            Score.Name = "Score";
            Score.Size = new Size(50, 20);
            Score.TabIndex = 4;
            Score.Text = "label1";
            // 
            // gametimer
            // 
            gametimer.Enabled = true;
            gametimer.Interval = 20;
            gametimer.Tick += GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 524);
            Controls.Add(Score);
            Controls.Add(pipeup);
            Controls.Add(pipedown);
            Controls.Add(bird);
            Controls.Add(ground);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += gamekeydown;
            KeyUp += gamekeyup;
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ground;
        private PictureBox bird;
        private PictureBox pipedown;
        private PictureBox pipeup;
        private Label Score;
        private System.Windows.Forms.Timer gametimer;
    }
}
