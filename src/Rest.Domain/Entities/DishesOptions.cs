﻿namespace Rest.Domain.Entities
{
    public class DishesOptions
    {
        public int IdDish { get; set; }
        public int IdOption { get; set; }


        public virtual Options Options { get; set; }
        public virtual Dishes Dishes { get; set; }
    }
}
