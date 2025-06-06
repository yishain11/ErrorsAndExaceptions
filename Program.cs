using ErrorsAndExaceptions.NoExceptions;
using ErrorsAndExaceptions.WithExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorsAndExaceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NoException nc = new NoException();
            //nc.NoExecptionCode();

            NotClearErr nce = new NotClearErr();
            //nce.NotClearCode();

            BasicTryCatch btc = new BasicTryCatch();
            btc.BasicTryCatchCode();
        }
    }
}
