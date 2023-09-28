namespace Cwiczenie201
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;
        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33};
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant temp;
            temp = lucinda;
            lucinda = lloyd;
            lloyd = temp;
            if(button1.Text == "Lloyd")
            {
                button1.Text = "Lucinda";
                button2.Text = "Lloyd";
            }
            else
            {
                button1.Text = "Lloyd";
                button2.Text = "Lucinda";
            }
        }
    }
}