namespace WinFormsApp1
{
    public partial class ddddddddddd : Form
    {
        public ddddddddddd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ddddddddddd_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 25; i++)
            {
                this.LoadingBar.Value += 4;
                Thread.Sleep(5);
            }
        }
    }
}