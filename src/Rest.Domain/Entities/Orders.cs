using Rest.Domain.Entities.Base;
using System.Collections.Generic;

namespace Rest.Domain.Entities
{
    public class Orders : BaseEntity
    {
        public string Code { get; set; }
        public decimal Amount { get; set; }

        public virtual ICollection<OrdersDiches> OrdersDiches { get; set; }
        public virtual ICollection<OrdersDrinks> OrdersDrinks { get; set; }
    }
}
