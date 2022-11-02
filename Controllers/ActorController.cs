using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Work_with_Interface.Data;
using Work_with_Interface.Data.Interfaces;

namespace Work_with_Interface.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorInterface _service;

        public ActorController(IActorInterface service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data =await _service.getAll();
            return View(data);
        }
    }
}
