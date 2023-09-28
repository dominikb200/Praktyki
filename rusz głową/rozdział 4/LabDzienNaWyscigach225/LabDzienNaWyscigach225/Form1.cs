namespace LabDzienNaWyscigach225
{
    public partial class Form1 : Form
    {
        Greyhound[] GreyhoundArray = new Greyhound[4];
        Guy[] GuyArray = new Guy[3];
        Random MyRandom = new Random();

        public Form1()
        {
            InitializeComponent();
            GuyArray[0] = new Guy() { Name = "Janek", Cash = 50, MyLabel = joeBetLabel, MyRadioButton = joeRadioButton, MyBet = new Bet() };
            GuyArray[1] = new Guy() { Name = "Bartek", Cash = 75, MyLabel = bobBetLabel, MyRadioButton = bobRadioButton, MyBet = new Bet() };
            GuyArray[2] = new Guy() { Name = "Arek", Cash = 45, MyLabel = alBetLabel, MyRadioButton = alRadioButton, MyBet = new Bet() };
            for (int i = 0; i < 3; i++)
            {
                GuyArray[i].MyBet.Bettor = GuyArray[i];
            }

            GreyhoundArray[0] = new Greyhound() { MyPictureBox = pictureBox2, MyRandom = MyRandom, RacetrackLength = pictureBox1.Width };
            GreyhoundArray[1] = new Greyhound() { MyPictureBox = pictureBox3, MyRandom = MyRandom, RacetrackLength = pictureBox1.Width };
            GreyhoundArray[2] = new Greyhound() { MyPictureBox = pictureBox4, MyRandom = MyRandom, RacetrackLength = pictureBox1.Width };
            GreyhoundArray[3] = new Greyhound() { MyPictureBox = pictureBox5, MyRandom = MyRandom, RacetrackLength = pictureBox1.Width };
            nameLabel.Text = GuyArray[0].Name;
            minBetLabel.Text = "Minimalny zak³ad " + betUpDown.Minimum.ToString() + " z³";

            for (int i = 0; i < 3; i++)
            {
                GuyArray[i].UpdateLabels();
            }


        }

        private void betButton_Click(object sender, EventArgs e)
        {
            int guyNumber = 0;
            if (joeRadioButton.Checked == true)
                guyNumber = 0;
            else if (bobRadioButton.Checked == true)
                guyNumber = 1;
            else if (alRadioButton.Checked == true)
                guyNumber = 2;
            if (betUpDown.Value > GuyArray[guyNumber].Cash)
            {
                MessageBox.Show("Nie staæ ciê na tak wysoki zak³ad", "nie wystarczaj¹ca iloœæ pieniêdzy");

            }
            else
            {
                GuyArray[guyNumber].PlaceBet((int)betUpDown.Value, (int)numericUpDown1.Value);
                GuyArray[guyNumber].DisableRadioButton();
                GuyArray[guyNumber].UpdateLabels();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (GreyhoundArray[i].Run() == true)
                {
                    groupBox1.Enabled = true;
                    timer1.Stop();
                    i++;
                    MessageBox.Show("chart numer " + i + " wygra³", "koniec");
                    for (int j = 0; j < 4; j++)
                    {
                        GreyhoundArray[j].TakeStartingPosition();
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        if (GuyArray[j].MyBet == null) { break; }
                        else
                        {
                            GuyArray[j].EnableRadioButton();
                            GuyArray[j].MyBet.PayOut(i);
                            GuyArray[j].Collect(i);
                            GuyArray[j].UpdateLabels();
                            GuyArray[j].ClearBet();
                        }
                    }
                }
            }
        }
    }
}