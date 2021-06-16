using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RavnRazorChallenge.Models;

namespace RavnRazorChallenge.Services
{
    public interface ISwapiService
    {
        Task<string> GetAllRoots();
        Task<ICollection<Person>> GetAllPeople(int idPagina );
        Task<Person> GetPersonById( int id);
        Task<ICollection<Film>> GetAllFilms();
        Task<Film> GetFilmById( int id );
        Task<ICollection<Vehicle>> GetAllVehicles();
        Task<Vehicle> GetVehicleById( int id );
        Task<ICollection<Starship>> GetAllStarships();
        Task<Starship> GetStarshipById( int id );
        Task<ICollection<Specie>> GetAllSpecies();
        Task<Specie> GetSpecieById( int id );
        Task<ICollection<Planet>> GetAllPlanets();
        Task<Planet> GetPlanetById( int id );

    }
}
