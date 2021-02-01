using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degkjsokg
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpSpeed;
        int force = 14;
        int score = 0;
        int obstacleSpeed = 10;  
        Random rand = new Random();
        int position;
        bool isGameOver = false;
        



        public Form1()
        {
            InitializeComponent();

            GameReset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void obstacle2_Click(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvnet(object sender, EventArgs e)
        {
            Dino.Top += jumpSpeed;

            textscore.Text = "Score: " + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -14;
                force = 1;
            }
            else
            {
                jumpSpeed = 14;
            }

            if (Dino.Top > 366 && jumping == false)
            {
                force = 14;
                Dino.Top = 367;
                jumpSpeed = 0;
            }


            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstace")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++; 
                    }

                    if (Dino.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();

                        textscore.Text += " Press R to restart game";
                        isGameOver = true;

                    }
                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;

            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }

        }

        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            textscore.Text = "Score: " + score;
            score = 0;
            obstacleSpeed = 10;
            obstacleSpeed = 10;
            isGameOver = false;
            Dino.Top = 367;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = position;

                }

                GameTimer.Start();


            }
        }
    }
}
