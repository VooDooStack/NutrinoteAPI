namespace Domain
{
    public class FoodItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ServingSize { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnailImageUrl { get; set; }
        public string IngredientsImageUrl { get; set; }
        public double Carbohydrates { get; set; }
        public string CarbohydratesUnit { get; set; }
        public double Calories { get; set; }
        public string CaloriesUnit { get; set; }
        public double Fat { get; set; }
        public string FatUnit { get; set; }
        public double FruitAndVegServings { get; set; }
        public double NovaGroup { get; set; }
        public double Protein { get; set; }
        public string ProteinUnit { get; set; }
        public double Salt { get; set; }
        public string SaltUnit { get; set; }
        public double SaturatedFat { get; set; }
        public string SaturatedFatUnit { get; set; }
        public double Sodium { get; set; }
        public string SodiumUnit { get; set; }
        public double Sugar { get; set; }
        public string SugarUnit { get; set; }
    }
}