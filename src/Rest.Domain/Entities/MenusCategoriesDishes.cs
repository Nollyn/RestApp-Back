using Rest.Domain.Entities.Base;

namespace Rest.Domain.Entities
{
    public class MenusCategoriesDishes : BaseEntity
    {
        public int IdMenuCategory { get; set; }
        public int IdDish { get; set; }


        public virtual Dishes Dishes { get; set; }
        public virtual MenusCategories MenusCategories { get; set; }
    }
}
