using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulator.Models
{
    public class CreateModel
    {
        public CreateModel(string name = "", string destination = ".", int amount = 1, string append = "timestamp", bool overWrite = false)
        {
            Name = name;
            Destination = destination;
            Amount = amount;
            Append = append;
            OverWrite = overWrite;
        }

        public string Name { get; set; }
        public string Destination { get; set; }
        public int Amount { get; set; }
        public string Append { get; set; }
        public bool OverWrite { get; set; }
    }
}
