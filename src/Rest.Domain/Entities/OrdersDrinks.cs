namespace Rest.Domain.Entities
{
    public class OrdersDrinks
    {
        public int IdOrder { get; set; }
        public int IdDrink { get; set; }

        public virtual Drinks Drinks { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
