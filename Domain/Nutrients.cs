namespace Domain;

public class Nutrients
{
    public Guid Id { get; set; }

    public double? Carbohydrates { get; set; }

    public double? Carbohydrates100G { get; set; }

    public double? CarbohydratesServing { get; set; }

    public string CarbohydratesUnit { get; set; }

    public double? CarbohydratesValue { get; set; }

    public double? CarbonFootprintFromKnownIngredients100G { get; set; }

    public double? CarbonFootprintFromKnownIngredientsProduct { get; set; }

    public double? CarbonFootprintFromKnownIngredientsServing { get; set; }

    public double? Energy { get; set; }

    public double? EnergyKcal { get; set; }

    public double? EnergyKcal100G { get; set; }

    public double? EnergyKcalServing { get; set; }

    public string EnergyKcalUnit { get; set; }

    public double? EnergyKcalValue { get; set; }

    public double? EnergyKcalValueComputed { get; set; }

    public double? EnergyKj { get; set; }

    public double? EnergyKj100G { get; set; }

    public double? EnergyKjServing { get; set; }

    public string EnergyKjUnit { get; set; }

    public double? EnergyKjValue { get; set; }

    public double? EnergyKjValueComputed { get; set; }

    public double? Energy100G { get; set; }

    public double? EnergyServing { get; set; }

    public string EnergyUnit { get; set; }

    public double? EnergyValue { get; set; }

    public double? Fat { get; set; }

    public double? Fat100G { get; set; }

    public double? FatServing { get; set; }

    public string FatUnit { get; set; }

    public double? FatValue { get; set; }

    public double? Fiber { get; set; }

    public double? Fiber100G { get; set; }

    public double? FiberServing { get; set; }

    public string FiberUnit { get; set; }

    public double? FiberValue { get; set; }

    public double? FruitsVegetablesNutsEstimateFromIngredients100G { get; set; }

    public double? FruitsVegetablesNutsEstimateFromIngredientsServing { get; set; }

    public double? NovaGroup { get; set; }

    public double? NovaGroup100G { get; set; }

    public double? NovaGroupServing { get; set; }

    public double? NutritionScoreFr { get; set; }

    public double? NutritionScoreFr100G { get; set; }

    public double? Proteins { get; set; }

    public double? Proteins100G { get; set; }

    public double? ProteinsServing { get; set; }

    public string ProteinsUnit { get; set; }

    public double? ProteinsValue { get; set; }

    public double? Salt { get; set; }

    public double? Salt100G { get; set; }

    public double? SaltServing { get; set; }

    public string SaltUnit { get; set; }

    public double? SaltValue { get; set; }

    public double? SaturatedFat { get; set; }

    public double? SaturatedFat100G { get; set; }

    public double? SaturatedFatServing { get; set; }

    public string SaturatedFatUnit { get; set; }

    public double? SaturatedFatValue { get; set; }

    public double? Sodium { get; set; }

    public double? Sodium100G { get; set; }

    public double? SodiumServing { get; set; }

    public string SodiumUnit { get; set; }

    public double? SodiumValue { get; set; }

    public double? Sugars { get; set; }

    public double? Sugars100G { get; set; }

    public double? SugarsServing { get; set; }

    public string SugarsUnit { get; set; }

    public double? SugarsValue { get; set; }

    public static Nutrients Map(OpenFoodFacts.Nutriments nutriments)
    {
        return new Nutrients
        {
            Carbohydrates = nutriments.Carbohydrates,
            Carbohydrates100G = nutriments.Carbohydrates100G,
            CarbohydratesServing = nutriments.CarbohydratesServing,
            CarbohydratesUnit = nutriments.CarbohydratesUnit,
            CarbohydratesValue = nutriments.CarbohydratesValue,
            CarbonFootprintFromKnownIngredients100G = nutriments.CarbonFootprintFromKnownIngredients100G,
            CarbonFootprintFromKnownIngredientsProduct = nutriments.CarbonFootprintFromKnownIngredientsProduct,
            CarbonFootprintFromKnownIngredientsServing = nutriments.CarbonFootprintFromKnownIngredientsServing,
            Energy = nutriments.Energy,
            EnergyKcal = nutriments.EnergyKcal,
            EnergyKcal100G = nutriments.EnergyKcal100G,
            EnergyKcalServing = nutriments.EnergyKcalServing,
            EnergyKcalUnit = nutriments.EnergyKcalUnit,
            EnergyKcalValue = nutriments.EnergyKcalValue,
            EnergyKcalValueComputed = nutriments.EnergyKcalValueComputed,
            EnergyKj = nutriments.EnergyKj,
            EnergyKj100G = nutriments.EnergyKj100G,
            EnergyKjServing = nutriments.EnergyKjServing,
            EnergyKjUnit = nutriments.EnergyKjUnit,
            EnergyKjValue = nutriments.EnergyKjValue,
            EnergyKjValueComputed = nutriments.EnergyKjValueComputed,
            Energy100G = nutriments.Energy100G,
            EnergyServing = nutriments.EnergyServing,
            EnergyUnit = nutriments.EnergyUnit,
            EnergyValue = nutriments.EnergyValue,
            Fat = nutriments.Fat,
            Fat100G = nutriments.Fat100G,
            FatServing = nutriments.FatServing,
            FatUnit = nutriments.FatUnit,
            FatValue = nutriments.FatValue,
            Fiber = nutriments.Fiber,
            Fiber100G = nutriments.Fiber100G
        };
    }
}