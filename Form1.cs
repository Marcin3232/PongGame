using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame

{
    public partial class Form1 : Form
    {
        List<System.Media.SoundPlayer> soundlist = new List<System.Media.SoundPlayer>();
        static int xSpeed = 10, ySpeed = 10;
        bool goup;
        bool godown;
        int discSpeed = 10;
        int scorePlayer = 0;
        int scoreEnemy = 0;
        int speed = 12;
        int timeGo = 0;
        bool pressKey = false;

        public Form1()
        {
            InitializeComponent();
            MusicClass music = new MusicClass(soundlist);
            this.KeyPreview = true;
            timer2.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pointRight.Text = "0" + scoreEnemy;
            pointLeft.Text = "0" + scorePlayer;
            //check score
            if (scoreEnemy == 10)
            {
                PlaySound play = new PlaySound(5, soundlist);
                label2.Visible = true;
                label2.Text = "Enemy Win";
                Lose();
            }
            if (scorePlayer == 10)
            {
                PlaySound play = new PlaySound(4, soundlist);
                label2.Visible = true;
                label2.Text = "You Win";
                Lose();
            }
            pB_Enemy.Top += speed;


            if (pB_Enemy.Top < 0 || pB_Enemy.Top > panel1.Height - pB_Enemy.Height)
            {
                speed = -speed;

            }


            if (ball.Top + ball.Height > panel1.Height + ball.Height - 2 * ySpeed || ball.Top < 0)
            {
                PlaySound play = new PlaySound(2, soundlist);
                ySpeed *= -1;
            }

            // reflection of the ball from disc
            if (ball.Bounds.IntersectsWith(pB_Enemy.Bounds) || ball.Bounds.IntersectsWith(pB_Left.Bounds))
            {
                PlaySound play = new PlaySound(1, soundlist);
                xSpeed *= -1;
            }
            // control disc
            if (goup == true && pB_Left.Top > 0)
            {
                pB_Left.Top -= discSpeed;
            }
            if (godown == true && pB_Left.Top < panel1.Height - pB_Left.Height)
            {
                pB_Left.Top += discSpeed;
            }

            //loss of the ball
            if (ball.Left - 12 <= pB_Left.Left && (ball.Top < pB_Left.Top || ball.Top > pB_Left.Top + pB_Left.Height))
            {
                PlaySound play = new PlaySound(0, soundlist);
                ball.Left = (panel1.Width / 2);
                addSpeed();
                xSpeed = -xSpeed;
                scoreEnemy++;


            }
            if (ball.Left + ball.Width > panel1.Width + ball.Height)
            {
                PlaySound play = new PlaySound(0, soundlist);
                ball.Left = (panel1.Width / 2);
                addSpeed();
                xSpeed = -xSpeed;
                scorePlayer++;
            }

            ball.Top += ySpeed;
            ball.Left += xSpeed;

        }

        private void addSpeed()
        {
            int grow = 2;
            if (xSpeed < 0)
            {
                xSpeed -= grow;

            }
            if (xSpeed > 0)
            {
                xSpeed += grow;
            }
            if (ySpeed < 0)
            {
                ySpeed -= grow;
            }
            if (ySpeed > 0)
            {
                ySpeed += grow;
            }
            if (speed < 0)
            {
                speed -= 1;
            }
            if (speed > 0)
            {
                speed += 1;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    godown = false;
                    goup = true;

                    break;
                case Keys.S:
                case Keys.Down:
                    godown = true;
                    goup = false;
                    break;
                case Keys.Space:
                    pressKey = true;
                    PlaySound play = new PlaySound(3, soundlist);
                    break;
            }
        }

        public void StartGame()
        {

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    goup = false;
                    break;
                case Keys.S:
                case Keys.Down:
                    godown = false;
                    break;

            }
        }
        
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pressKey == true)
            {
                label_start.Visible = false;
                label_LOSE.Visible = false;
                label2.Visible = false;
                timer1.Start();
                timer3.Start();
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timeGo++;
            TimeSpan time = TimeSpan.FromSeconds(timeGo);
            string str = time.ToString(@"mm\:ss");
            label1.Text = "Time: " + str;

        }

        public void Lose()
        {
            pressKey = false;
            label_LOSE.Visible = true;
            timer1.Stop();
            timer3.Stop();
            xSpeed = 10;
            ySpeed = 10;
            scorePlayer = 0;
            scoreEnemy = 0;
            speed = 12;
            timeGo = 0;

        }



    }
}
