using Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class rectangle<S1>:Shape 
    {
        public S1 eni { get; set; } 
        public S1 boyi { get; set; } 

        public rectangle(S1 eni)
        {
            this.eni = eni;
            
        }
        public rectangle(S1 eni, S1 boyi) : this(eni)
        {
            this.boyi = boyi;
        }

        public override void yuza <S1>()
        {
         Console.WriteLine($"To'rtburchak yuzasi = {eni * boyi}");
         
        }
        public override void perimetr<S1>()
        {
            Console.WriteLine($"To'rtburchak perimetri = {2 * (eni + boyi)}");
        }
        
    }
}
