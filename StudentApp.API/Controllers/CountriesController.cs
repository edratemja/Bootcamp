using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CityApp.API.Data;
using CityApp.API.Data.DTOs.Country;
using CityApp.API.Data.Models;

namespace CityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private AppDbContext _appDbContext;
        public CountriesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        //Krijo nje API endpoint per te marre te dhenat nga DB
        [HttpGet("GetAllCountries")]
        public IActionResult GetAllCountries()
        {
            var allCountries = _appDbContext.Countries.ToList();

            return Ok(allCountries);
        }

        //Krijo nje API endpoint per te marre te dhenat nga DB
        [HttpGet("GetCountryById/{id}")]
        public IActionResult GetCountryById(int id)
        {
            var country = _appDbContext.Countries.FirstOrDefault(x => x.Id == id);
            
            if(country == null)
            {
                return NotFound();
            }

            return Ok(country);
        }
        
        [HttpPost("AddCountry")]
        public IActionResult AddCountry([FromBody] PostCountryDTO payload)
        {
            Country newCountry = new Country()
            {
                Name = payload.Name,
                Code = payload.Code,
                DateCreated = DateTime.UtcNow
            };

            _appDbContext.Countries.Add(newCountry);
            _appDbContext.SaveChanges();
            
            return Ok("Shteti u krijua me sukses!");
        }

        [HttpPut("UpdateCountry")]
        public IActionResult UpdateCountry([FromBody]PutCountryDTO payload, int id)
        {
            //1. Duke perdour ID marrim te dhenat nga databaza
            var country = _appDbContext.Countries.FirstOrDefault(x => x.Id == id);

            //2. Perditesojme Country e DB me te dhenat e payload-it
            if (country == null)
                return NotFound();

            country.Name = payload.Name;
            country.Code = payload.Code;

            //3. Ruhen te dhenat ne database
            _appDbContext.Countries.Update(country);
            _appDbContext.SaveChanges();

            return Ok();
        }

        [HttpDelete("DeleteCountry/{id}")]
        public IActionResult DeleteSubject(int id)
        {
            var subject = _appDbContext.Countries.FirstOrDefault(x => x.Id == id);

            if (subject == null)
                return NotFound();

            _appDbContext.Countries.Remove(subject);
            _appDbContext.SaveChanges();

            return Ok($"Shteti me id = {id} u fshi me sukses!");
        }
    }
}
