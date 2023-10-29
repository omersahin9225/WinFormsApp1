namespace WinFormsApp1
{
    public partial class Snakes : Form
    {
        private int csize = 10;
        



        public Snakes()
        {
            InitializeComponent();
        }

        private void Snakes_Resize(object sender, EventArgs e)
        {
            int he = this.Height;
            this.Height = (int) Math.Round( (decimal) he / csize) * csize;

            this.Width = (int)Math.Round((decimal)this.Width / csize) * csize;

        }
    }
}