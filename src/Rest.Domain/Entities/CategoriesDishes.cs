using Rest.Domain.Entities.Base;

namespace Rest.Domain.Entities
{
    public class CategoriesDishes : BaseEntity
    {
        public int IdCategory { get; set; }
        public int IdDish { get; set; }

        public virtual Categories Categories { get; set; }
        public virtual Dishes Dishes { get; set; }
    }
}
