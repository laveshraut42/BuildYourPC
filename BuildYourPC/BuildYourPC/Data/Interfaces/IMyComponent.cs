using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildYourPC.Data.Interfaces
{
    interface IMyComponent
    {
        int Id { get; set; }
        string Name { get; set; }
        string PowerClass { get; set; }
        string Year { get; set; }
    }
}
