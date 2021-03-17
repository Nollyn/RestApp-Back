using Rest.Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace Rest.Domain.Entities
{
    public class Menus : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool DayMenu { get; set; }
        public int? IdMenuParent { get; set; }


        public virtual ICollection<RestaurantsMenus> RestaurantsMenus { get; set; }
        public virtual ICollection<MenusCategories> MenusCategories { get; set; }
        public virtual ICollection<MenusOptions> MenuOptions { get; set; }
    }
}
