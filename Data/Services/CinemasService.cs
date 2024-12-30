using E_Commerce_MVC.Data.Base;
using E_Commerce_MVC.Models;

namespace E_Commerce_MVC.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}