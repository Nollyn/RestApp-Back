using Rest.Domain.Entities.Base;

namespace Rest.Domain.Entities
{
    public class Extras : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int IdCategory { get; set; }

        public virtual Categories Categories { get; set; }
    }
}
