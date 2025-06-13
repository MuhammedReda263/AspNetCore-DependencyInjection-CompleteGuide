using ServiceContract;

namespace Services
{
    public class CitiesService : IcitiesService
    {
        private List<string> cities;
        public Guid _guid { get; set; }
   

       

        public CitiesService() { 
        cities = new List<string>()
        {
            "London",
            "Cairo",
            "Tokio"

        };
            _guid = Guid.NewGuid();
        }

        public List<string> GetCities()
        
            {
                return cities;
            }
    }
}
