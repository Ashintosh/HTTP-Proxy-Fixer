using System;
using System.IO;

namespace Aligner
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Drag the .txt file onto the .exe");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Variables.filePath = Path.GetDirectoryName(args[0]) + @"\" + Path.GetFileName(args[0]);


            Console.Write("File Path -> ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(Variables.filePath);
            Console.ResetColor();

            Console.Title = "HTTP Proxy Adder by AsH#2345";

            //Console.Write("Enter File Path -> ");
            //Variables.filePath = Console.ReadLine();
            Console.Write("\n\nProxy Type\n1. HTTP\n2. HTTPS\n");

            int type = Convert.ToInt32(Console.ReadLine());

            switch (type)
            {
                case 1: { Variables.lineStarter = "http://"; break; }
                case 2: { Variables.lineStarter = "https://"; break; }
                default: { Variables.lineStarter = "http://"; break; }
            }

            var time = new System.Diagnostics.Stopwatch();

            time.Start();

            if (File.Exists(Variables.SAVE_PATH))
                File.Delete(Variables.SAVE_PATH);

            System.IO.StreamReader file = new System.IO.StreamReader(Variables.filePath);
            System.IO.StreamWriter write = new System.IO.StreamWriter(Variables.SAVE_PATH);
            while ((Variables.line = file.ReadLine()) != null)
            {
                Variables.newLine = Variables.lineStarter + Variables.line + @"/";

                write.WriteLine(Variables.newLine);

                Console.WriteLine("Changed " + Variables.line + " to " + Variables.newLine);

                Variables.lineCount++;
            }

            time.Stop();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nDone!");
            Console.ResetColor();
            Console.WriteLine($"\nChanged {Variables.lineCount} Proxies in {time.ElapsedMilliseconds} ms");
            Console.WriteLine("\nSaved file to Documents as \"ConvertedProxyList.txt\"");

            file.Close();
            write.Close();

            Console.ReadLine();
        }
    }
}
