using BuildYourPC.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildYourPC.Data.Models
{
    public class Motherboard : IMyComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PowerClass { get; set; }
        public string Year { get; set; }

        //Personal
        public string Chipset { get; set; }
        public string Socket { get; set; }
        public string RAMAge { get; set; }
        public int RAMStrings { get; set; }
        public int RAMSockets { get; set; }

        public string PersonalToString()
        {
            return "Chipset: " + Chipset.ToString() + " \n" +
                   "Socket: " + Socket.ToString() + " \n" +
                   "RAMAge: " + RAMAge.ToString() + " \n" +
                   "RAMStrings: " + RAMStrings + " \n" +
                   "RAMSockets: " + RAMSockets;
        }
    }
}
