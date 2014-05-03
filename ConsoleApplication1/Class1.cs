using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CountPrint
    {
        protected int count = 0;
        
        public CountPrint(int initialCount){
            this.count = initialCount;
        }

        public void shownext(){
            Console.WriteLine(this.getnext());
        }

        protected virtual int getnext(){
            return count++;
        }

    }
}
