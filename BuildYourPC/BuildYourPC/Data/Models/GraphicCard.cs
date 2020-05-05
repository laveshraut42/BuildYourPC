using BuildYourPC.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildYourPC.Data.Models
{
    public class GraphicCard : IMyComponent, IPowerConsumptor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PowerClass { get; set; }
        public string Year { get; set; }
        public int PowerConsumption { get; set; }

        //Personal
        public int GRAMCount { get; set; }
        public string GRAMAge { get; set; }
        public string GPU { get; set; }
        public string Interfaces { get; set; }
        public string PowerType { get; set; }

        public string PersonalToString()
        {
            return "Power consumption: " + PowerConsumption.ToString() + " \n" +
                   "GRAMCount: " + GRAMCount.ToString() + " \n" +
                   "GRAMAge: " + GRAMAge.ToString() + " \n" +
                   "GPU: " + GPU + " \n" +
                   "Interfaces: " + Interfaces + " \n" +
                   "PowerType: " + PowerType + " \n";
        }
    }
}
