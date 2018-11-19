namespace NutritionManager.Data.Entities
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public NutritionValues NutritionValue{get;set;}

    }
}
