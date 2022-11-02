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
        public void add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> getAll()
        {
            var data = await _db.actors.ToListAsync();
            return data;
        }

        public Actor getById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
