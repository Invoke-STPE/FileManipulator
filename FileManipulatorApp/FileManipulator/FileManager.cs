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
        public static bool Create(string name, string destination = ".", int amount = 1, string unique = "timestamp", bool overwrite = false)
        {
            destination = GetCurrentPath(destination);
            string fullFileDestination = Path.Join(destination, name);

            if (File.Exists(fullFileDestination))
            {
                return true;
            }
            else
            {
                return false;
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
    }
}
