
namespace degkjsokg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Dino = new System.Windows.Forms.PictureBox();
            this.obstacle = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.textscore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            this.SuspendLayout();
            // 
            // Dino
            // 
            this.Dino.Image = ((System.Drawing.Image)(resources.GetObject("Dino.Image")));
            this.Dino.Location = new System.Drawing.Point(52, 367);
            this.Dino.Name = "Dino";
            this.Dino.Size = new System.Drawing.Size(76, 74);
            this.Dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Dino.TabIndex = 0;
            this.Dino.TabStop = false;
            this.Dino.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // obstacle
            // 
            this.obstacle.Image = ((System.Drawing.Image)(resources.GetObject("obstacle.Image")));
            this.obstacle.Location = new System.Drawing.Point(305, 394);
            this.obstacle.Name = "obstacle";
            this.obstacle.Size = new System.Drawing.Size(67, 47);
            this.obstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.obstacle.TabIndex = 1;
            this.obstacle.TabStop = false;
            // 
            // obstacle2
            // 
            this.obstacle2.Image = ((System.Drawing.Image)(resources.GetObject("obstacle2.Image")));
            this.obstacle2.Location = new System.Drawing.Point(614, 388);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(59, 53);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.obstacle2.TabIndex = 2;
            this.obstacle2.TabStop = false;
            this.obstacle2.Click += new System.EventHandler(this.obstacle2_Click);
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Black;
            this.floor.Location = new System.Drawing.Point(-1, 438);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(802, 12);
            this.floor.TabIndex = 3;
            this.floor.TabStop = false;
            // 
            // textscore
            // 
            this.textscore.AutoSize = true;
            this.textscore.Location = new System.Drawing.Point(0, 0);
            this.textscore.Name = "textscore";
            this.textscore.Size = new System.Drawing.Size(50, 20);
            this.textscore.TabIndex = 4;
            this.textscore.Text = "label1";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvnet);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.textscore);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle);
            this.Controls.Add(this.Dino);
            this.Name = "Form1";
            this.Text = "Score: 0";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Dino;
        private System.Windows.Forms.PictureBox obstacle;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.Label textscore;
        private System.Windows.Forms.Timer GameTimer;
    }
}

