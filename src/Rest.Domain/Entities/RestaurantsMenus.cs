namespace Rest.Domain.Entities
{
    public class RestaurantsMenus
    {
        public int IdMenu { get; set; }
        public int IdRestaurant { get; set; }


        public virtual Menus Menus { get; set; }
        public virtual Restaurants Restaurants { get; set; }
    }
}
