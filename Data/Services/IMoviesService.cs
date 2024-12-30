using E_Commerce_MVC.Data.Base;
using E_Commerce_MVC.Data.ViewModels;
using E_Commerce_MVC.Models;

namespace E_Commerce_MVC.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
    }
}