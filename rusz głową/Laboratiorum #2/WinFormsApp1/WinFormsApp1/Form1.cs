namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox1;
        }
    }
}