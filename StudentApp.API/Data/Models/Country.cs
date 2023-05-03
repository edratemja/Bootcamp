using CityApp.API.Data.Base;

namespace CityApp.API.Data.Models
{
    public class Country : BaseClass
    {
        public string Code { get; set; }
        public string Name { get; set; }

        //Define Reference with Cities table
        public List<City> Cities { get; set; }
    }
}
