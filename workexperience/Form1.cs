namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello world!";
            label1.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}