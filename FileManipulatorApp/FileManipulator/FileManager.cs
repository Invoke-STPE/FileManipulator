using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulator
{
    internal static class FileManager
    {
        // string -create = "", string -dest = ".", int -amount = 1, string -append = "timestamp", bool -overwrite = false
        public static string Create(string[] args)
        {
            Dictionary<string, string> parameters = SortParameters(args);

            string destination = GetCurrentPath(parameters["-dest"]);
            string fullFileDestination = Path.Join(destination, parameters["-name"]);

            if (Directory.Exists(destination))
            {
                File.Create(fullFileDestination);
                Console.WriteLine(fullFileDestination);
                return "File Created"; ;
            }
            else
            {
                return "";
            }

        }

        private static string GetCurrentPath(string destination)
        {
            if (destination.Contains("."))
            {
                destination = destination.Replace(".", Environment.CurrentDirectory);
            }

            return destination;
        }

        private static Dictionary<string, string> SortParameters(string[] parameters)
        {
            Dictionary<string, string> returnValues = new();

            foreach (var parameter in parameters)
            {
                switch (parameter.ToLower())
                {
                    case "-dest":
                        int indexValue = Array.IndexOf(parameters, "-dest");
                        returnValues.Add(parameters[indexValue], parameters[indexValue + 1]);
                        break;
                    case "-name":
                        indexValue = Array.IndexOf(parameters, "-name");
                        returnValues.Add(parameters[indexValue], parameters[indexValue + 1]);
                        break;
                    case "-amount":
                        indexValue = Array.IndexOf(parameters, "-amount");
                        returnValues.Add(parameters[indexValue], parameters[indexValue + 1]);
                        break;
                    case "-append":
                        indexValue = Array.IndexOf(parameters, "-append");
                        returnValues.Add(parameters[indexValue], parameters[indexValue + 1]);
                        break;
                    case "-overwrite":
                        indexValue = Array.IndexOf(parameters, "-overwrite");
                        returnValues.Add(parameters[indexValue], parameters[indexValue + 1]);
                        break;
                    default:
                        break;
                }
            }
            return returnValues;
        }
    }
}
