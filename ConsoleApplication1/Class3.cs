using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CustomCountPrint:CountPrint
    {
        int number = 0;

        public CustomCountPrint(int initialNumber)
            : base(0)
        {
            this.number = initialNumber;
        }

        protected override int getnext() {
            this.count++;
            return this.number*this.count;
        }
    }
}
