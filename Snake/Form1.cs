namespace Snake
{
    public partial class Form1 : Form
    {
        Direction dir;
        Random rnd;
        List<SnakeBody> list;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 200;
            list = new List<SnakeBody>();
            dir = Direction.Right;
            rnd = new Random();
            ChangeLocationOfFood();
            lb_Points.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Movement(dir);
            for(int i = list.Count-1; i > 1; i--)
                if (pb_Player.Bounds.IntersectsWith(list[i].Bounds))
                    GameOver();
            if (pb_Player.Location.X < 0 || pb_Player.Location.X >= Width-pb_Player.Width ||
                pb_Player.Location.Y < 0 || pb_Player.Location.Y >= Height-pb_Player.Height)
                GameOver();
            if (pb_Player.Bounds.IntersectsWith(pb_Food.Bounds))
                ChangeLocationOfFood();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
                dir = Direction.Left;
            if(e.KeyCode == Keys.D)
                dir = Direction.Right;
            if(e.KeyCode == Keys.W)
                dir = Direction.Up;
            if(e.KeyCode == Keys.S)
                dir = Direction.Down;
              
        }
        
        private void Movement(Direction dir)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                list[i].Location = new Point(list[i].Body.Location.X, list[i].Body.Location.Y);
            }
            if (list.Count != 0)
                list[0].Location = new Point(pb_Player.Location.X, pb_Player.Location.Y);
            if (dir == Direction.Left)
                pb_Player.Left -= 32;
            if (dir == Direction.Right)
                pb_Player.Left += 32;
            if (dir == Direction.Up)
                pb_Player.Top -= 32;
            if (dir == Direction.Down)
                pb_Player.Top += 32;
        }
        private void ChangeLocationOfFood()
        {
            pb_Food.Location = new Point(rnd.Next(0, 30) * 32 + 4, rnd.Next(0, 30) * 32 + 4);
            AddOnePoint();

        }
       private void AddOnePoint()
        {
            lb_Points.Text = (int.Parse(lb_Points.Text)+1).ToString();
            if (list.Count == 0)
                list.Add(new SnakeBody(pb_Player.Location.X, pb_Player.Location.Y));
            else
                list.Add(new SnakeBody(pb_Player.Location.X, pb_Player.Location.Y,list[list.Count-1]));
            SetOnScreen();
        }
        private void GameOver()
        {
            timer1.Stop();
            MessageBox.Show("GAME OVER Sie haben " + lb_Points.Text + " Punkte erzielt");
        }
        private void SetOnScreen() => Controls.Add(list.Last());
    }
}