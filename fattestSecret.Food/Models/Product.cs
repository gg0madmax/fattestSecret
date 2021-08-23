using System;

namespace fattestSecret.Food.Models
{
    public class Product
    {
        public int Id {get; set;}
        public string Name { get; set; }
        public decimal Kcals { get; set; }
        public decimal Proteins { get; set; }
        public decimal Fats { get; set; }
        public decimal Carbohydrates { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
