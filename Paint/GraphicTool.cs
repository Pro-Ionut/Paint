using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf
{
    public class GraphicTool
    {
        //depinde la nivel abstract doar de clasa Shape //metoda caracter general!!
        private List<Shape> _shapeList = new List<Shape> {  new Square(), new Circle() };         
        
        public void DrawAll()
         {
             
         }
    }
}
