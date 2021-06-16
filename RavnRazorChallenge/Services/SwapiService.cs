using RavnRazorChallenge.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RavnRazorChallenge.Services
{
    public class SwapiService : ISwapiService
    {
        private readonly HttpClient _httpClient;
        public SwapiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetAllRoots()
        {
            var jsonstring = await _httpClient.GetStringAsync("api/");
            return jsonstring;
        }

     
        public async Task<ICollection<Person>> GetAllPeople( int idPagina )
        {
            IEnumerable<Person> results = new List<Person>();
            var helper = new Helper<Person>();
            var jsonResponse = await _httpClient.GetStringAsync( $"api/people/?page={idPagina}"  );
            helper = JsonConvert.DeserializeObject<Helper<Person>>( jsonResponse );
            results = results.Union( helper.Results );
            return results.ToList();
        }

        public async Task<Person> GetPersonById( int id )
        {
            return JsonConvert.DeserializeObject<Person>( 
                await _httpClient.GetStringAsync( $"api/people/{id}" ) );
        }

        public async Task<ICollection<Film>> GetAllFilms()
        {
            IEnumerable<Film> results = new List<Film>();
            var helper = new Helper<Film>();
            var jsonResponse = await _httpClient.GetStringAsync("api/films/?page=1" );
            helper = JsonConvert.DeserializeObject<Helper<Film>>( jsonResponse );
            results = results.Union( helper.Results );
            return results.ToList();
        }

        public async Task<Film> GetFilmById( int id )
        {
            return JsonConvert.DeserializeObject<Film>(
                await _httpClient.GetStringAsync( $"api/films/{id}" ) );
        }

        public async Task<ICollection<Vehicle>> GetAllVehicles()
        {
            IEnumerable<Vehicle> results = new List<Vehicle>();
            var helper = new Helper<Vehicle>();
            var jsonResponse = await _httpClient.GetStringAsync( "api/vehicles/?page=1" );
            helper = JsonConvert.DeserializeObject<Helper<Vehicle>>( jsonResponse );
            results = results.Union( helper.Results );
            return results.ToList();
        }

        public async Task<Vehicle> GetVehicleById( int id )
        {
            return JsonConvert.DeserializeObject<Vehicle>(
                await _httpClient.GetStringAsync( $"api/vehicles/{id}" ) );
        }

        public async Task<ICollection<Starship>> GetAllStarships()
        {
            IEnumerable<Starship> results = new List<Starship>();
            var helper = new Helper<Starship>();
            var jsonResponse = await _httpClient.GetStringAsync( "api/starships/?page=1" );
            helper = JsonConvert.DeserializeObject<Helper<Starship>>( jsonResponse );
            results = results.Union( helper.Results );
            return results.ToList();
        }

        public async Task<Starship> GetStarshipById( int id )
        {
            return JsonConvert.DeserializeObject<Starship>(
                await _httpClient.GetStringAsync( $"api/starships/{id}" ) );
        }

        public async Task<ICollection<Specie>> GetAllSpecies()
        {
            IEnumerable<Specie> results = new List<Specie>();
            var helper = new Helper<Specie>();
            var jsonResponse = await _httpClient.GetStringAsync( "api/species/?page=1" );
            helper = JsonConvert.DeserializeObject<Helper<Specie>>( jsonResponse );
            results = results.Union( helper.Results );
            return results.ToList();
        }

        public async Task<Specie> GetSpecieById( int id )
        {
            return JsonConvert.DeserializeObject<Specie>(
                await _httpClient.GetStringAsync( $"api/species/{id}" ) );
        }

        public async Task<ICollection<Planet>> GetAllPlanets()
        {
            IEnumerable<Planet> results = new List<Planet>();
            var helper = new Helper<Planet>();
            var jsonResponse = await _httpClient.GetStringAsync( "api/planets/?page=1" );
            helper = JsonConvert.DeserializeObject<Helper<Planet>>( jsonResponse );
            results = results.Union( helper.Results );
            return results.ToList();
        }
        public async Task<Planet> GetPlanetById( int id )
        {
            return JsonConvert.DeserializeObject<Planet>(
                await _httpClient.GetStringAsync( $"api/planets/{id}" ) );
        }

    }
}
