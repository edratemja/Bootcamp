﻿namespace CityApp.API.Data.DTOs.City
{
    public class PutCityDTO
    {
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string Region { get; set; }
        public string Muncipality { get; set; }
        public string County { get; set; }
        public DateTime DOB { get; set; }

        //Add a reference to Country table
        public int CountryId { get; set; }
    }
}
