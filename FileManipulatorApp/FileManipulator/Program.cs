using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace FileManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(@"C:\Users\Steven\Documents\");
            switch (args[0].ToLower())
            {
                case "-create":
                    string answer = FileManager.Create(args);
                    Console.WriteLine(answer);
                    break;
                case "rename":
                    Console.WriteLine("Choosen action rename");
                    break;
                case "delete":
                    Console.WriteLine("Choosen action delete");
                    break;
                case "replace":
                    Console.WriteLine("Choosen action replace");
                    break;
                case "help":
                    Console.WriteLine("Help needs to be implemented.");
                    break;
                default:
                    Console.WriteLine("Action was not recognized, use help for more information.");
                    break;
            }

        }
    }

}
