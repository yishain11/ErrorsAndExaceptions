using System;
using System.IO;

namespace ErrorsAndExaceptions.Exe
{
    internal class ErrorExe
    {
        public void TriggerBugs()
        {
            string[] items = new string[5];
            items[0] = "123";
            items[1] = null;
            items[2] = "hello";
            items[3] = "999";

            int[] numbers = new int[1];

            for (int i = 0; i <= items.Length; i++)
            {
                int parsed = int.Parse(items[i]);
                int result = 100 / numbers[parsed % 1];
                Console.WriteLine(items[parsed]);
                string s = items[i].Substring(10);
                int len = items[i + 1].Length;
            }
            string content = File.ReadAllText("C:\\definitely_missing_file.txt");

            Console.WriteLine("Done.");
        }

    }
}
