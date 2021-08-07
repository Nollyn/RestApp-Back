using Rest.Models.Base;

namespace Rest.Models
{
    public class RestaurantsMenusDto : BaseDto
    {
        public int IdRestaurant { get; set; }
        public int IdMenu { get; set; }
    }
}
