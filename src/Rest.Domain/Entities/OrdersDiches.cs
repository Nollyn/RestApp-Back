namespace Rest.Domain.Entities
{
    public class OrdersDiches
    {
        public int IdDish { get; set; }
        public int IdOrder { get; set; }

        public virtual Dishes Dishes { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
