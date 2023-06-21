using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class kvadrat<S1> : rectangle<S1>
    {   private S1 boyi {get;set;} 
        public kvadrat(S1 eni ):base(eni) 
        {
            boyi = eni;
        }

        public override void yuza<S1>()
        {
            base.yuza<S1>();
        }

    }
}
