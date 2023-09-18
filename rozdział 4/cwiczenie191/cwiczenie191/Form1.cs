namespace cwiczenie191
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMielage;
        double milesTraveled;
        double reimburseRate = 0.39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMielage = (int)numericUpDown2.Value;
            if (startingMileage <= endingMielage)
            {
                milesTraveled = endingMielage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = amountOwed.ToString() + " z�";
            } else
            {
                MessageBox.Show("Pocz�tkowy stan licznika musi by� mniejszy ni� ko�cowy", "Nie mog� obliczy� odleglo�ci");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " kilometr�w", "przebyta odleg�o��");
        }
    }
}