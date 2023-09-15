namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
            {
                InitializeComponent();
                bob = new Guy() { Cash = 50, Name = "bob"};

                joe = new Guy() { Cash = 50, Name = "joe"};

                UpdateForm();
            }
        private void Form1_Load(object sender, EventArgs e) { }

        public void UpdateForm()
        {
            label1.Text = joe.Name + " ma " + joe.Cash + " z³";
            label2.Text = bob.Name + " ma " + bob.Cash + " z³";
            label3.Text = "bank ma " + bank + " z³";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank nie posiada takiej iloœci pieniêdzy");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            joe.GiveCash(10);
            bob.ReceiveCash(10);
            UpdateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(5);
            bob.GiveCash(5);
            UpdateForm();
        }
    }
}