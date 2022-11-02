using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Work_with_Interface.Models;

namespace Work_with_Interface.Data.Interfaces
{
    public interface IActorInterface
    {
        IEnumerable<Actor> getAll();

        Actor getById(int id);

        void add(Actor actor);

        Actor Update(int id, Actor newActor);

        void Delete(int id);
    }
}
 