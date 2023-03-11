namespace Domain;

public class Nutrients
{
    public Guid Id { get; set; }

    public double? Carbohydrates { get; set; }

    public double? Carbohydrates100G { get; set; }

    public long? CarbohydratesServing { get; set; }

    public string? CarbohydratesUnit { get; set; }

    public double? CarbohydratesValue { get; set; }

    public double? CarbonFootprintFromKnownIngredients100G { get; set; }

    public long? CarbonFootprintFromKnownIngredientsProduct { get; set; }

    public double? CarbonFootprintFromKnownIngredientsServing { get; set; }

    public long? Energy { get; set; }

    public long? EnergyKcal { get; set; }

    public long? EnergyKcal100G { get; set; }

    public long? EnergyKcalServing { get; set; }

    public string? EnergyKcalUnit { get; set; }

    public long? EnergyKcalValue { get; set; }

    public double? EnergyKcalValueComputed { get; set; }

    public long? EnergyKj { get; set; }

    public long? EnergyKj100G { get; set; }

    public long? EnergyKjServing { get; set; }

    public string? EnergyKjUnit { get; set; }

    public long? EnergyKjValue { get; set; }

    public double? EnergyKjValueComputed { get; set; }

    public long? Energy100G { get; set; }

    public long? EnergyServing { get; set; }

    public string? EnergyUnit { get; set; }

    public long? EnergyValue { get; set; }

    public double? Fat { get; set; }

    public double? Fat100G { get; set; }

    public double? FatServing { get; set; }

    public string? FatUnit { get; set; }

    public double? FatValue { get; set; }

    public double? Fiber { get; set; }

    public double? Fiber100G { get; set; }

    public double? FiberServing { get; set; }

    public string? FiberUnit { get; set; }

    public double? FiberValue { get; set; }

    public long? FruitsVegetablesNutsEstimateFromIngredients100G { get; set; }

    public long? FruitsVegetablesNutsEstimateFromIngredientsServing { get; set; }

    public long? NovaGroup { get; set; }

    public long? NovaGroup100G { get; set; }

    public long? NovaGroupServing { get; set; }

    public long? NutritionScoreFr { get; set; }

    public long? NutritionScoreFr100G { get; set; }

    public double? Proteins { get; set; }

    public double? Proteins100G { get; set; }

    public double? ProteinsServing { get; set; }

    public string? ProteinsUnit { get; set; }

    public double? ProteinsValue { get; set; }

    public double? Salt { get; set; }

    public double? Salt100G { get; set; }

    public double? SaltServing { get; set; }

    public string? SaltUnit { get; set; }

    public double? SaltValue { get; set; }

    public long? SaturatedFat { get; set; }

    public long? SaturatedFat100G { get; set; }

    public double? SaturatedFatServing { get; set; }

    public string? SaturatedFatUnit { get; set; }

    public long? SaturatedFatValue { get; set; }

    public double? Sodium { get; set; }

    public double? Sodium100G { get; set; }

    public double? SodiumServing { get; set; }

    public string? SodiumUnit { get; set; }

    public double? SodiumValue { get; set; }

    public double? Sugars { get; set; }

    public double? Sugars100G { get; set; }

    public double? SugarsServing { get; set; }

    public string? SugarsUnit { get; set; }

    public double? SugarsValue { get; set; }

