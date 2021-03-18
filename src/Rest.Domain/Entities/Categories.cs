using Rest.Domain.Entities.Base;
using System.Collections.Generic;

namespace Rest.Domain.Entities
{
    public class Categories : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Extras> Extras { get; set; }

        public virtual ICollection<Dishes> Dishes { get; set; }

        public virtual ICollection<MenusCategories> MenusCategories { get; set; }
        public virtual ICollection<CategoriesDishes> CategoriesDishes { get; set; }
    }
}
