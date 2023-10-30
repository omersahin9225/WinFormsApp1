namespace WinFormsApp1
{
    public partial class Snakes : Form
    {
        private int csize = 10;




        public Snakes()
        {
            InitializeComponent();
        }
        Panel sSnakeHead;
        List<Panel> snakeBody = new List<Panel>();
        string direction = "right";// start yönü
        private void Snakes_Resize(object sender, EventArgs e)
        {
            int he = this.Height;
            this.Height = (int)Math.Round((decimal)he / csize) * csize;

            this.Width = (int)Math.Round((decimal)this.Width / csize) * csize;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            sSnakeHead = new Panel();
            sSnakeHead.Location = new Point(200, 200);
            sSnakeHead.Size = new Size(20, 20);
            sSnakeHead.BackColor = Color.Green;
            snakeBody.Add(sSnakeHead);
            panel1.Controls.Add(snakeBody[0]);
        }
    }
}