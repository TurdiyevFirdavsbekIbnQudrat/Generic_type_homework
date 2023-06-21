using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Abstract;


namespace Triangle
{
    public class triangle<T1> : Shape where T1 : new()
    {
        private T1 a { get; set; }
        private T1 b { get; set; }  

        private T1 c { get; set; }  
        public triangle(T1 A, T1 B, T1 C)
        {
             a = A;
             b = B;
             c = C;
        }
        public override void yuza<T1>()
        {
            //T1 p = (a + b + c) / 2;
            //p = p * Math.Abs(p - a) * Math.Abs(p - b) * Math.Abs(p - c);
            //Console.WriteLine($"Uchburchak yuzasi = {Math.Sqrt(p)}");
        }

        public override void perimetr<T1>()
        {
            //T1 p = a + b + c;
            //Console.WriteLine($"Uchburchak perimetri= {p}");
        }
    }
}
