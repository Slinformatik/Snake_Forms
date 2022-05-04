using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class SnakeBody : PictureBox
    {
        public SnakeBody Body;        
        public SnakeBody(int x, int y, SnakeBody body)
        {            
            this.Image = Properties.Resources.Body;
            Location = new Point(x, y);
            Body = body;
            Size();
        }
        public SnakeBody(int x, int y)
        {
            this.Image = Properties.Resources.Body;
            Location = new Point(x, y);
            Size();
        }
        public void Size()
        {
            this.Width = 32;
            this.Height = 32;
        }
    }
}
