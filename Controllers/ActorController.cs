using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Work_with_Interface.Data;

namespace Work_with_Interface.Controllers
{
    public class ActorController : Controller
    {
        private readonly AppDbContext _db;

        public ActorController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var data = _db.actors.ToList();
            return View(data);
        }
    }
}
