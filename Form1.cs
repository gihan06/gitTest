using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Created by: Pooja Jain
//Name: PJ's Breakout Game
//Date : 29/04/2015
//Retrieved from : msdn.com, youtube.com, stackoverflow.com

namespace BreakoutGame
{
    public partial class FrmBreakout : Form
    {
        public Rectangle Ball;
        public Rectangle Paddle;

    
        public Rectangle BrickOne;
        public Rectangle BrickTwo;
        public Rectangle BrickThree;
        public Rectangle BrickFour;
        public Rectangle BrickFive;
        public Rectangle BrickSix;
        public Rectangle BrickSeven;
        public Rectangle BrickEight;
        public Rectangle BrickNine;
        public Rectangle BrickTen;
        public Rectangle BrickEleven;
        public Rectangle BrickTwelve;

        public int Score;

        public int speed_left = 7;
        public int speed_top = 7;

        


        public FrmBreakout()
        {
            InitializeComponent();

            
            Ball = new Rectangle(420, 400, 35, 35);
            Paddle = new Rectangle(300, 435, 280, 20);

            Paddle.Y = pnlGame.Bottom - (pnlGame.Bottom / 10);  //set position of the paddle from the panel

            
            BrickOne = new Rectangle(161, 102, 90, 35);
            BrickTwo = new Rectangle(254, 102, 90, 35);
            BrickThree = new Rectangle(347, 102, 90, 35);
            BrickFour = new Rectangle(440, 102, 90, 35);
            BrickFive = new Rectangle(533, 102, 90, 35);
            BrickSix = new Rectangle(626, 102, 90, 35);
            BrickSeven = new Rectangle(161, 144, 90, 35);
            BrickEight = new Rectangle(254, 144, 90, 35);
            BrickNine = new Rectangle(347, 144, 90, 35);
            BrickTen = new Rectangle(440, 144, 90, 35);
            BrickEleven = new Rectangle(533, 144, 90, 35);
            BrickTwelve = new Rectangle(626, 144, 90, 35);

            Score = 0;  //set Score to Zero

            lblLose.Visible = false;    //hide the loser label
            lblWin.Visible = false;     //hide the win label
            picThumbsup.Visible = false; //hide the Thumbs Up pic box
            picThumbsdwn.Visible = false;   //hide the Thumbs Down pic box

            lblLose.Left = (pnlGame.Width / 2) - (lblLose.Width / 2);   //centre align the YOU LOSE label in the panel
            lblWin.Left = (pnlGame.Width / 2) - (lblWin.Width / 2); // centre align the YOU WIN label in the panel
          
            
        }



        private void FrmBreakout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.White, Ball);
            e.Graphics.FillRectangle(Brushes.Red, Paddle);



            e.Graphics.FillRectangle(Brushes.Green, BrickOne);
            e.Graphics.FillRectangle(Brushes.Orange, BrickTwo);
            e.Graphics.FillRectangle(Brushes.Maroon, BrickThree);
            e.Graphics.FillRectangle(Brushes.Green, BrickFour);
            e.Graphics.FillRectangle(Brushes.Gold, BrickFive);
            e.Graphics.FillRectangle(Brushes.Pink, BrickSix);
            e.Graphics.FillRectangle(Brushes.Brown, BrickSeven);
            e.Graphics.FillRectangle(Brushes.Green, BrickEight);
            e.Graphics.FillRectangle(Brushes.Orange, BrickNine);
            e.Graphics.FillRectangle(Brushes.Pink, BrickTen);
            e.Graphics.FillRectangle(Brushes.Green, BrickEleven);
            e.Graphics.FillRectangle(Brushes.Maroon, BrickTwelve);


            lblScore.Text = ("Score: " + Score);



            if (Ball.IntersectsWith(BrickOne))
            {
                
                BrickOne = new Rectangle(0, 0, 0, 0);
                Score = Score + 10;
            }
            else
                tmrOne.Start();


            if (Ball.IntersectsWith(BrickTwo))
            {

                
                BrickTwo = new Rectangle(0, 0, 0, 0);
                Score = Score + 10;
            }
            else
                tmrOne.Start();


            if (Ball.IntersectsWith(BrickThree))
            {

                
                BrickThree = new Rectangle(0, 0, 0, 0);
                Score = Score + 10;
            }
            else
                tmrOne.Start();


