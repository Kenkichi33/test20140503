using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DoubleCountPrint : CountPrint{

        public DoubleCountPrint():base(20){

        }

        protected override int getnext(){
            this.count *= 2;
            return count;
        }
    }
}