    //nutrients from OpenFoodFacts Nutrition
    // public Nutrients(OpenFoodFacts.Nutriments nutriments)
    // {
    //         this.Carbohydrates = nutriments.Carbohydrates;
    //         this.Carbohydrates100G = nutriments.Carbohydrates100G;
    //         this.CarbohydratesServing = nutriments.CarbohydratesServing;
    //         this.CarbohydratesUnit = nutriments.CarbohydratesUnit;
    //         this.CarbohydratesValue = nutriments.CarbohydratesValue;
    //         this.CarbonFootprintFromKnownIngredients100G = nutriments.CarbonFootprintFromKnownIngredients100G;
    //         this.CarbonFootprintFromKnownIngredientsProduct = nutriments.CarbonFootprintFromKnownIngredientsProduct;
    //         this.CarbonFootprintFromKnownIngredientsServing = nutriments.CarbonFootprintFromKnownIngredientsServing;
    //         this.Energy = nutriments.Energy;
    //         this.EnergyKcal = nutriments.EnergyKcal;
    //         this.EnergyKcal100G = nutriments.EnergyKcal100G;
    //         this.EnergyKcalServing = nutriments.EnergyKcalServing;
    //         this.EnergyKcalUnit = nutriments.EnergyKcalUnit;
    //         this.EnergyKcalValue = nutriments.EnergyKcalValue;
    //         this.EnergyKcalValueComputed = nutriments.EnergyKcalValueComputed;
    //         this.EnergyKj = nutriments.EnergyKj;
    //         this.EnergyKj100G = nutriments.EnergyKj100G;
    //         this.EnergyKjServing = nutriments.EnergyKjServing;
    //         this.EnergyKjUnit = nutriments.EnergyKjUnit;
    //         this.EnergyKjValue = nutriments.EnergyKjValue;
    //         this.EnergyKjValueComputed = nutriments.EnergyKjValueComputed;
    //         this.Energy100G = nutriments.Energy100G;
    //         this.EnergyServing = nutriments.EnergyServing;
    //         this.EnergyUnit = nutriments.EnergyUnit;
    //         this.EnergyValue = nutriments.EnergyValue;
    //         this.Fat = nutriments.Fat;
    //         this.Fat100G = nutriments.Fat100G;
    //         this.FatServing = nutriments.FatServing;
    //         this.FatUnit = nutriments.FatUnit;
    //         this.FatValue = nutriments.FatValue;
    //         this.Fiber = nutriments.Fiber;
    //         this.Fiber100G = nutriments.Fiber100G;
    //         this.FiberServing = nutriments.FiberServing;
    //         this.FiberUnit = nutriments.FiberUnit;
    //         this.FiberValue = nutriments.FiberValue;
    //         this.FruitsVegetablesNutsEstimateFromIngredients100G = nutriments.FruitsVegetablesNutsEstimateFromIngredients100G;
    //         this.FruitsVegetablesNutsEstimateFromIngredientsServing = nutriments.FruitsVegetablesNutsEstimateFromIngredientsServing;
    //         this.NovaGroup = nutriments.NovaGroup;
    //         this.NovaGroup100G = nutriments.NovaGroup100G;
    //         this.NovaGroupServing = nutriments.NovaGroupServing;
    //         this.NutritionScoreFr = nutriments.NutritionScoreFr;
    //         this.NutritionScoreFr100G = nutriments.NutritionScoreFr100G;
    //         this.Proteins = nutriments.Proteins;
    //         this.Proteins100G = nutriments.Proteins100G;
    //         this.ProteinsServing = nutriments.ProteinsServing;
    //         this.ProteinsUnit = nutriments.ProteinsUnit;
    //         this.ProteinsValue = nutriments.ProteinsValue;
    //         this.Salt = nutriments.Salt;
    //         this.Salt100G = nutriments.Salt100G;
    //         this.SaltServing = nutriments.SaltServing;
    //         this.SaltUnit = nutriments.SaltUnit;
    //         this.SaltValue = nutriments.SaltValue;
    //         this.SaturatedFat = nutriments.SaturatedFat;
    //         this.SaturatedFat100G = nutriments.SaturatedFat100G;
    //         this.SaturatedFatServing = nutriments.SaturatedFatServing;
    //         this.SaturatedFatUnit = nutriments.SaturatedFatUnit;
    //         this.SaturatedFatValue = nutriments.SaturatedFatValue;
    //         this.Sodium = nutriments.Sodium;
    //         this.Sodium100G = nutriments.Sodium100G;
    //         this.SodiumServing = nutriments.SodiumServing;
    //         this.SodiumUnit = nutriments.SodiumUnit;
    //         this.SodiumValue = nutriments.SodiumValue;
    //         this.Sugars = nutriments.Sugars;
    //         this.Sugars100G = nutriments.Sugars100G;
    //         this.SugarsServing = nutriments.SugarsServing;
    //         this.SugarsUnit = nutriments.SugarsUnit;
    //         this.SugarsValue = nutriments.SugarsValue;
    // }
}