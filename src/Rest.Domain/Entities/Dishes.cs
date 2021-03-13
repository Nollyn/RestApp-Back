using Rest.Domain.Entities.Base;
using System.Collections.Generic;

namespace Rest.Domain.Entities
{
    public class Dishes : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public int IdCategory { get; set; }

        public virtual Categories Categories { get; set; }

        public virtual ICollection<DishesOptions> DishesOptions { get; set; }
    }
}
