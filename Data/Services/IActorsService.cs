using E_Commerce_MVC.Models;

namespace E_Commerce_MVC.Data.Services
{
    public interface IActorsService
    {

        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        void Delete(int id);
    }
}
