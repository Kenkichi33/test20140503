using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Console.Read();

            CountPrint c = null;
            if (n == '1'){
                c = new CountPrint(20);
            }
            else
            {
                c = new DoubleCountPrint();
            }

            for(int t=0;t<10;t++){
                c.shownext();
            }

            //CountPrint C = new DoubleCountPrint();
            //for(int i=0;i<10;i++){
            //    C.shownext();
            //}

            CountPrint C = new CustomCountPrint(11);
            for(int i=0;i<10;i++){
                C.shownext();
            }

        }

    }
}
