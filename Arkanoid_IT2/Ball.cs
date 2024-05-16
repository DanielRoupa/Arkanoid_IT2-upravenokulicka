using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Arkanoid_IT2
{
    public class Ball : GameObject
    {
        public int Size { get; }

        public Ball(int size)
        {
            Size = size;
        }

        public override void Draw(Canvas canvas)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 30;
            ellipse.Height = 30;
            ellipse.Fill = Brushes.Red;
            //Canvas.SetBottom(ellipse, 20);
            //Canvas.SetLeft(ellipse, Location.X - Size / 2);
            canvas.Children.Add(ellipse);

        }
    }
}
