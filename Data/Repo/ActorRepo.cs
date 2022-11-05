using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Work_with_Interface.Data.Interfaces;
using Work_with_Interface.Models;

namespace Work_with_Interface.Data.Repo
{
    public class ActorRepo : IActorInterface
    {
        private readonly AppDbContext _db;

        public ActorRepo(AppDbContext db)
        {
            _db = db;
        }

        public async Task addAsync(Actor actor)
        {
           await  _db.actors.AddAsync(actor);
           await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _db.actors.FindAsync(id);

             _db.actors.Remove(data);

            await _db.SaveChangesAsync();
        

        }

      
        public async Task<IEnumerable<Actor>> getAllAsync()
        {
            var data = await _db.actors.ToListAsync();
            return data;
        }

      
        public async Task<Actor> getByIdAsync(int id)
        {
            var data = await _db.actors.FirstOrDefaultAsync(n => n.Id == id);
            return data;
        }

        

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
             _db.actors.Update(newActor);
            await _db.SaveChangesAsync();
            return newActor;
        }
    }
}
