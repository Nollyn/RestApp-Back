using Rest.Domain.Entities.Base;

namespace Rest.Domain.Entities
{
    public class MenuDishes : BaseEntity
    {
        public int IdDish { get; set; }
        public int IdMenu { get; set; }
        public int IdCategory { get; set; }
        public decimal Price { get; set; }


        public virtual Menus Menus { get; set; }
        public virtual Dishes Dishes { get; set; }
        public virtual Categories Categories { get; set; }
    }
}
