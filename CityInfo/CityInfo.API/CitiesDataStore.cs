using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {

        public List<CityDto> cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            cities = new List<CityDto>();
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Discription = "The one with the big park",

                };
                new CityDto()
                {
                    Id = 2,
                    Name = "AntWrep",
                    Discription = "The one with the big Tower"

                };
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Discription = "The one with the big Theater"

                };
            }
        }

    }
}