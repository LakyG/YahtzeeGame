using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeGame
{
    public partial class Game : Form
    {
        static Random rand = new Random();
        static int currRoll = 1;
        static int currPlayer = 1;
        static bool enableSave = false;
        static int die1, die2, die3, die4, die5; //values of the dice
        static int numYahtzees1 = 0;
        static int numYahtzees2 = 0;

        static int ones, twos, threes, fours, fives, sixes; //the number of ones, twos, etc.
        static int bonus1, kind3, kind4, full, Sm, Lg, chance, Yah; //scores for each of the lower scores
        static int bonus2;
        //, kind32, kind42, full2, Sm2, Lg2, chance2, Yah2; //scores for each of the lower scores
        static int subtotal1 = 0; //subtotal1 of all the ones, twos, etc.
        static int subtotal2 = 0; //subtotal2 of all the ones, twos, etc.
        static int total = 0; //total of all scores

        int[] vals = new int[5];

        private void lbl23_Click(object sender, EventArgs e)
        {
            UpdateLabel(sender, 3);
        }

        private void lbl24_Click(object sender, EventArgs e)
        {
            UpdateLabel(sender, 4);
        }

        private void lbl25_Click(object sender, EventArgs e)
        {
            UpdateLabel(sender, 5);
        }

        private void lbl26_Click(object sender, EventArgs e)
        {
            UpdateLabel(sender, 6);
        }

        private void lblDie3_Click(object sender, EventArgs e)
        {
            toggleDice(sender);
        }

        private void lblDie4_Click(object sender, EventArgs e)
        {
            toggleDice(sender);
        }

        private void lblDie5_Click(object sender, EventArgs e)
        {
            toggleDice(sender);
        }

        private void lblDie2_Click(object sender, EventArgs e)
        {
            toggleDice(sender);
        }

        private void lblDie1_Click(object sender, EventArgs e)
        {
            toggleDice(sender);
        }

        private void lbl16_Click(object sender, EventArgs e)
        {
            UpdateLabel(sender, 6);
        }

        private void lbl15_Click(object sender, EventArgs e)
        {
            UpdateLabel(sender, 5);
        }

        private void Game_Shown(object sender, EventArgs e)
        {
            btnRoll_Click(null, null);
        }

        private void lbl13K_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < vals.Length; i++)
            {
                //Console.WriteLine(i);
                if (ones >= 3 || twos >= 3 || threes >= 3 || fours >= 3 || fives >= 3 || sixes >= 3)
                {
                    UpdateLabel(sender, 8);
                    return;
                }
            }

            UpdateLabel(sender, 0);
            //lblMsgs.Text = "Oops. No 3 of a Kind.";
        }

        private void lbl14_Click(object sender, EventArgs e)
        {
            UpdateLabel(sender, 4);
        }

        private void lbl21_Click(object sender, EventArgs e)
        {
            UpdateLabel(sender, 1);
        }

        private void lbl22_Click(object sender, EventArgs e)
        {
            UpdateLabel(sender, 2);
        }

        private void lbl23K_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                //Console.WriteLine(i);
                if (ones >= 3 || twos >= 3 || threes >= 3 || fours >= 3 || fives >= 3 || sixes >= 3)
                {
                    UpdateLabel(sender, 8);
                    return;
                }
            }

            UpdateLabel(sender, 0);
        }

        private void lbl24K_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                //Console.WriteLine(i);
                if (ones >= 4 || twos >= 4 || threes >= 4 || fours >= 4 || fives >= 4 || sixes >= 4)
                {
                    UpdateLabel(sender, 9);
                    return;
                }
            }

            UpdateLabel(sender, 0);
        }

        private void lbl2Full_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                //Console.WriteLine(i);
                if (ones == 3 || twos == 3 || threes == 3 || fours == 3 || fives == 3 || sixes == 3)
                {
                    if (ones == 2 || twos == 2 || threes == 2 || fours == 2 || fives == 2 || sixes == 2)
                        UpdateLabel(sender, 10);
                    return;
                }
            }

            UpdateLabel(sender, 0);
        }

        private void lbl2Sm_Click(object sender, EventArgs e)
        {
            int temp;
            for (int i = 0; i < vals.Length - 2; i++)
            {
                if (vals[i] == vals[i + 1])
                {
                    temp = vals[i + 1];
                    Array.Copy(vals, i + 2, vals, i + 1, 3 - i);
                    vals[4] = temp;
                }
            }

            if (vals[0] == 1 && vals[1] == 2 && vals[2] == 3 && vals[3] == 4)
            {
                UpdateLabel(sender, 11);
            }
            else if (vals[0] == 2 && vals[1] == 3 && vals[2] == 4 && vals[3] == 5)
            {
                UpdateLabel(sender, 11);
            }
            else if (vals[0] == 3 && vals[1] == 4 && vals[2] == 5 && vals[3] == 6)
            {
                UpdateLabel(sender, 11);
            }
            else
            {
                UpdateLabel(sender, 0);
            }
        }

        private void lbl2Lg_Click(object sender, EventArgs e)
        {
            if (vals[0] == 1 && vals[1] == 2 && vals[2] == 3 && vals[3] == 4 && vals[4] == 5)
            {
                UpdateLabel(sender, 12);
            }
            else if (vals[0] == 2 && vals[1] == 3 && vals[2] == 4 && vals[3] == 5 && vals[4] == 6)
            {
                UpdateLabel(sender, 12);
            }
            else
            {
                UpdateLabel(sender, 0);
            }
        }

        private void lbl2Chan_Click(object sender, EventArgs e)
        {
            UpdateLabel(sender, 13);
        }

        private void lbl2Yah_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                //Console.WriteLine(i);
                if (ones == 5 || twos == 5 || threes == 5 || fours == 5 || fives == 5 || sixes == 5)
                {
                    UpdateLabel(sender, 14);
                    return;
                }
            }
            UpdateLabel(sender, 0);
        }

        private void lbl14K_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                //Console.WriteLine(i);
                if (ones >= 4 || twos >= 4 || threes >= 4 || fours >= 4 || fives >= 4 || sixes >= 4)
                {
                    UpdateLabel(sender, 9);
                    return;
                }
            }

            UpdateLabel(sender, 0);
            //lblMsgs.Text = "Oops. No 4 of a Kind.";
        }

        private void lbl1Full_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                //Console.WriteLine(i);
                if (ones == 3 || twos == 3 || threes == 3 || fours == 3 || fives == 3 || sixes == 3)
                {
                    if(ones == 2 || twos == 2 || threes == 2 || fours == 2 || fives == 2 || sixes == 2)
                    UpdateLabel(sender, 10);
                    return;
                }
            }

            UpdateLabel(sender, 0);
            //lblMsgs.Text = "Oops. No full1 House.";
        }

        private void lbl1Sm_Click(object sender, EventArgs e)
        {
            int temp;
            for (int i = 0; i < vals.Length - 2; i++)
            {
                if(vals[i] == vals[i + 1])
                {
                    temp = vals[i + 1];
                    Array.Copy(vals, i + 2, vals, i + 1, 3 - i);
                    vals[4] = temp;
                }
            }

            if (vals[0] == 1 && vals[1] == 2 && vals[2] == 3 && vals[3] == 4)
            {
                UpdateLabel(sender, 11);
            }
            else if(vals[0] == 2 && vals[1] == 3 && vals[2] == 4 && vals[3] == 5)
            {
                UpdateLabel(sender, 11);
            }
            else if (vals[0] == 3 && vals[1] == 4 && vals[2] == 5 && vals[3] == 6)
            {
                UpdateLabel(sender, 11);
            }
            else
            {
                UpdateLabel(sender, 0);
            }
        }

        private void lbl1Lg_Click(object sender, EventArgs e)
        {
            if (vals[0] == 1 && vals[1] == 2 && vals[2] == 3 && vals[3] == 4 && vals[4] == 5)
            {
                UpdateLabel(sender, 12);
            }
            else if (vals[0] == 2 && vals[1] == 3 && vals[2] == 4 && vals[3] == 5 && vals[4] == 6)
            {
                UpdateLabel(sender, 12);
            }
            else
            {
                UpdateLabel(sender, 0);
            }
        }

        private void lbl1Chan_Click(object sender, EventArgs e)
        {
            UpdateLabel(sender, 13);
        }

        private void lbl1Yah_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                //Console.WriteLine(i);
                if (ones == 5 || twos == 5|| threes == 5 || fours == 5 || fives == 5 || sixes == 5)
                {
                    UpdateLabel(sender, 14);
                    return;
                }
            }
            UpdateLabel(sender, 0);
        }

        private void lbl13_Click(object sender, EventArgs e)
        {
            UpdateLabel(sender, 3);
        }

        private void lbl12_Click(object sender, EventArgs e)
        {
            UpdateLabel(sender, 2);
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            UpdateLabel(sender, 1);
        }

        //Constructor for this class
        public Game()
        {
            InitializeComponent();
            bonus1 = kind3 = kind4 = full = Sm = Lg = chance = Yah = 0;
            bonus2 = 0;
            //kind32 = kind42 = full2 = Sm2 = Lg2 = chance2 = Yah2 = 0;
            setPlayer();
            MakeLabelRounded(lblDie1);
            MakeLabelRounded(lblDie2);
            MakeLabelRounded(lblDie3);
            MakeLabelRounded(lblDie4);
            MakeLabelRounded(lblDie5);

            MakeLabelRounded(btnRoll);
            MakeLabelRounded(btnKeepScore);
        }

        void toggleDice(object sender)
        {
            Label lbl = sender as Label;
            
            if (lbl.BackColor == Color.White)
            {
                lbl.BackColor = Color.LightGray;
            }
            else if (lbl.BackColor == Color.LightGray)
            {
                lbl.BackColor = Color.White;
            }
        }
        
        private void btnRoll_Click(object sender, EventArgs e)
        {
            lblMsgs.Text = "";
            if (enableSave == true)
            {
                lblMsgs.Text = "Please save your score first by clicking \"Keep Score\"";
                return;
            }
            if(currRoll >= 4)
            {
                lblMsgs.Text = "You can only re-roll 3 times. Click \"Keep Score\"";
                return;
            }

            ones = twos = threes = fours = fives = sixes = 0;
            currRoll++;

            if (lblDie1.BackColor == Color.White) { die1 = rand.Next(1, 7); }
            if (lblDie2.BackColor == Color.White) { die2 = rand.Next(1, 7); }
            if (lblDie3.BackColor == Color.White) { die3 = rand.Next(1, 7); }
            if (lblDie4.BackColor == Color.White) { die4 = rand.Next(1, 7); }
            if (lblDie5.BackColor == Color.White) { die5 = rand.Next(1, 7); }

            lblDie1.Text = die1.ToString();
            lblDie2.Text = die2.ToString();
            lblDie3.Text = die3.ToString();
            lblDie4.Text = die4.ToString();
            lblDie5.Text = die5.ToString();

            vals[0] = die1;
            vals[1] = die2;
            vals[2] = die3;
            vals[3] = die4;
            vals[4] = die5;

            Array.Sort(vals);

            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == 1) { ones++; }
                else if (vals[i] == 2) { twos++; }
                else if (vals[i] == 3) { threes++; }
                else if (vals[i] == 4) { fours++; }
                else if (vals[i] == 5) { fives++; }
                else if (vals[i] == 6) { sixes++; }
            }
        }

        private void btnKeepScore_Click(object sender, EventArgs e)
        {
            //Reset variables
            lblMsgs.Text = "";
            currRoll = 1;
            //lblDie1.Text = "";
            //lblDie2.Text = "";
            //lblDie3.Text = "";
            //lblDie4.Text = "";
            //lblDie5.Text = "";
            lblMsgs.Text = "Please click where you want to save the score";
            enableSave = true;
        }

        public void UpdateLabel(object sender, int type)
        {
            Label lbl = sender as Label;
            //string lblName = lbl.Text;
            if(lbl.Text != "-" && !lbl.Name.Contains("Yah"))
            {
                lblMsgs.Text = "Oops! You've already scored for this one";
                return;
            }
            if(lbl.Text == "0" && lbl.Name.Contains("Yah"))
            {
                lblMsgs.Text = "Oops! You've already scored for this one";
                return;
            }

            if(enableSave != true)
            {
                lblMsgs.Text = "Please click \"Keep Score\" to save your score";
                return;
            }

            enableSave = false;
            int currScore = 0;

            int diceTotal = ones + (twos * 2) + (threes * 3) + (fours * 4) + (fives * 5) + (sixes * 6);

            //reset for next player
            kind3 = kind4 = full = Sm = Lg = chance = Yah = 0;

            switch (type)
            {
                case 0: //score of zero
                    currScore = 0;
                    break;
                case 1: //seelct ones
                    currScore = ones;
                    break;
                case 2: //select twos
                    currScore = (twos * 2);
                    break;
                case 3: //select threes
                    currScore = (threes * 3);
                    break;
                case 4: //select fours
                    currScore = (fours * 4);
                    break;
                case 5: //select fives
                    currScore = (fives * 5);
                    break;
                case 6: //select sixes
                    currScore = (sixes * 6);
                    break;
                case 8: //select 3 of a kind
                    kind3 = diceTotal;
                    currScore = kind3;
                    break;
                case 9: //select 4 of a kind
                    kind4 = diceTotal;
                    currScore = kind4;
                    break;
                case 10: //select full1 house
                    full = 25;
                    currScore = full;
                    break;
                case 11:  //select small straight
                    Sm = 30;
                    currScore = Sm;
                    break;
                case 12: //select large straight
                    Lg = 40;
                    currScore = Lg;
                    break;
                case 13: //select chance1
                    chance = diceTotal;
                    currScore = chance;
                    break;
                case 14: //select yahtzee
                    if (currPlayer % 2 == 0)
                    {
                        if (numYahtzees2 == 0)
                        {
                            numYahtzees2++;
                            Yah = 50;
                            currScore = Yah;
                        }
                        else if (numYahtzees2 > 0)
                        {
                            numYahtzees2++;
                            Yah = 100;
                            currScore = Yah;
                        }
                    }
                    else
                    {
                        if (numYahtzees1 == 0)
                        {
                            numYahtzees1++;
                            Yah = 50;
                            currScore = Yah;
                        }
                        else if (numYahtzees1 > 0)
                        {
                            numYahtzees1++;
                            Yah = 100;
                            currScore = Yah;
                        }
                    }
                    break;
            }

            if(type == 14)
            {
                int prevScore = 0;
                int.TryParse(lbl.Text, out prevScore);
                currScore += prevScore;
            }

            lbl.Text = currScore.ToString();

            lblMsgs.Text = "";

            lblDie1.BackColor = Color.White;
            lblDie2.BackColor = Color.White;
            lblDie3.BackColor = Color.White;
            lblDie4.BackColor = Color.White;
            lblDie5.BackColor = Color.White;

            if (lbl.Name.Length == 5)
            {
                if (currPlayer % 2 == 0)
                {
                    subtotal2 += currScore;
                    lbl2subtot.Text = subtotal2.ToString();
                }
                else
                {
                    subtotal1 += currScore;
                    lbl1subtot.Text = subtotal1.ToString();
                }
                updatebonus();
            }

            if (currPlayer % 2 == 0)
            {
                //total = subtotal2 + bonus2 + kind3 + kind4 + full + Sm + Lg + chance + Yah;
                total = 0;
                foreach (int i in Enumerable.Range(7,8))
                {
                    int.TryParse(pnlScores.GetControlFromPosition(2, i).Text, out int subtot);
                    total += subtot;
                }
                lbl2Tot.Text = total.ToString();
            }
            else
            {
                //total = subtotal1 + bonus1 + kind3 + kind4 + full + Sm + Lg + chance + Yah;
                total = 0;
                foreach (int i in Enumerable.Range(7, 8))
                {
                    int.TryParse(pnlScores.GetControlFromPosition(1, i).Text, out int subtot);
                    total += subtot;
                }

                lbl1Tot.Text = total.ToString();
            }

            currPlayer++;
            
            //Check if the game has ended

            setPlayer();

            btnRoll_Click(null, null);

            if (currPlayer >= 27)
            {
                int.TryParse(lbl1Tot.Text, out int tot1);
                int.TryParse(lbl2Tot.Text, out int tot2);

                string msg;

                if (tot1 > tot2)
                {
                    msg = "Player 1 Wins!";
                    
                }
                else if (tot1 < tot2)
                {
                    msg = "Player 2 Wins!";
                }
                else
                {
                    msg = "It's a Draw!";
                }

                msg += "\nWould you like to play again?";

                var popup = new EndGameDialogue(msg);

                popup.Show();
                
            }
        }

        private void updatebonus()
        {
            if(subtotal1 >= 63)
            {
                bonus1 = 35;
                lbl1Bon.Text = bonus1.ToString();
            }
            if(subtotal2 >= 63)
            {
                bonus2 = 35;
                lbl2Bon.Text = bonus2.ToString();
            }
        }

        private void setPlayer()
        {
            if (currPlayer % 2 == 0) //Player 2's turn
            {
                lblP1.BackColor = Color.SteelBlue;
                lblP2.BackColor = Color.Khaki;

                for (int i = 0; i < pnlScores.RowCount; i++)
                {
                    pnlScores.GetControlFromPosition(1, i).Enabled = false;
                    pnlScores.GetControlFromPosition(2, i).Enabled = true;
                }
            }
            else //Player 1's turn
            {
                lblP1.BackColor = Color.Khaki;
                lblP2.BackColor = Color.SteelBlue;


                for (int i = 0; i < pnlScores.RowCount; i++)
                {
                    pnlScores.GetControlFromPosition(1, i).Enabled = true;
                    pnlScores.GetControlFromPosition(2, i).Enabled = false;
                }
            }
        }

        public void MakeLabelRounded(Label lbl)
        {
            int radius = 10;
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle bounds = new Rectangle(0, 0, lbl.Width, lbl.Height);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            //top left arc
            path.AddArc(arc, 180, 90);

            //top right arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            lbl.Region = new System.Drawing.Region(path);
            lbl.Invalidate();
        }

        public void MakeLabelRounded(Button btn)
        {
            int radius = 20;
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle bounds = new Rectangle(0, 0, btn.Width, btn.Height);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            //top left arc
            path.AddArc(arc, 180, 90);

            //top right arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            btn.Region = new System.Drawing.Region(path);
            btn.Invalidate();
        }
    }
}
