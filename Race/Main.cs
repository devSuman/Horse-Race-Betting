using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Media;

namespace Race
{
    public partial class Form1 : MetroForm
    {
        /// <summary>
        /// Fields Declaration
        /// </summary>

        decimal Balance = 500;
        decimal Bet = 10;
        List<MetroRadioButton> Choice = new List<MetroRadioButton>();
        List<MetroProgressBar> Tracks = new List<MetroProgressBar>();
        Timer FadeTimer = new Timer();
        Timer RaceTimer = new Timer();
        Random RNG = new Random();

        public Form1()
        {
            /// <summary>
            /// Form and List Fields Initializtion
            /// </summary>

            InitializeComponent();

            Message.Visible = false;
            FadeTimer.Interval = 2500;
            FadeTimer.Tick += FadeTime_Tick;
            RaceTimer.Interval = 200;
            RaceTimer.Tick += RaceTimer_Tick;

            Choice.Add(FirstChoice); Choice.Add(SecondChoice); Choice.Add(ThirdChoice); Choice.Add(FourthChoice); Choice.Add(FifthChoice);
            Choice.Add(SixthChoice); Choice.Add(SeventhChoice); Choice.Add(EightChoice); Choice.Add(NinthChoice); Choice.Add(TenthChoice);

            Tracks.Add(First); Tracks.Add(Second); Tracks.Add(Third); Tracks.Add(Fourth); Tracks.Add(Fifth);
            Tracks.Add(Sixth); Tracks.Add(Seventh); Tracks.Add(Eight); Tracks.Add(Ninth); Tracks.Add(Tenth);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Main work of the program
            /// </summary>    

            try
            {

                /// <summary>
                /// Main function is executed if Start.Text is set to "Start"
                /// </summary>

                if (Start.Text.Equals("Start"))
                {
                    //Invalid bet selection check

                    if (Bet > Balance) 
                    {
                        Message.Text = "You have insufficient balance!";
                        Message.Visible = true;
                    }

                    //Invalid choice selection check

                    else if (Choice.All(c => c.Checked == false)) 
                    {
                        Message.Text = "Please select a track to bet on.";
                        Message.Visible = true;
                    }

                    //If there is no error, then proceed with execution

                    else 
                    {
                        Start.Enabled = false;
                        foreach (var c in Choice)
                            c.Enabled = false;
                        RaceTimer.Start();
                        Start.Text = "Reset";
                        BetChoice.Enabled = false;
                        HorseChoice.Text = CurrentChoice();
                    }
                }

                /// <summary>
                /// Reset function is executed if Start.Text is set to "Reset"
                /// </summary>

                else
                {
                    if (Balance > 10)
                    {

                        foreach (var track in Tracks)
                            track.Value = track.Minimum;

                        foreach (var choice in Choice)
                        {
                            choice.Enabled = true;
                            choice.Checked = false;
                        }

                        Winner.Text = HorseChoice.Text = "N/A";
                        Start.Text = "Start";
                        BetChoice.Enabled = true;
                    }
                    else
                    {
                        Message.Text = "GAME OVER";
                        Message.Visible = true;
                    }
                }
            }
            catch(Exception ex)
            {
                Message.Text = ex.Message;
            }
        }

        void RaceTimer_Tick(object sender, EventArgs e)
        {

            /// <summary>
            /// Executes the race
            /// </summary>

            if (!(Tracks.Any(t => t.Value == t.Maximum)))
            {
                foreach (var track in Tracks)
                {
                    if (!(Tracks.Any(t => t.Value == t.Maximum)))
                    {
                        track.Increment(RNG.Next(1, 4));
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                Start.Enabled = true;
                RaceTimer.Stop();
                WinnerCheck();
            }
        }

        private void WinnerCheck()
        {

            /// <summary>
            /// This method is used to check whether the player has won or lost the bet
            /// </summary>

            try
            {
                var choice = Choice.Single(c => c.Checked == true);
                var winTrack = Tracks.Single(t => t.Value == t.Maximum);

                if (choice.Name.ToString().Replace("Choice", string.Empty).Equals(winTrack.Name.ToString()))
                {
                    Transaction(Bet, true);
                    Message.Text = "Congratulation! You have won the bet!";

                    using (SoundPlayer player = new SoundPlayer(Resource1.Win))
                    {
                        player.Play();
                    }
                }
                else
                {
                    Transaction(Bet, false);
                    Message.Text = "Unfortunately, you have lost the bet.";

                    using (SoundPlayer player = new SoundPlayer(Resource1.Lost))
                    {
                        player.Play();
                    }
                }

                Message.Visible = true;
                Winner.Text = string.Format("{0} ({1})", winTrack.Tag, (winTrack.TabIndex + 1));
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
            }
        }

        private void Transaction(decimal bet, bool win)
        {

            /// <summary>
            /// This method is used to process transaction, i.e. addition and substraction of bet from total balance, based on race result
            /// </summary>

            if (win)
            {
                Balance += bet;
            }
            else
            {
                Balance -= bet;
            }
            BalanceView.Text = string.Format("${0:0.00}", Balance);
        }

        private string CurrentChoice()
        {
            //Returns current track/horse choice with proper formatting

            var choice = Tracks.Single(t=>t.Name == ((Choice.Single(c=>c.Checked==true).Name.Replace("Choice",string.Empty))));

            return string.Format(choice.Tag + " (" + (choice.TabIndex + 1) + ")");
        }

        private void BetChoice_ValueChanged(object sender, EventArgs e)
        {
            //Controls bet with the BetChoice slider

            switch (BetChoice.Value)
            {
                case 0: Bet = 10; break;
                case 1: Bet = 25; break;
                case 2: Bet = 50; break;
                case 3: Bet = 100; break;
                case 4: Bet = 250; break;
                case 5: Bet = 500; break;
                case 6: Bet = 750; break;
                case 7: Bet = 1000; break;
                case 8: Bet = 1250; break;
                case 9: Bet = 1500; break;
                case 10: Bet = 1750; break;
                case 11: Bet = 2000; break;
                case 12: Bet = 2500; break;
                case 13: Bet = 3000; break;
                case 14: Bet = 5000; break;
                case 15: Bet = 10000; break;
            }

            BetView.Text = string.Format("${0:0.00}", Bet);
        }

        void FadeTime_Tick(object sender, EventArgs e)
        {
            //Timer to handle the Message label's fading after showing the required message

            if (Message.Visible)
            {
                FadeTimer.Stop();
                Message.Visible = false;
            }
        }

        private void Message_VisibleChanged(object sender, EventArgs e)
        {
            //An event to handle Message fading

            if (Message.Visible)
                FadeTimer.Start();
        }
    }
}
