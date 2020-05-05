using BuildYourPC.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildYourPC.Data.Models
{
    public class PowerSupply : IMyComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PowerClass { get; set; }
        public string Year { get; set; }

        //Personal
        public string ProtectionLevel { get; set; }
        public int Power { get; set; }

        public string PersonalToString()
        {
            return "ProtectionLevel: " + ProtectionLevel.ToString() + " \n" +
                   "Power: " + Power.ToString() + " \n";
        }
    }
}
