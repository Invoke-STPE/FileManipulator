using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulator.Models
{
    public class CreateModel
    {
        public string Name { get; set; } = "";
        public string Destination { get; set; } = ".";
        public int Amount { get; set; } = 1;
        public string Append { get; set; } = "timestamp";
        public bool OverWrite { get; set; } = false;
    }
}
