using Rest.Domain.Entities.Base;
using System.Collections.Generic;

namespace Rest.Domain.Entities
{
    public class Options : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }


        public virtual ICollection<DishesOptions> DishesOptions { get; set; }
        public virtual ICollection<DrinksOptions> DrinksOptions { get; set; }
        public virtual ICollection<MenusOptions> MenuOptions { get; set; }
    }
}
