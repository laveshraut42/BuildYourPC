using BuildYourPC.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildYourPC.Data.Models
{
    public class CPU : IMyComponent, IPowerConsumptor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PowerClass { get; set; }
        public string Year { get; set; }
        public int PowerConsumption { get; set; }

        //Personal
        public int CoresCount { get; set; }
        public int Frequency { get; set; }
        public string Chipset { get; set; }

        //RAM
        public string RamAge { get; set; }
        public int RamFrequency { get; set; }
        public int RamStrings { get; set; }
}
}
