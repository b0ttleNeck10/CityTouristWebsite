namespace CityTouristWebsite.Models.ViewModels
{
    public class TouristPlaceListViewModel
    {
        public IEnumerable<TouristPlace> Places { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public TouristPlace NewPlace { get; set; } = new TouristPlace();
    }
}
