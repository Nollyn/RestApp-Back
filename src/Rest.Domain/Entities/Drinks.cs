using Rest.Domain.Entities.Base;
using System.Collections.Generic;

namespace Rest.Domain.Entities
{
    public class Drinks : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<DrinksOptions> DrinksOptions { get; set; }
        public virtual ICollection<OrdersDrinks> OrdersDrinks { get; set; }
    }
}
