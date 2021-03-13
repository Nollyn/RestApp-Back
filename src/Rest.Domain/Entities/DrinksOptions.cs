using Rest.Domain.Entities.Base;

namespace Rest.Domain.Entities
{
    public class DrinksOptions : BaseEntity
    {
        public int IdDrink { get; set; }
        public int IdOption { get; set; }


        public virtual Drinks Drinks { get; set; }
        public virtual Options Options { get; set; }
    }
}
