using Microsoft.AspNetCore.Mvc;
using CityApp.API.Data;
using CityApp.API.Data.DTOs.City;
using CityApp.API.Data.Models;
using CityApp.API.Data.DTOs.City;

namespace CityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private AppDbContext _appDbContext;
        public CitiesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        //Krijo nje API endpoint per te marre te dhenat nga DB
        [HttpGet("GetAllCities")]
        public IActionResult GetAllCities()
        {
            var allCities = _appDbContext.Cities.ToList();
            return Ok(allCities);
        }

        //Krijo nje API endpoint per te marre te dhenat nga DB
        [HttpGet("GetCityById/{id}")]
        public IActionResult GetCityById(int id)
        {
            var student = _appDbContext.Cities.FirstOrDefault(x => x.Id == id);
            return Ok($"Qyteti me id = {id} u kthye me sukses!");
        }

        [HttpPost("AddCity")]
        public IActionResult AddStudent([FromBody] PostCityDTO payload)
        {
            //1. Krijo nje objekt City me te dhenat e marra nga payload
            City newCity = new City()
            {
                CityCode = payload.CityCode,
                CityName = payload.CityName,
                Region = payload.Region,
                Muncipality= payload.Muncipality,
                County= payload.County,
                DOB = DateTime.UtcNow.AddYears(-20),
                
                DateCreated = DateTime.UtcNow,

                CountryId = payload.CountryId
            };

            _appDbContext.Cities.Add(newCity);
            _appDbContext.SaveChanges();

            return Ok("Qyteti u krijua me sukses!");
        }

        [HttpPut("UpdateCity")]
        public IActionResult UpdateCity([FromBody]PutCityDTO payload, int id)
        {
            //1. Duke perdour ID marrim te dhenat nga databaza
            var city = _appDbContext.Cities.FirstOrDefault(x => x.Id == id);
            if (city == null)
                return NotFound();

            //2. Perditesojme Qytetin e DB me te dhenat e payload-it
            city.CityCode = payload.CityCode;
            city.CityName = payload.CityName;
            city.Region = payload.Region;
            city.Muncipality = payload.Muncipality;
            city.County = payload.County;
            city.DOB = DateTime.UtcNow.AddYears(-20);

            //Add Refrence to Country Id
            city.CountryId = payload.CountryId;

            //3. Ruhen te dhenat ne database
            _appDbContext.Cities.Update(city);
            _appDbContext.SaveChanges();

            return Ok("Qyteti u modifikua me sukses!");
        }

        [HttpDelete("DeleteCity/{id}")]
        public IActionResult DeleteCity(int id)
        {
            //1. Duke perdour ID marrim te dhenat nga databaza
            var student = _appDbContext.Cities.FirstOrDefault(x => x.Id == id);
            if (student == null)
                return NotFound();

            //2. Fshijme qyetetin nga DB
            _appDbContext.Cities.Remove(student);
            _appDbContext.SaveChanges();

            return Ok($"Qyteti me id = {id} u fshi me sukses!");
        }
    }
}
