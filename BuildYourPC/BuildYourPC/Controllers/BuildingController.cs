using BuildYourPC.Data.Models;
using BuildYourPC.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildYourPC.Controllers
{
    public class BuildingController : Controller
    {
        private readonly DatabaseLists _databaseLists;

        public BuildingController(DatabaseLists databaseLists)
        {
            _databaseLists = databaseLists;
        }

        public ViewResult List()
        {
            ViewBag.Title = "MainPage";
            var comp = new Computer();
            comp.Cpu = _databaseLists.CPUs.FirstOrDefault();
            comp.Motherboard = _databaseLists.Motherboards.FirstOrDefault();
            comp.RAM = _databaseLists.RAMs.FirstOrDefault();
            comp.PowerSupply = _databaseLists.PowerSupplies.FirstOrDefault();
            comp.Memory = _databaseLists.Memories.FirstOrDefault();
            comp.GraphicCard = _databaseLists.GraphicCards.FirstOrDefault();
            return View(comp);
        }
    }
}