            if (Ball.IntersectsWith(BrickFour))
            {

                
                BrickFour = new Rectangle(0, 0, 0, 0);
                Score = Score + 10;
            }
            else
                tmrOne.Start();


            if (Ball.IntersectsWith(BrickFive))
            {

                
                BrickFive = new Rectangle(0, 0, 0, 0);
                Score = Score + 10;


            }
            tmrOne.Start();


            if (Ball.IntersectsWith(BrickSix))
            {

                BrickSix = new Rectangle(0, 0, 0, 0);
                Score = Score + 10;
                
            }
            else
                tmrOne.Start();


            if (Ball.IntersectsWith(BrickSeven))
            {

                BrickSeven = new Rectangle(0, 0, 0, 0);
                Score = Score + 10;
                
            }
            else
                tmrOne.Start();


            if (Ball.IntersectsWith(BrickEight))
            {

                BrickEight = new Rectangle(0, 0, 0, 0);
                Score = Score + 10;
                
            }
            tmrOne.Start();

            if (Ball.IntersectsWith(BrickNine))
            {

                BrickNine = new Rectangle(0, 0, 0, 0);
                Score = Score + 10;
                

            }
            else
                tmrOne.Start();



            if (Ball.IntersectsWith(BrickTen))
            {

                BrickTen = new Rectangle(0, 0, 0, 0);
                Score = Score + 10;
                

            }
            else
                tmrOne.Start();


            if (Ball.IntersectsWith(BrickEleven))
            {

                BrickEleven = new Rectangle(0, 0, 0, 0);
                Score = Score + 10;
                

            }
            else
                tmrOne.Start();


            if (Ball.IntersectsWith(BrickTwelve))
            {

                BrickTwelve = new Rectangle(0, 0, 0, 0);
                Score = Score + 10;
                

            }
            else
                tmrOne.Start();

                    }
    

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void tmrOne_Tick(object sender, EventArgs e)
        {
            // Paddle.X = Cursor.Position.X - (Paddle.Width / 2);  //set the mouse cursor to the centre of the paddle


            Ball.X += speed_left;
            Ball.Y += speed_top;

            if (Ball.Bottom >= Paddle.Top && Ball.Bottom <= Paddle.Bottom && Ball.Left >= Paddle.Left && Ball.Right <= Paddle.Right)
          // collision check of paddle and ball  
            {
                speed_top += 4;
                speed_left += 4;
                speed_top = -speed_top; //ball bounce off
            }

            

            if (Ball.Left <= pnlGame.Left)
            {
                speed_left = -speed_left;

            }

            if (Ball.Right >= pnlGame.Right)
            {
                speed_left = -speed_left;

            }

            if (Ball.Top <= pnlGame.Top)
            {
                speed_top = -speed_top;

            }

            if (Ball.Bottom >= pnlGame.Bottom)
            {
                tmrOne.Stop();
                lblLose.Visible = true;
                picThumbsdwn.Visible = true;
                pnlGame.BackColor = Color.Aqua;

                                             
            }

            pnlGame.Invalidate();

            if (Score == 120)
            {
                tmrOne.Stop();
                Ball = new Rectangle(0, 0, 0, 0);
                lblWin.Visible = true;
                picThumbsup.Visible = true;
                
            }
                   
            
            
        }

        

        
        private void btnPause_Click_1(object sender, EventArgs e)
        {
            tmrOne.Stop();


        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            tmrOne.Start();

        }

        private void btnEnd_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmBreakout_Load(object sender, EventArgs e)
        {

        }

        private void pnlGame_MouseMove(object sender, MouseEventArgs e)
        {
            
            Paddle.X = e.X;
            pnlGame.Invalidate();

        }

        private void FrmBreakout_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.P:
                    tmrOne.Stop();
                    break;

                case Keys.S:
                    tmrOne.Start();
                    break;

                case Keys.Escape:
                    this.Close();
                    break;

                /**case Keys.F1:
                    Ball.X = 420;
                    Ball.Y = 400;
                    speed_left = 7;
                    speed_top = 7;
                    Score = 0;
                    tmrOne.Start();
                    lblLose.Visible = false;
                    lblWin.Visible = false;
                    break;**/



            }


                              
        }

        
        }

        

        




    }




