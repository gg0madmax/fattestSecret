namespace fattestSecret.Products.Models
{
    public class CreationProductRequest
    {
        public string Name { get; set; }
        public decimal Kcals { get; set; }
        public decimal Proteins { get; set; }
        public decimal Fats { get; set; }
        public decimal Carbohydrates { get; set; }
    }
}