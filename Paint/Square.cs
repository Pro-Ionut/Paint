using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf
{
    public class Square : Shape
    {
        public int Width { get; set; }
        public Square()
        {
                
        }
        public Square(int Width,Point p)
        {
            this.Width = Width;
            _origin = p;
                
        }
        public override double Area()
        {

            return Width * Width;
        }
 
        public override void Draw(Graphics graphicContent, Pen p)
        {
            graphicContent.DrawRectangle(p, this._origin.X, this._origin.Y, this.Width, this.Width);

        }

        public override void MoveTo(Point P, Graphics graphics)
        {
            _origin = P;
            graphics.DrawRectangle(pen, this._origin.X, this._origin.Y, this.Width, this.Width);
        }

        public override void Resize(int Size, Graphics graphicContent)
        {
            Width += Size;
              
                }
               
        
    }
}
