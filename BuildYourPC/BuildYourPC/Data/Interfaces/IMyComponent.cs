using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildYourPC.Data.Interfaces
{
    public interface IMyComponent
    {
        int Id { get; set; }
        string Name { get; set; }
        string PowerClass { get; set; }
        string Year { get; set; }
        string BaseToString()
        {
            return "Name: " + Name + "\n" + "Year: " + Year + "\n";
        }
        abstract string PersonalToString();
        public string PublicToString()
        {
            return BaseToString() + PersonalToString();
        }
    }
}
