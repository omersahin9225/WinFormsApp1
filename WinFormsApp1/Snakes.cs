namespace WinFormsApp1
{
    public partial class Snakes : Form
    {
        private int csize = 10;
        int ysize = 10;





        public Snakes()
        {
            InitializeComponent();
           

            SnakeBodyMove();
        }

        Random rnd = new Random();
        
        Panel bait = new Panel();
        
        Panel sSnakeHead;
        
        List<Panel> snakeBody = new List<Panel>();
        
        string direction = "right";// start yönü
        private void Snakes_Resize(object sender, EventArgs e)
        {
            int he = this.Height;
            panel1.Height = (int)Math.Round((decimal)panel1.Height / csize) * csize;

            panel1.Width = (int)Math.Round((decimal)panel1.Width / csize) * csize;

        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            Reset();

            sSnakeHead = new Panel();
            sSnakeHead.Location = new Point(rnd.Next(0, panel1.Width / ysize) * ysize, rnd.Next(0, panel1.Height / ysize) * ysize);
            sSnakeHead.Size = new Size(10, 10);
            sSnakeHead.BackColor = Color.Green;
            snakeBody.Add(sSnakeHead);
            panel1.Controls.Add(snakeBody[0]);

            timer1.Start();
            Bait();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int locX = snakeBody[0].Location.X;
            int locY = snakeBody[0].Location.Y;

            BaitEat();
            SnakeBodyMove();
            Impact();



            if (direction == "right")
            {
                locX += 10;
                if (locX >=400)
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
                if (locY >= 400)
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
            if (e.KeyCode == Keys.Right && direction!="Left")
            {
                direction = "right";
            }
            if (e.KeyCode == Keys.Left && direction != "Right")
            {
                direction = "left";
            }
            if (e.KeyCode == Keys.Up && direction != "Dowm")
            {
                direction = "up";
            }
            if (e.KeyCode == Keys.Down && direction != "Up")
            {
                direction = "down";
            }
        }
        private void Bait()
        {

            bait.Size = new Size(10, 10);
            bait.BackColor = Color.Red;
            bait.Location = new Point(rnd.Next(0, panel1.Width / ysize) * ysize, rnd.Next(0, panel1.Height / ysize) * ysize);
            panel1.Controls.Add(bait);

        }
        private void BaitEat()
        {
            if (snakeBody[0].Location == bait.Location)
            {
                panel1.Controls.Remove(bait);
                Bait();
                SnakeBodyAdd();

            }

        }
        private void SnakeBodyAdd()
        {
            Panel snakeS = new Panel();
            snakeS.Size = new Size(10, 10);
            snakeS.BackColor = Color.Green;






            snakeBody.Add(snakeS);
            panel1.Controls.Add(snakeS);

        }

        private void SnakeBodyMove()
        {
            for (int i = snakeBody.Count - 1; i > 0; i--)
            {
                snakeBody[i].Location = snakeBody[i - 1].Location;

            }
        }

        private void Impact()
        {
            for (int i = 2; i < snakeBody.Count; i++)
            {
                if (snakeBody[0].Location == snakeBody[i].Location)
                {
                    
                    timer1.Stop();
                            
                    

                }

            }
        }

        private void Reset()
        {
            snakeBody.Clear();
            panel1.Controls.Clear();
        }

        
    }
}