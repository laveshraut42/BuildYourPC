using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildYourPC.Data.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public CPU Cpu { get; set; }
        public Motherboard Motherboard { get; set; }
        public RAM RAM { get; set; }
        public PowerSupply PowerSupply { get; set; }
        public Memory Memory { get; set; }
        public GraphicCard GraphicCard { get; set; }
    }
}
