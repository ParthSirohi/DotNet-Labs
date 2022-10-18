using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    //objective: understanding abstract keyword 
    //classes Shape (abstract), circle(normal)
    //relation: circle:shape
    //properties for circle class: radius(float)
    //functions: for shape class: Draw()==> abstract
    public abstract class Shape
    {
        public abstract void Draw();
        

        
    }
    public class Circle : Shape
    {
        public float Radius { get; set; }
        public override void Draw()
        {
            Console.WriteLine($"Circle drawn with radius {this.Radius} ");

        }
    }
}
