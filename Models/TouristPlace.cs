using System.ComponentModel.DataAnnotations.Schema;

namespace CityTouristWebsite.Models
{
    public class TouristPlace
    {
        public int Id { get; set; }
        public string PlaceName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Tips { get; set; } = string.Empty;
        public string IframeLink { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }
}
