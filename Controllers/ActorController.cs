using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Work_with_Interface.Data;
using Work_with_Interface.Data.Interfaces;
using Work_with_Interface.Models;

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
            var data = await _service.getAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.addAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            var actorDetail = await _service.getByIdAsync(id);

            if(actorDetail == null)
            {

                return NotFound();
            }
            return View(actorDetail);

        }

        public async Task<IActionResult> Edit(int id)
        {

            var actorDetail = await _service.getByIdAsync(id);

            if (actorDetail == null)
            {

                return NotFound();
            }
            return View(actorDetail);
        }

        public async Task<IActionResult> Update(int id, Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.UpdateAsync(id, actor);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var data = await _service.getByIdAsync(id);
            if(data == null)
            {
                return View("NotFound");
            }
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConform(int id)
        {
            var data = await _service.getByIdAsync(id);
            if( data == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
           return RedirectToAction(nameof(Index));
        }
    }
}
