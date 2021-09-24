namespace fattestSecret.Recipes.Models
{
    public class Recipe
    {
		public long Id { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public decimal Kcals { get; set; }
		public decimal Proteins { get; set; }
		public decimal Fats { get; set; }
		public decimal Carbohydrates { get; set; }
	}
}