using Rest.Domain.Entities.Base;
using System.Collections.Generic;

namespace Rest.Domain.Entities
{
    public class MenusCategories : BaseEntity
    {
        public int IdMenu { get; set; }
        public int IdCategory { get; set; }


        public virtual Categories Categories { get; set; }
        public virtual Menus Menus { get; set; }

        public virtual ICollection<MenusCategoriesDishes> MenusCategoriesDishes { get; set; }
    }
}
