namespace Race
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
            this.First = new MetroFramework.Controls.MetroProgressBar();
            this.Second = new MetroFramework.Controls.MetroProgressBar();
            this.Third = new MetroFramework.Controls.MetroProgressBar();
            this.Fourth = new MetroFramework.Controls.MetroProgressBar();
            this.Fifth = new MetroFramework.Controls.MetroProgressBar();
            this.Sixth = new MetroFramework.Controls.MetroProgressBar();
            this.Seventh = new MetroFramework.Controls.MetroProgressBar();
            this.Eight = new MetroFramework.Controls.MetroProgressBar();
            this.Ninth = new MetroFramework.Controls.MetroProgressBar();
            this.Tenth = new MetroFramework.Controls.MetroProgressBar();
            this.Start = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BetView = new MetroFramework.Controls.MetroLabel();
            this.BalanceView = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.BetChoice = new MetroFramework.Controls.MetroTrackBar();
            this.FirstChoice = new MetroFramework.Controls.MetroRadioButton();
            this.SecondChoice = new MetroFramework.Controls.MetroRadioButton();
            this.FourthChoice = new MetroFramework.Controls.MetroRadioButton();
            this.ThirdChoice = new MetroFramework.Controls.MetroRadioButton();
            this.SixthChoice = new MetroFramework.Controls.MetroRadioButton();
            this.FifthChoice = new MetroFramework.Controls.MetroRadioButton();
            this.EightChoice = new MetroFramework.Controls.MetroRadioButton();
            this.SeventhChoice = new MetroFramework.Controls.MetroRadioButton();
            this.TenthChoice = new MetroFramework.Controls.MetroRadioButton();
            this.NinthChoice = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Winner = new MetroFramework.Controls.MetroLabel();
            this.Message = new MetroFramework.Controls.MetroLabel();
            this.HorseChoice = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // First
            // 
            this.First.Location = new System.Drawing.Point(64, 76);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(1193, 36);
            this.First.TabIndex = 0;
            this.First.Tag = "Arrow";
            // 
            // Second
            // 
            this.Second.Location = new System.Drawing.Point(64, 118);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(1193, 36);
            this.Second.TabIndex = 1;
            this.Second.Tag = "Barsil";
            // 
            // Third
            // 
            this.Third.Location = new System.Drawing.Point(64, 160);
            this.Third.Name = "Third";
            this.Third.Size = new System.Drawing.Size(1193, 36);
            this.Third.TabIndex = 2;
            this.Third.Tag = "Dagger";
            // 
            // Fourth
            // 
            this.Fourth.Location = new System.Drawing.Point(64, 202);
            this.Fourth.Name = "Fourth";
            this.Fourth.Size = new System.Drawing.Size(1193, 36);
            this.Fourth.TabIndex = 3;
            this.Fourth.Tag = "Faxis";
            // 
            // Fifth
            // 
            this.Fifth.Location = new System.Drawing.Point(64, 244);
            this.Fifth.Name = "Fifth";
            this.Fifth.Size = new System.Drawing.Size(1193, 36);
            this.Fifth.TabIndex = 4;
            this.Fifth.Tag = "Gazer";
            // 
            // Sixth
            // 
            this.Sixth.Location = new System.Drawing.Point(64, 286);
            this.Sixth.Name = "Sixth";
            this.Sixth.Size = new System.Drawing.Size(1193, 36);
            this.Sixth.TabIndex = 5;
            this.Sixth.Tag = "Jebler";
            // 
            // Seventh
            // 
            this.Seventh.Location = new System.Drawing.Point(64, 328);
            this.Seventh.Name = "Seventh";
            this.Seventh.Size = new System.Drawing.Size(1193, 36);
            this.Seventh.TabIndex = 6;
            this.Seventh.Tag = "Marvel";
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(64, 370);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(1193, 36);
            this.Eight.TabIndex = 7;
            this.Eight.Tag = "Rapid";
            // 
            // Ninth
            // 
            this.Ninth.Location = new System.Drawing.Point(64, 412);
            this.Ninth.Name = "Ninth";
            this.Ninth.Size = new System.Drawing.Size(1193, 36);
            this.Ninth.TabIndex = 8;
            this.Ninth.Tag = "Saber";
            // 
            // Tenth
            // 
            this.Tenth.Location = new System.Drawing.Point(64, 454);
            this.Tenth.Name = "Tenth";
            this.Tenth.Size = new System.Drawing.Size(1193, 36);
            this.Tenth.TabIndex = 9;
            this.Tenth.Tag = "Zephyr";
            // 
            // Start
            // 
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Location = new System.Drawing.Point(23, 514);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 10;
            this.Start.Text = "Start";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 555);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Current Bet:";
            // 
            // BetView
            // 
            this.BetView.AutoSize = true;
            this.BetView.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.BetView.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.BetView.Location = new System.Drawing.Point(23, 574);
            this.BetView.Name = "BetView";
            this.BetView.Size = new System.Drawing.Size(66, 25);
            this.BetView.TabIndex = 12;
            this.BetView.Text = "$10.00";
            this.BetView.UseStyleColors = true;
            // 
            // BalanceView
            // 
            this.BalanceView.AutoSize = true;
            this.BalanceView.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.BalanceView.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.BalanceView.Location = new System.Drawing.Point(23, 634);
            this.BalanceView.Name = "BalanceView";
            this.BalanceView.Size = new System.Drawing.Size(76, 25);
            this.BalanceView.TabIndex = 14;
            this.BalanceView.Text = "$500.00";
            this.BalanceView.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 615);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Total Balance:";
            // 
            // BetChoice
            // 
            this.BetChoice.BackColor = System.Drawing.Color.Transparent;
            this.BetChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BetChoice.LargeChange = 1;
            this.BetChoice.Location = new System.Drawing.Point(132, 555);
            this.BetChoice.Maximum = 15;
            this.BetChoice.Name = "BetChoice";
            this.BetChoice.Size = new System.Drawing.Size(429, 23);
            this.BetChoice.TabIndex = 15;
            this.BetChoice.Text = "Bet Choice";
            this.BetChoice.Value = 0;
            this.BetChoice.ValueChanged += new System.EventHandler(this.BetChoice_ValueChanged);
            // 
            // FirstChoice
            // 
            this.FirstChoice.AutoSize = true;
            this.FirstChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FirstChoice.Location = new System.Drawing.Point(23, 87);
            this.FirstChoice.Name = "FirstChoice";
            this.FirstChoice.Size = new System.Drawing.Size(26, 15);
            this.FirstChoice.TabIndex = 16;
            this.FirstChoice.TabStop = true;
            this.FirstChoice.Text = " ";
            this.FirstChoice.UseVisualStyleBackColor = true;
            // 
            // SecondChoice
            // 
            this.SecondChoice.AutoSize = true;
            this.SecondChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SecondChoice.Location = new System.Drawing.Point(23, 129);
            this.SecondChoice.Name = "SecondChoice";
            this.SecondChoice.Size = new System.Drawing.Size(26, 15);
            this.SecondChoice.TabIndex = 17;
            this.SecondChoice.TabStop = true;
            this.SecondChoice.Text = " ";
            this.SecondChoice.UseVisualStyleBackColor = true;
            // 
            // FourthChoice
            // 
            this.FourthChoice.AutoSize = true;
            this.FourthChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FourthChoice.Location = new System.Drawing.Point(23, 213);
            this.FourthChoice.Name = "FourthChoice";
            this.FourthChoice.Size = new System.Drawing.Size(26, 15);
            this.FourthChoice.TabIndex = 19;
            this.FourthChoice.TabStop = true;
            this.FourthChoice.Text = " ";
            this.FourthChoice.UseVisualStyleBackColor = true;
            // 
            // ThirdChoice
            // 
            this.ThirdChoice.AutoSize = true;
            this.ThirdChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThirdChoice.Location = new System.Drawing.Point(23, 171);
            this.ThirdChoice.Name = "ThirdChoice";
            this.ThirdChoice.Size = new System.Drawing.Size(26, 15);
            this.ThirdChoice.TabIndex = 18;
            this.ThirdChoice.TabStop = true;
            this.ThirdChoice.Text = " ";
            this.ThirdChoice.UseVisualStyleBackColor = true;
            // 
            // SixthChoice
            // 
            this.SixthChoice.AutoSize = true;
            this.SixthChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SixthChoice.Location = new System.Drawing.Point(23, 295);
            this.SixthChoice.Name = "SixthChoice";
            this.SixthChoice.Size = new System.Drawing.Size(26, 15);
            this.SixthChoice.TabIndex = 21;
            this.SixthChoice.TabStop = true;
            this.SixthChoice.Text = " ";
            this.SixthChoice.UseVisualStyleBackColor = true;
            // 
            // FifthChoice
            // 
            this.FifthChoice.AutoSize = true;
            this.FifthChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FifthChoice.Location = new System.Drawing.Point(23, 253);
            this.FifthChoice.Name = "FifthChoice";
            this.FifthChoice.Size = new System.Drawing.Size(26, 15);
            this.FifthChoice.TabIndex = 20;
            this.FifthChoice.TabStop = true;
            this.FifthChoice.Text = " ";
            this.FifthChoice.UseVisualStyleBackColor = true;
            // 
            // EightChoice
            // 
            this.EightChoice.AutoSize = true;
            this.EightChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EightChoice.Location = new System.Drawing.Point(23, 379);
            this.EightChoice.Name = "EightChoice";
            this.EightChoice.Size = new System.Drawing.Size(26, 15);
            this.EightChoice.TabIndex = 23;
            this.EightChoice.TabStop = true;
            this.EightChoice.Text = " ";
            this.EightChoice.UseVisualStyleBackColor = true;
            // 
            // SeventhChoice
            // 
            this.SeventhChoice.AutoSize = true;
            this.SeventhChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeventhChoice.Location = new System.Drawing.Point(23, 337);
            this.SeventhChoice.Name = "SeventhChoice";
            this.SeventhChoice.Size = new System.Drawing.Size(26, 15);
            this.SeventhChoice.TabIndex = 22;
            this.SeventhChoice.TabStop = true;
            this.SeventhChoice.Text = " ";
            this.SeventhChoice.UseVisualStyleBackColor = true;
            // 
            // TenthChoice
            // 
            this.TenthChoice.AutoSize = true;
            this.TenthChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TenthChoice.Location = new System.Drawing.Point(23, 463);
            this.TenthChoice.Name = "TenthChoice";
            this.TenthChoice.Size = new System.Drawing.Size(26, 15);
            this.TenthChoice.TabIndex = 25;
            this.TenthChoice.TabStop = true;
            this.TenthChoice.Text = " ";
            this.TenthChoice.UseVisualStyleBackColor = true;
            // 
            // NinthChoice
            // 
            this.NinthChoice.AutoSize = true;
            this.NinthChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NinthChoice.Location = new System.Drawing.Point(23, 421);
            this.NinthChoice.Name = "NinthChoice";
            this.NinthChoice.Size = new System.Drawing.Size(26, 15);
            this.NinthChoice.TabIndex = 24;
            this.NinthChoice.TabStop = true;
            this.NinthChoice.Text = " ";
            this.NinthChoice.UseVisualStyleBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(649, 574);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Winner:";
            // 
            // Winner
            // 
            this.Winner.AutoSize = true;
            this.Winner.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Winner.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Winner.Location = new System.Drawing.Point(649, 593);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(44, 25);
            this.Winner.TabIndex = 27;
            this.Winner.Text = "N/A";
            this.Winner.UseStyleColors = true;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Message.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Message.Location = new System.Drawing.Point(132, 514);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(82, 25);
            this.Message.TabIndex = 28;
            this.Message.Text = "Message";
            this.Message.UseStyleColors = true;
            this.Message.VisibleChanged += new System.EventHandler(this.Message_VisibleChanged);
            // 
            // HorseChoice
            // 
            this.HorseChoice.AutoSize = true;
            this.HorseChoice.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.HorseChoice.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.HorseChoice.Location = new System.Drawing.Point(649, 533);
            this.HorseChoice.Name = "HorseChoice";
            this.HorseChoice.Size = new System.Drawing.Size(44, 25);
            this.HorseChoice.TabIndex = 30;
            this.HorseChoice.Text = "N/A";
            this.HorseChoice.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(649, 514);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 19);
            this.metroLabel5.TabIndex = 29;
            this.metroLabel5.Text = "Your Choice:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(1022, 694);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(235, 15);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "© 2015 Suman Bhowmick. All Rights Reserved";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.HorseChoice);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Winner);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TenthChoice);
            this.Controls.Add(this.NinthChoice);
            this.Controls.Add(this.EightChoice);
            this.Controls.Add(this.SeventhChoice);
            this.Controls.Add(this.SixthChoice);
            this.Controls.Add(this.FifthChoice);
            this.Controls.Add(this.FourthChoice);
            this.Controls.Add(this.ThirdChoice);
            this.Controls.Add(this.SecondChoice);
            this.Controls.Add(this.FirstChoice);
            this.Controls.Add(this.BetChoice);
            this.Controls.Add(this.BalanceView);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.BetView);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Tenth);
            this.Controls.Add(this.Ninth);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seventh);
            this.Controls.Add(this.Sixth);
            this.Controls.Add(this.Fifth);
            this.Controls.Add(this.Fourth);
            this.Controls.Add(this.Third);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.First);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Horse Race Betting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar First;
        private MetroFramework.Controls.MetroProgressBar Second;
        private MetroFramework.Controls.MetroProgressBar Third;
        private MetroFramework.Controls.MetroProgressBar Fourth;
        private MetroFramework.Controls.MetroProgressBar Fifth;
        private MetroFramework.Controls.MetroProgressBar Sixth;
        private MetroFramework.Controls.MetroProgressBar Seventh;
        private MetroFramework.Controls.MetroProgressBar Eight;
        private MetroFramework.Controls.MetroProgressBar Ninth;
        private MetroFramework.Controls.MetroProgressBar Tenth;
        private MetroFramework.Controls.MetroButton Start;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel BetView;
        private MetroFramework.Controls.MetroLabel BalanceView;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTrackBar BetChoice;
        private MetroFramework.Controls.MetroRadioButton FirstChoice;
        private MetroFramework.Controls.MetroRadioButton SecondChoice;
        private MetroFramework.Controls.MetroRadioButton FourthChoice;
        private MetroFramework.Controls.MetroRadioButton ThirdChoice;
        private MetroFramework.Controls.MetroRadioButton SixthChoice;
        private MetroFramework.Controls.MetroRadioButton FifthChoice;
        private MetroFramework.Controls.MetroRadioButton EightChoice;
        private MetroFramework.Controls.MetroRadioButton TenthChoice;
        private MetroFramework.Controls.MetroRadioButton NinthChoice;
        private MetroFramework.Controls.MetroRadioButton SeventhChoice;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel Winner;
        private MetroFramework.Controls.MetroLabel Message;
        private MetroFramework.Controls.MetroLabel HorseChoice;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;




    }
}

