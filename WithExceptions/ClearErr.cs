using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorsAndExaceptions.WithExceptions
{
    internal class ClearErr
    {
        public void ClearErrCode()
        {
            string[] names = new string[5];
            names[0] = "Alice";
            names[2] = "Charlie";

            for (int i = 0; i < names.Length; i++)
            {
                try
                {
                    if (names[i].Length > 5)
                    {
                        Console.WriteLine(names[i]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error at index {i}: {ex.GetType().Name} - {ex.Message}");
                    Console.WriteLine($"item causing the error is: {names[i]}");
                }
            }
        }

    }
}
