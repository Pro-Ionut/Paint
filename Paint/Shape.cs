using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Graf
{
    public abstract class Shape
    {
    
        public int Id { get; set; }
        public Point _origin { get; set; }
        public Pen pen { get; set; }
        public abstract void Draw(Graphics graphicContent, Pen p);
        public abstract void MoveTo(Point P, Graphics graphics);
        public abstract void Resize(int Size, Graphics graphicContent);
        public abstract double Area();
    }
}
