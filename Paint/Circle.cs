using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf
{
    public class Circle : Shape
    {public int Radius { get; set; }
        public Circle()
        {

        }
    public Circle(int Radius, Point origin)
     { 
       this.Radius = Radius;
       _origin = origin;

     }
        public override double Area()
        {
           return Math.PI * Math.Pow(Radius, 2);
        }

       

        public override void Draw(Graphics graphics,Pen pen)
        {
            graphics.DrawEllipse(pen, _origin.X - Radius, _origin.Y - Radius, Radius + Radius, Radius + Radius);
        }

        public override void MoveTo(Point point,Graphics graphics)
        {
            _origin = point;
            graphics.DrawEllipse(pen, _origin.X - Radius, _origin.Y - Radius, Radius + Radius, Radius + Radius);

        }

       

        public override void Resize(int Size, Graphics graphicContent)
        {
            Radius += Size;
        }
    }
}
