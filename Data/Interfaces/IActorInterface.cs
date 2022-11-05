using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Work_with_Interface.Models;

namespace Work_with_Interface.Data.Interfaces
{
    public interface IActorInterface
    {
       Task<IEnumerable<Actor>> getAllAsync();

       Task<Actor> getByIdAsync(int id);

        Task addAsync(Actor actor);

        Task<Actor> UpdateAsync(int id, Actor newActor);

        Task DeleteAsync(int id);
       
    }
}
 