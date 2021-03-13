using Rest.Domain.Entities.Base;

namespace Rest.Domain.Entities
{
    public class Tables : BaseEntity
    {
        public string Code { get; set; }
        public string QR { get; set; }
        public int IdRestaurant { get; set; }

        public virtual Restaurants Restaurants { get; set; }
    }
}
