using BuildYourPC.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildYourPC.Data.Models
{
    public class RAM : IMyComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PowerClass { get; set; }
        public string Year { get; set; }

        //Personal
        public int Frequency { get; set; }
        public string Age { get; set; }
        public int Amount { get; set; }
        public int Pieces { get; set; }
        public string Timings { get; set; }
    }
}
