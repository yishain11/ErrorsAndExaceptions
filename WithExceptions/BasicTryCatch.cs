using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorsAndExaceptions.WithExceptions
{
    internal class BasicTryCatch
    {
        public void BasicTryCatchCode() {
            try
            {
                string name = "yishai";
                int nameInt = int.Parse(name);
                Console.WriteLine($"int name is: {nameInt}");

            }
            catch(Exception e) {
                Console.WriteLine("error!");
                Console.WriteLine(e);
            }
            Console.WriteLine("still running - even it there is an error!");
        }
    }
}
