using System;
using System.Collections.Generic;
using System.IO;
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

        public void MultiTryCatch() {
            try
            {
                Console.Write("Enter a number to divide 100 by: ");
                string input = Console.ReadLine();

                int number = int.Parse(input);
                int result = 100 / number;    
                Console.WriteLine($"Result: {result}");

                File.ReadAllText("nonexistent.txt"); 
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: You didn't enter a valid number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: You cannot divide by zero.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: File not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine("Details: " + ex.Message);
            }

            Console.WriteLine("Program ended.");

        }
    }
}
