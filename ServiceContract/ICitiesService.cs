namespace ServiceContract
{
    public interface IcitiesService
        
    {
        List<string> GetCities();
        Guid _guid { get; set; }

    }
}
