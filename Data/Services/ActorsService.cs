using E_Commerce_MVC.Data.Base;
using E_Commerce_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_MVC.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}