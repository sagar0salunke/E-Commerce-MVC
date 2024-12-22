using E_Commerce_MVC.Data.Base;
using E_Commerce_MVC.Models;

namespace E_Commerce_MVC.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
