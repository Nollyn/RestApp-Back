using Rest.Domain.Entities.Base;
using System.Collections.Generic;

namespace Rest.Domain.Entities
{
    public class Restaurants : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string NIF { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }


        public virtual ICollection<Tables> Tables { get; set; }
        public virtual ICollection<RestaurantsMenus> RestaurantsMenus { get; set; }
    }
}
