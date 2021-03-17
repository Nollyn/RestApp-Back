using Rest.Domain.Entities.Base;

namespace Rest.Domain.Entities
{
    public class MenusOptions : BaseEntity
    {
        public int IdOption { get; set; }
        public int IdMenu { get; set; }

        public virtual Menus Menus { get; set; }
        public virtual Options Options { get; set; }
    }
}
