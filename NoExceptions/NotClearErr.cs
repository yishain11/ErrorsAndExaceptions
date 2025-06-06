using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorsAndExaceptions.NoExceptions
{
    internal class NotClearErr
    {
        public void NotClearCode() {

            string[] names = new string[5];
            names[0] = "Alice";
            names[2] = "Charlie";

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > 5) 
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}
