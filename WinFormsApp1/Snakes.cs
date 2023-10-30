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
            panel1.Height = (int)Math.Round((decimal)panel1.Height / csize) * csize;

            panel1.Width = (int)Math.Round((decimal)panel1.Width / csize) * csize;

        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            sSnakeHead = new Panel();
            sSnakeHead.Location = new Point(200, 10);
            sSnakeHead.Size = new Size(10, 10);
            sSnakeHead.BackColor = Color.Green;
            snakeBody.Add(sSnakeHead);
            panel1.Controls.Add(snakeBody[0]);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int locX = snakeBody[0].Location.X;
            int locY = snakeBody[0].Location.Y;

            if (direction == "right")
            {
                locX += 10;
                if (locX >= 390)
                {
                    locX = 0;
                }

            }
            else if (direction == "left")
            {
                locX -= 10;
                if (locX < 0)
                {
                    locX = 390;
                }
            }
            else if (direction == "down")
            {
                locY += 10;
                if (locY >= 390)
                {
                    locY = 0;
                }
            }
            else if (direction == "up")
            {
                locY -= 10;
                if (locY < 0)
                {
                    locY = 390;
                }
            }
            snakeBody[0].Location = new Point(locX, locY);



        }

        private void Snakes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && direction != "left")
            {
                direction = "right";
            }
            if (e.KeyCode == Keys.Left && direction != "right")
            {
                direction = "left";
            }
            if (e.KeyCode == Keys.Up && direction != "down")
            {
                direction = "up";
            }
            if (e.KeyCode == Keys.Down && direction != "up")
            {
                direction = "down";
            }
        }
    }
}