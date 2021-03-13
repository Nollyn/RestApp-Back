using Rest.Domain.Entities.Base;

namespace Rest.Models
{
    public class RestaurantsMenusDto : BaseEntity
    {
        public int IdRestaurant { get; set; }
        public int IdMenu { get; set; }
    }
}
