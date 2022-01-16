using FileManipulator.Models;
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
            CreateModel parameter = SortParameters(args);

            string destination = GetCurrentPath(parameter.Destination);

            if (Directory.Exists(destination))
            {
                if (!String.IsNullOrWhiteSpace(parameter.Name))
                {
                    string fullFileDestination = Path.Join(destination, parameter.Name);
                    if (File.Exists(fullFileDestination))
                    {
                        if (parameter.OverWrite)
                        {
                            File.Create(fullFileDestination);
                            return "File Created";
                        }
                        else
                        {
                            return $"File {fullFileDestination} Already Exist";
                        }
                    } else
                    {
                        File.Create(fullFileDestination);
                        return $"File Created at: {fullFileDestination}";
                    }
                }
            }
            else
            {
                return "";
            }
            return "";
        }

        private static string GetCurrentPath(string destination)
        {
            if (destination.Contains("."))
            {
                destination = destination.Replace(".", Environment.CurrentDirectory);
            }

            return destination;
        }

        private static CreateModel SortParameters(string[] parameters)
        {
            CreateModel createModel = new CreateModel();
            foreach (var parameter in parameters)
            {
                if (parameter.Contains("-") && parameter.ToLower() != "-create") { 
                    int index = Array.IndexOf(parameters, parameter);
                    switch (parameter.ToLower())
                    {
                        case "-name":
                            createModel.Name = parameters[index + 1];
                            break;
                        case "-dest":
                            createModel.Destination = parameters[index + 1];
                            break;
                        case "-amount":
                            createModel.Amount = Convert.ToInt32(parameters[index + 1]);
                            break;
                        case "-append":
                            createModel.Append = parameters[index + 1];
                            break;
                        case "-overwrite":
                            createModel.OverWrite = parameters[index + 1] == "true" ?  true : false;
                            break;
                        default:
                            break;
                    }
                }
            }



            return createModel;
        }
    }
}
