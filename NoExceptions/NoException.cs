using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorsAndExaceptions.NoExceptions
{
    internal class NoException
    {
        public void NoExecptionCode() {
            // syntax err
            //Console.WriteLine("he there";


            // err 1
            string name = "yishai";
            int nameInt = int.Parse(name);
            Console.WriteLine($"int name is: {nameInt}");
        }
    }
}
