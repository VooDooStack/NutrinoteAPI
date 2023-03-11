using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OpenFoodFacts;

public partial class OpenFoodFact
{
    [JsonProperty("code")] public string? Code { get; set; }

    [JsonProperty("product")] public Product Product { get; set; }

    [JsonProperty("status")] public long? Status { get; set; }

    [JsonProperty("status_verbose")] public string? StatusVerbose { get; set; }
}

public class Product
{
    [JsonProperty("_id")] public string? Id { get; set; }

    [JsonProperty("_keywords")] public string?[] Keywords { get; set; }

    [JsonProperty("abbreviated_product_name_fr")]
    public string? AbbreviatedProductNameFr { get; set; }

    [JsonProperty("abbreviated_product_name_fr_imported")]
    public string? AbbreviatedProductNameFrImported { get; set; }

    [JsonProperty("abbreviated_product_name_imported")]
    public string? AbbreviatedProductNameImported { get; set; }

    [JsonProperty("added_countries_tags")] public object?[] AddedCountriesTags { get; set; }

    [JsonProperty("additives_n")] public long? AdditivesN { get; set; }

    [JsonProperty("additives_old_n")] public long? AdditivesOldN { get; set; }

    [JsonProperty("additives_old_tags")] public object?[] AdditivesOldTags { get; set; }

    [JsonProperty("additives_original_tags")]
    public string?[] AdditivesOriginalTags { get; set; }

    [JsonProperty("additives_tags")] public string?[] AdditivesTags { get; set; }

    [JsonProperty("allergens")] public string? Allergens { get; set; }

    [JsonProperty("allergens_from_ingredients")]
    public string? AllergensFromIngredients { get; set; }

    [JsonProperty("allergens_from_user")] public string? AllergensFromUser { get; set; }

    [JsonProperty("allergens_hierarchy")] public string?[] AllergensHierarchy { get; set; }

    [JsonProperty("allergens_imported")] public string? AllergensImported { get; set; }

    [JsonProperty("allergens_lc")] public string? AllergensLc { get; set; }

    [JsonProperty("allergens_tags")] public string?[] AllergensTags { get; set; }

    [JsonProperty("amino_acids_tags")] public object?[] AminoAcidsTags { get; set; }

    [JsonProperty("brands")] public string? Brands { get; set; }

    [JsonProperty("brands_imported")] public string? BrandsImported { get; set; }

    [JsonProperty("brands_tags")] public string?[] BrandsTags { get; set; }

    [JsonProperty("carbon_footprint_from_known_ingredients_debug")]
    public string? CarbonFootprintFromKnownIngredientsDebug { get; set; }

    [JsonProperty("carbon_footprint_percent_of_known_ingredients")]
    public double? CarbonFootprintPercentOfKnownIngredients { get; set; }

    [JsonProperty("categories")] public string? Categories { get; set; }

    [JsonProperty("categories_hierarchy")] public string?[] CategoriesHierarchy { get; set; }

    [JsonProperty("categories_lc")] public string? CategoriesLc { get; set; }

    [JsonProperty("categories_old")] public string? CategoriesOld { get; set; }

    [JsonProperty("categories_properties")]
    public CategoriesProperties CategoriesProperties { get; set; }

    [JsonProperty("categories_properties_tags")]
    public string?[] CategoriesPropertiesTags { get; set; }

    [JsonProperty("categories_tags")] public string?[] CategoriesTags { get; set; }

    [JsonProperty("category_properties")] public CategoryProperties CategoryProperties { get; set; }

    [JsonProperty("checkers_tags")] public object?[] CheckersTags { get; set; }

    [JsonProperty("ciqual_food_name_tags")]
    public string?[] CiqualFoodNameTags { get; set; }

    [JsonProperty("cities_tags")] public object?[] CitiesTags { get; set; }

    [JsonProperty("code")] public string? Code { get; set; }

    [JsonProperty("codes_tags")] public string?[] CodesTags { get; set; }

    [JsonProperty("compared_to_category")] public string? ComparedToCategory { get; set; }

    [JsonProperty("complete")] public long? Complete { get; set; }

    [JsonProperty("completeness")] public double? Completeness { get; set; }

    [JsonProperty("conservation_conditions_fr")]
    public string? ConservationConditionsFr { get; set; }

    [JsonProperty("conservation_conditions_fr_imported")]
    public string? ConservationConditionsFrImported { get; set; }

    [JsonProperty("correctors_tags")] public string?[] CorrectorsTags { get; set; }

    [JsonProperty("countries")] public string? Countries { get; set; }

    [JsonProperty("countries_beforescanbot")]
    public string? CountriesBeforescanbot { get; set; }

    [JsonProperty("countries_hierarchy")] public string?[] CountriesHierarchy { get; set; }

    [JsonProperty("countries_imported")] public string? CountriesImported { get; set; }

    [JsonProperty("countries_lc")] public string? CountriesLc { get; set; }

    [JsonProperty("countries_tags")] public string?[] CountriesTags { get; set; }

    [JsonProperty("created_t")] public long? CreatedT { get; set; }

    [JsonProperty("creator")] public string? Creator { get; set; }

    [JsonProperty("customer_service_fr")] public string? CustomerServiceFr { get; set; }

    [JsonProperty("customer_service_fr_imported")]
    public string? CustomerServiceFrImported { get; set; }

    [JsonProperty("data_quality_bugs_tags")]
    public object?[] DataQualityBugsTags { get; set; }

    [JsonProperty("data_quality_errors_tags")]
    public object?[] DataQualityErrorsTags { get; set; }

    [JsonProperty("data_quality_info_tags")]
    public string?[] DataQualityInfoTags { get; set; }

    [JsonProperty("data_quality_tags")] public string?[] DataQualityTags { get; set; }

    [JsonProperty("data_quality_warnings_tags")]
    public string?[] DataQualityWarningsTags { get; set; }

    [JsonProperty("data_sources")] public string? DataSources { get; set; }

    [JsonProperty("data_sources_imported")]
    public string? DataSourcesImported { get; set; }

    [JsonProperty("data_sources_tags")] public string?[] DataSourcesTags { get; set; }

    [JsonProperty("debug_param_sorted_langs")]
    public string?[] DebugParamSortedLangs { get; set; }

    [JsonProperty("ecoscore_data")] public EcoscoreData EcoscoreData { get; set; }

    [JsonProperty("ecoscore_extended_data")]
    public EcoscoreExtendedData EcoscoreExtendedData { get; set; }

    [JsonProperty("ecoscore_extended_data_version")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? EcoscoreExtendedDataVersion { get; set; }

    [JsonProperty("ecoscore_grade")] public EcoscoreGrade EcoscoreGrade { get; set; }

    [JsonProperty("ecoscore_score")] public long? EcoscoreScore { get; set; }

    [JsonProperty("ecoscore_tags")] public EcoscoreGrade[] EcoscoreTags { get; set; }

    [JsonProperty("editors_tags")] public string?[] EditorsTags { get; set; }

    [JsonProperty("emb_codes")] public string? EmbCodes { get; set; }

    [JsonProperty("emb_codes_tags")] public object?[] EmbCodesTags { get; set; }

    [JsonProperty("entry_dates_tags")] public string?[] EntryDatesTags { get; set; }

    [JsonProperty("expiration_date")] public string? ExpirationDate { get; set; }

    [JsonProperty("food_groups")] public string? FoodGroups { get; set; }

    [JsonProperty("food_groups_tags")] public string?[] FoodGroupsTags { get; set; }

    [JsonProperty("generic_name_de")] public string? GenericNameDe { get; set; }

    [JsonProperty("generic_name_en")] public string? GenericNameEn { get; set; }

    [JsonProperty("generic_name_fr")] public string? GenericNameFr { get; set; }

    [JsonProperty("generic_name_fr_imported")]
    public string? GenericNameFrImported { get; set; }

    [JsonProperty("generic_name_it")] public string? GenericNameIt { get; set; }

    [JsonProperty("grades")] public CategoryProperties Grades { get; set; }

    [JsonProperty("id")] public string? ProductId { get; set; }

    [JsonProperty("image_front_small_url")]
    public Uri? ImageFrontSmallUrl { get; set; }

    [JsonProperty("image_front_thumb_url")]
    public Uri? ImageFrontThumbUrl { get; set; }

    [JsonProperty("image_front_url")] public Uri? ImageFrontUrl { get; set; }

    [JsonProperty("image_small_url")] public Uri? ImageSmallUrl { get; set; }

    [JsonProperty("image_thumb_url")] public Uri? ImageThumbUrl { get; set; }

    [JsonProperty("image_url")] public Uri? ImageUrl { get; set; }

    [JsonProperty("images")] public Images Images { get; set; }

    [JsonProperty("informers_tags")] public string?[] InformersTags { get; set; }

    [JsonProperty("ingredients")] public ProductIngredient[] Ingredients { get; set; }

    [JsonProperty("ingredients_analysis")] public IngredientsAnalysis IngredientsAnalysis { get; set; }

    [JsonProperty("ingredients_analysis_tags")]
    public string?[] IngredientsAnalysisTags { get; set; }

    [JsonProperty("ingredients_from_or_that_may_be_from_palm_oil_n")]
    public long? IngredientsFromOrThatMayBeFromPalmOilN { get; set; }

    [JsonProperty("ingredients_from_palm_oil_n")]
    public long? IngredientsFromPalmOilN { get; set; }

    [JsonProperty("ingredients_from_palm_oil_tags")]
    public object?[] IngredientsFromPalmOilTags { get; set; }

    [JsonProperty("ingredients_hierarchy")]
    public string?[] IngredientsHierarchy { get; set; }

    [JsonProperty("ingredients_n")] public long? IngredientsN { get; set; }

    [JsonProperty("ingredients_n_tags")] public string?[] IngredientsNTags { get; set; }

    [JsonProperty("ingredients_original_tags")]
    public string?[] IngredientsOriginalTags { get; set; }

    [JsonProperty("ingredients_percent_analysis")]
    public long? IngredientsPercentAnalysis { get; set; }

    [JsonProperty("ingredients_tags")] public string?[] IngredientsTags { get; set; }

    [JsonProperty("ingredients_text")] public string? IngredientsText { get; set; }

    [JsonProperty("ingredients_text_de")] public string? IngredientsTextDe { get; set; }

    [JsonProperty("ingredients_text_en")] public string? IngredientsTextEn { get; set; }

    [JsonProperty("ingredients_text_fr")] public string? IngredientsTextFr { get; set; }

    [JsonProperty("ingredients_text_fr_imported")]
    public string? IngredientsTextFrImported { get; set; }

    [JsonProperty("ingredients_text_it")] public string? IngredientsTextIt { get; set; }

    [JsonProperty("ingredients_text_with_allergens")]
    public string? IngredientsTextWithAllergens { get; set; }

    [JsonProperty("ingredients_text_with_allergens_de")]
    public string? IngredientsTextWithAllergensDe { get; set; }

    [JsonProperty("ingredients_text_with_allergens_en")]
    public string? IngredientsTextWithAllergensEn { get; set; }

    [JsonProperty("ingredients_text_with_allergens_fr")]
    public string? IngredientsTextWithAllergensFr { get; set; }

    [JsonProperty("ingredients_text_with_allergens_it")]
    public string? IngredientsTextWithAllergensIt { get; set; }

    [JsonProperty("ingredients_that_may_be_from_palm_oil_n")]
    public long? IngredientsThatMayBeFromPalmOilN { get; set; }

    [JsonProperty("ingredients_that_may_be_from_palm_oil_tags")]
    public object?[] IngredientsThatMayBeFromPalmOilTags { get; set; }

    [JsonProperty("ingredients_with_specified_percent_n")]
    public long? IngredientsWithSpecifiedPercentN { get; set; }

    [JsonProperty("ingredients_with_specified_percent_sum")]
    public double? IngredientsWithSpecifiedPercentSum { get; set; }

    [JsonProperty("ingredients_with_unspecified_percent_n")]
    public long? IngredientsWithUnspecifiedPercentN { get; set; }

    [JsonProperty("ingredients_with_unspecified_percent_sum")]
    public double? IngredientsWithUnspecifiedPercentSum { get; set; }

    [JsonProperty("interface_version_created")]
    public string? InterfaceVersionCreated { get; set; }

    [JsonProperty("interface_version_modified")]
    public string? InterfaceVersionModified { get; set; }

    [JsonProperty("known_ingredients_n")] public long? KnownIngredientsN { get; set; }

    [JsonProperty("labels")] public string? Labels { get; set; }

    [JsonProperty("labels_hierarchy")] public string?[] LabelsHierarchy { get; set; }

    [JsonProperty("labels_lc")] public string? LabelsLc { get; set; }

    [JsonProperty("labels_old")] public string? LabelsOld { get; set; }

    [JsonProperty("labels_tags")] public string?[] LabelsTags { get; set; }

    [JsonProperty("lang")] public string? Lang { get; set; }

    [JsonProperty("lang_imported")] public string? LangImported { get; set; }

    [JsonProperty("languages")] public Languages Languages { get; set; }

    [JsonProperty("languages_codes")] public LanguagesCodes LanguagesCodes { get; set; }

    [JsonProperty("languages_hierarchy")] public string?[] LanguagesHierarchy { get; set; }

    [JsonProperty("languages_tags")] public string?[] LanguagesTags { get; set; }

    [JsonProperty("last_edit_dates_tags")] public string?[] LastEditDatesTags { get; set; }

    [JsonProperty("last_editor")] public string? LastEditor { get; set; }

    [JsonProperty("last_image_dates_tags")]
    public string?[] LastImageDatesTags { get; set; }

    [JsonProperty("last_image_t")] public long? LastImageT { get; set; }

    [JsonProperty("last_modified_by")] public string? LastModifiedBy { get; set; }

    [JsonProperty("last_modified_t")] public long? LastModifiedT { get; set; }

    [JsonProperty("lc")] public string? Lc { get; set; }

    [JsonProperty("lc_imported")] public string? LcImported { get; set; }

    [JsonProperty("link")] public string? Link { get; set; }

    [JsonProperty("main_countries_tags")] public object?[] MainCountriesTags { get; set; }

    [JsonProperty("manufacturing_places")] public string? ManufacturingPlaces { get; set; }

    [JsonProperty("manufacturing_places_tags")]
    public string?[] ManufacturingPlacesTags { get; set; }

    [JsonProperty("max_imgid")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? MaxImgid { get; set; }

    [JsonProperty("minerals_tags")] public object?[] MineralsTags { get; set; }

    [JsonProperty("misc_tags")] public string?[] MiscTags { get; set; }

    [JsonProperty("no_nutrition_data")] public string? NoNutritionData { get; set; }

    [JsonProperty("no_nutrition_data_imported")]
    [JsonConverter(typeof(FluffyParseStringConverter))]
    public bool NoNutritionDataImported { get; set; }

    [JsonProperty("nova_group")] public long? NovaGroup { get; set; }

    [JsonProperty("nova_group_debug")] public string? NovaGroupDebug { get; set; }

    [JsonProperty("nova_groups")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? NovaGroups { get; set; }

    [JsonProperty("nova_groups_markers")] public Dictionary<string, string[][]> NovaGroupsMarkers { get; set; }

    [JsonProperty("nova_groups_tags")] public string?[] NovaGroupsTags { get; set; }

    [JsonProperty("nucleotides_tags")] public object?[] NucleotidesTags { get; set; }

    [JsonProperty("nutrient_levels")] public NutrientLevels NutrientLevels { get; set; }

    [JsonProperty("nutrient_levels_tags")] public string?[] NutrientLevelsTags { get; set; }

    [JsonProperty("nutriments")] public Nutriments Nutriments { get; set; }

    [JsonProperty("nutriscore_data")] public NutriscoreData NutriscoreData { get; set; }

    [JsonProperty("nutriscore_grade")] public string? NutriscoreGrade { get; set; }

    [JsonProperty("nutriscore_score")] public long? NutriscoreScore { get; set; }

    [JsonProperty("nutriscore_score_opposite")]
    public long? NutriscoreScoreOpposite { get; set; }

    [JsonProperty("nutrition_data")] public string? NutritionData { get; set; }

    [JsonProperty("nutrition_data_per")] public string? NutritionDataPer { get; set; }

    [JsonProperty("nutrition_data_per_imported")]
    public string? NutritionDataPerImported { get; set; }

    [JsonProperty("nutrition_data_prepared")]
    public string? NutritionDataPrepared { get; set; }

    [JsonProperty("nutrition_data_prepared_per")]
    public string? NutritionDataPreparedPer { get; set; }

    [JsonProperty("nutrition_grade_fr")] public string? NutritionGradeFr { get; set; }

    [JsonProperty("nutrition_grades")] public string? NutritionGrades { get; set; }

    [JsonProperty("nutrition_grades_tags")]
    public string?[] NutritionGradesTags { get; set; }

    [JsonProperty("nutrition_score_beverage")]
    public long? NutritionScoreBeverage { get; set; }

    [JsonProperty("nutrition_score_debug")]
    public string? NutritionScoreDebug { get; set; }

    [JsonProperty("nutrition_score_warning_fruits_vegetables_nuts_estimate_from_ingredients")]
    public long? NutritionScoreWarningFruitsVegetablesNutsEstimateFromIngredients { get; set; }

    [JsonProperty("nutrition_score_warning_fruits_vegetables_nuts_estimate_from_ingredients_value")]
    public long? NutritionScoreWarningFruitsVegetablesNutsEstimateFromIngredientsValue { get; set; }

    [JsonProperty("obsolete")] public string? Obsolete { get; set; }

    [JsonProperty("obsolete_imported")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? ObsoleteImported { get; set; }

    [JsonProperty("obsolete_since_date")] public string? ObsoleteSinceDate { get; set; }

    [JsonProperty("origin_de")] public string? OriginDe { get; set; }

    [JsonProperty("origin_en")] public string? OriginEn { get; set; }

    [JsonProperty("origin_fr")] public string? OriginFr { get; set; }

    [JsonProperty("origin_it")] public string? OriginIt { get; set; }

    [JsonProperty("origins")] public string? Origins { get; set; }

    [JsonProperty("origins_hierarchy")] public string?[] OriginsHierarchy { get; set; }

    [JsonProperty("origins_lc")] public string? OriginsLc { get; set; }

    [JsonProperty("origins_old")] public string? OriginsOld { get; set; }

    [JsonProperty("origins_tags")] public string?[] OriginsTags { get; set; }

    [JsonProperty("other_nutritional_substances_tags")]
    public object?[] OtherNutritionalSubstancesTags { get; set; }

    [JsonProperty("owner")] public Owner Owner { get; set; }

    [JsonProperty("owner_fields")] public Dictionary<string, long> OwnerFields { get; set; }

    [JsonProperty("owner_imported")] public Owner OwnerImported { get; set; }

    [JsonProperty("owners_tags")] public Owner OwnersTags { get; set; }

    [JsonProperty("packaging")] public string? Packaging { get; set; }

    [JsonProperty("packaging_hierarchy")] public string?[] PackagingHierarchy { get; set; }

    [JsonProperty("packaging_imported")] public string? PackagingImported { get; set; }

    [JsonProperty("packaging_lc")] public string? PackagingLc { get; set; }

    [JsonProperty("packaging_old")] public string? PackagingOld { get; set; }

    [JsonProperty("packaging_old_before_taxonomization")]
    public string? PackagingOldBeforeTaxonomization { get; set; }

    [JsonProperty("packaging_tags")] public string?[] PackagingTags { get; set; }

    [JsonProperty("packaging_text_de")] public string? PackagingTextDe { get; set; }

    [JsonProperty("packaging_text_en")] public string? PackagingTextEn { get; set; }

    [JsonProperty("packaging_text_fr")] public string? PackagingTextFr { get; set; }

    [JsonProperty("packaging_text_it")] public string? PackagingTextIt { get; set; }

    [JsonProperty("packagings")] public ProductPackaging[] Packagings { get; set; }

    [JsonProperty("photographers_tags")] public string?[] PhotographersTags { get; set; }

    [JsonProperty("pnns_groups_1")] public string? PnnsGroups1 { get; set; }

    [JsonProperty("pnns_groups_1_tags")] public string?[] PnnsGroups1_Tags { get; set; }

    [JsonProperty("pnns_groups_2")] public string? PnnsGroups2 { get; set; }

    [JsonProperty("pnns_groups_2_tags")] public string?[] PnnsGroups2_Tags { get; set; }

    [JsonProperty("popularity_key")] public long? PopularityKey { get; set; }

    [JsonProperty("popularity_tags")] public string?[] PopularityTags { get; set; }

    [JsonProperty("producer_version_id")] public DateTimeOffset ProducerVersionId { get; set; }

    [JsonProperty("producer_version_id_imported")]
    public DateTimeOffset ProducerVersionIdImported { get; set; }

    [JsonProperty("product_name_de")] public string? ProductNameDe { get; set; }

    [JsonProperty("product_name_en")] public string? ProductNameEn { get; set; }

    [JsonProperty("product_name_fr")] public string? ProductNameFr { get; set; }

    [JsonProperty("product_name_fr_imported")]
    public string? ProductNameFrImported { get; set; }

    [JsonProperty("product_name_it")] public string? ProductNameIt { get; set; }

    [JsonProperty("product_quantity")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? ProductQuantity { get; set; }

    [JsonProperty("purchase_places")] public string? PurchasePlaces { get; set; }

    [JsonProperty("purchase_places_tags")] public string?[] PurchasePlacesTags { get; set; }

    [JsonProperty("quantity")] public string? Quantity { get; set; }

    [JsonProperty("quantity_imported")] public string? QuantityImported { get; set; }

    [JsonProperty("removed_countries_tags")]
    public object?[] RemovedCountriesTags { get; set; }

    [JsonProperty("rev")] public long? Rev { get; set; }

    [JsonProperty("scans_n")] public long? ScansN { get; set; }

    [JsonProperty("scores")] public CategoryProperties Scores { get; set; }

    [JsonProperty("selected_images")] public SelectedImages SelectedImages { get; set; }

    [JsonProperty("serving_quantity")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? ServingQuantity { get; set; }

    [JsonProperty("serving_size")] public string? ServingSize { get; set; }

    [JsonProperty("serving_size_imported")]
    public string? ServingSizeImported { get; set; }

    [JsonProperty("sortkey")] public long? Sortkey { get; set; }

    [JsonProperty("sources")] public Source[] Sources { get; set; }

    [JsonProperty("sources_fields")] public SourcesFields SourcesFields { get; set; }

    [JsonProperty("states")] public string? States { get; set; }

    [JsonProperty("states_hierarchy")] public string?[] StatesHierarchy { get; set; }

    [JsonProperty("states_tags")] public string?[] StatesTags { get; set; }

    [JsonProperty("stores")] public string? Stores { get; set; }

    [JsonProperty("stores_tags")] public string?[] StoresTags { get; set; }

    [JsonProperty("teams")] public string? Teams { get; set; }

    [JsonProperty("teams_tags")] public string?[] TeamsTags { get; set; }

    [JsonProperty("traces")] public string? Traces { get; set; }

    [JsonProperty("traces_from_ingredients")]
    public string? TracesFromIngredients { get; set; }

    [JsonProperty("traces_from_user")] public string? TracesFromUser { get; set; }

    [JsonProperty("traces_hierarchy")] public string?[] TracesHierarchy { get; set; }

    [JsonProperty("traces_lc")] public string? TracesLc { get; set; }

    [JsonProperty("traces_tags")] public string?[] TracesTags { get; set; }

    [JsonProperty("unique_scans_n")] public long? UniqueScansN { get; set; }

    [JsonProperty("unknown_ingredients_n")]
    public long? UnknownIngredientsN { get; set; }

    [JsonProperty("unknown_nutrients_tags")]
    public object?[] UnknownNutrientsTags { get; set; }

    [JsonProperty("update_key")] public string? UpdateKey { get; set; }

    [JsonProperty("vitamins_tags")] public object?[] VitaminsTags { get; set; }

    [JsonProperty("weighers_tags")] public object?[] WeighersTags { get; set; }
}

public class CategoriesProperties
{
    [JsonProperty("agribalyse_proxy_food_code:en")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? AgribalyseProxyFoodCodeEn { get; set; }
}

public class CategoryProperties
{
}

public class EcoscoreData
{
    [JsonProperty("adjustments")] public Adjustments Adjustments { get; set; }

    [JsonProperty("agribalyse")] public Agribalyse Agribalyse { get; set; }

    [JsonProperty("grade")] public EcoscoreGrade Grade { get; set; }

    [JsonProperty("grades")] public Dictionary<string, EcoscoreGrade> Grades { get; set; }

    [JsonProperty("missing")] public Missing Missing { get; set; }

    [JsonProperty("missing_data_warning")] public long? MissingDataWarning { get; set; }

    [JsonProperty("previous_data")] public PreviousData PreviousData { get; set; }

    [JsonProperty("score")] public long? Score { get; set; }

    [JsonProperty("scores")] public Dictionary<string, long> Scores { get; set; }

    [JsonProperty("status")] public string? Status { get; set; }
}

public class Adjustments
{
    [JsonProperty("origins_of_ingredients")]
    public OriginsOfIngredients OriginsOfIngredients { get; set; }

    [JsonProperty("packaging")] public AdjustmentsPackaging Packaging { get; set; }

    [JsonProperty("production_system")] public ProductionSystem ProductionSystem { get; set; }

    [JsonProperty("threatened_species")] public ThreatenedSpecies ThreatenedSpecies { get; set; }
}

public class OriginsOfIngredients
{
    [JsonProperty("aggregated_origins")] public AggregatedOrigin[] AggregatedOrigins { get; set; }

    [JsonProperty("epi_score")] public long? EpiScore { get; set; }

    [JsonProperty("epi_value")] public long? EpiValue { get; set; }

    [JsonProperty("origins_from_origins_field")]
    public string?[] OriginsFromOriginsField { get; set; }

    [JsonProperty("transportation_score")] public long? TransportationScore { get; set; }

    [JsonProperty("transportation_scores")]
    public Dictionary<string, long> TransportationScores { get; set; }

    [JsonProperty("transportation_value")] public long? TransportationValue { get; set; }

    [JsonProperty("transportation_values")]
    public Dictionary<string, long> TransportationValues { get; set; }

    [JsonProperty("value")] public long? Value { get; set; }

    [JsonProperty("values")] public Dictionary<string, long> Values { get; set; }
}

public class AggregatedOrigin
{
    [JsonProperty("epi_score")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? EpiScore { get; set; }

    [JsonProperty("origin")] public string? Origin { get; set; }

    [JsonProperty("percent")] public long? Percent { get; set; }

    [JsonProperty("transportation_score")] public object? TransportationScore { get; set; }
}

public class AdjustmentsPackaging
{
    [JsonProperty("non_recyclable_and_non_biodegradable_materials")]
    public long? NonRecyclableAndNonBiodegradableMaterials { get; set; }

    [JsonProperty("packagings")] public PackagingPackaging[] Packagings { get; set; }

    [JsonProperty("score")] public long? Score { get; set; }

    [JsonProperty("value")] public long? Value { get; set; }

    [JsonProperty("warning")] public string? Warning { get; set; }
}

public class PackagingPackaging
{
    [JsonProperty("ecoscore_material_score")]
    public long? EcoscoreMaterialScore { get; set; }

    [JsonProperty("ecoscore_shape_ratio")] public double? EcoscoreShapeRatio { get; set; }

    [JsonProperty("material")] public string? Material { get; set; }

    [JsonProperty("shape")] public string? Shape { get; set; }
}

public class ProductionSystem
{
    [JsonProperty("labels")] public object?[] Labels { get; set; }

    [JsonProperty("value")] public long? Value { get; set; }

    [JsonProperty("warning")] public string? Warning { get; set; }
}

public class ThreatenedSpecies
{
    [JsonProperty("ingredient")] public string? Ingredient { get; set; }

    [JsonProperty("value")] public long? Value { get; set; }
}

public class Agribalyse
{
    [JsonProperty("agribalyse_proxy_food_code")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? AgribalyseProxyFoodCode { get; set; }

    [JsonProperty("co2_agriculture")] public double? Co2Agriculture { get; set; }

    [JsonProperty("co2_consumption")] public long? Co2Consumption { get; set; }

    [JsonProperty("co2_distribution")] public double? Co2Distribution { get; set; }

    [JsonProperty("co2_packaging")] public double? Co2Packaging { get; set; }

    [JsonProperty("co2_processing")] public double? Co2Processing { get; set; }

    [JsonProperty("co2_total")] public double? Co2Total { get; set; }

    [JsonProperty("co2_transportation")] public double? Co2Transportation { get; set; }

    [JsonProperty("code")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? Code { get; set; }

    [JsonProperty("dqr")] public string? Dqr { get; set; }

    [JsonProperty("ef_agriculture")] public double? EfAgriculture { get; set; }

    [JsonProperty("ef_consumption")] public long? EfConsumption { get; set; }

    [JsonProperty("ef_distribution")] public double? EfDistribution { get; set; }

    [JsonProperty("ef_packaging")] public double? EfPackaging { get; set; }

    [JsonProperty("ef_processing")] public double? EfProcessing { get; set; }

    [JsonProperty("ef_total")] public double? EfTotal { get; set; }

    [JsonProperty("ef_transportation")] public double? EfTransportation { get; set; }

    [JsonProperty("is_beverage")] public long? IsBeverage { get; set; }

    [JsonProperty("name_en")] public string? NameEn { get; set; }

    [JsonProperty("name_fr")] public string? NameFr { get; set; }

    [JsonProperty("score")] public long? Score { get; set; }

    [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
    public string? Version { get; set; }
}

public class Missing
{
    [JsonProperty("labels")] public long? Labels { get; set; }

    [JsonProperty("packagings")] public long? Packagings { get; set; }
}

public class PreviousData
{
    [JsonProperty("agribalyse")] public Agribalyse Agribalyse { get; set; }

    [JsonProperty("grade")] public EcoscoreGrade Grade { get; set; }

    [JsonProperty("score")] public long? Score { get; set; }
}

public class EcoscoreExtendedData
{
    [JsonProperty("impact")] public Impact Impact { get; set; }
}

public class Impact
{
    [JsonProperty("ef_single_score_log_stddev")]
    public double? EfSingleScoreLogStddev { get; set; }

    [JsonProperty("likeliest_impacts")] public LikeliestImpacts LikeliestImpacts { get; set; }

    [JsonProperty("likeliest_recipe")] public Dictionary<string, double> LikeliestRecipe { get; set; }

    [JsonProperty("mass_ratio_uncharacterized")]
    public double? MassRatioUncharacterized { get; set; }

    [JsonProperty("uncharacterized_ingredients")]
    public UncharacterizedIngredients UncharacterizedIngredients { get; set; }

    [JsonProperty("uncharacterized_ingredients_mass_proportion")]
    public UncharacterizedIngredientsMassProportionClass UncharacterizedIngredientsMassProportion { get; set; }

    [JsonProperty("uncharacterized_ingredients_ratio")]
    public UncharacterizedIngredientsMassProportionClass UncharacterizedIngredientsRatio { get; set; }

    [JsonProperty("warnings")] public string?[] Warnings { get; set; }
}

public class LikeliestImpacts
{
    [JsonProperty("Climate_change")] public double? ClimateChange { get; set; }

    [JsonProperty("EF_single_score")] public double? EfSingleScore { get; set; }
}

public class UncharacterizedIngredients
{
    [JsonProperty("impact")] public string?[] Impact { get; set; }

    [JsonProperty("nutrition")] public string?[] Nutrition { get; set; }
}

public class UncharacterizedIngredientsMassProportionClass
{
    [JsonProperty("impact")] public double? Impact { get; set; }

    [JsonProperty("nutrition")] public double? Nutrition { get; set; }
}

public class Images
{
    [JsonProperty("1")] public The1 The1 { get; set; }

    [JsonProperty("10")] public The1 The10 { get; set; }

    [JsonProperty("11")] public The1 The11 { get; set; }

    [JsonProperty("12")] public The1 The12 { get; set; }

    [JsonProperty("13")] public The1 The13 { get; set; }

    [JsonProperty("14")] public The1 The14 { get; set; }

    [JsonProperty("15")] public The1 The15 { get; set; }

    [JsonProperty("16")] public The1 The16 { get; set; }

    [JsonProperty("17")] public The1 The17 { get; set; }

    [JsonProperty("18")] public The1 The18 { get; set; }

    [JsonProperty("19")] public The1 The19 { get; set; }

    [JsonProperty("2")] public The1 The2 { get; set; }

    [JsonProperty("20")] public The1 The20 { get; set; }

    [JsonProperty("21")] public The1 The21 { get; set; }

    [JsonProperty("22")] public The1 The22 { get; set; }

    [JsonProperty("23")] public The1 The23 { get; set; }

    [JsonProperty("24")] public The1 The24 { get; set; }

    [JsonProperty("25")] public The1 The25 { get; set; }

    [JsonProperty("26")] public The1 The26 { get; set; }

    [JsonProperty("27")] public The1 The27 { get; set; }

    [JsonProperty("3")] public The1 The3 { get; set; }

    [JsonProperty("5")] public The1 The5 { get; set; }

    [JsonProperty("6")] public The1 The6 { get; set; }

    [JsonProperty("7")] public The1 The7 { get; set; }

    [JsonProperty("8")] public The1 The8 { get; set; }

    [JsonProperty("9")] public The1 The9 { get; set; }

    [JsonProperty("front_en")] public FrontEn FrontEn { get; set; }

    [JsonProperty("front_fr")] public Fr FrontFr { get; set; }

    [JsonProperty("ingredients_de")] public FrontEn IngredientsDe { get; set; }

    [JsonProperty("ingredients_fr")] public Fr IngredientsFr { get; set; }

    [JsonProperty("ingredients_it")] public FrontEn IngredientsIt { get; set; }

    [JsonProperty("nutrition_fr")] public Fr NutritionFr { get; set; }
}

public class FrontEn
{
    [JsonProperty("angle")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? Angle { get; set; }

    [JsonProperty("coordinates_image_size")]
    public string? CoordinatesImageSize { get; set; }

    [JsonProperty("geometry")] public string? Geometry { get; set; }

    [JsonProperty("imgid")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? Imgid { get; set; }

    [JsonProperty("normalize")]
    [JsonConverter(typeof(FluffyParseStringConverter))]
    public bool Normalize { get; set; }

    [JsonProperty("rev")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? Rev { get; set; }

    [JsonProperty("sizes")] public Sizes Sizes { get; set; }

    [JsonProperty("white_magic")]
    [JsonConverter(typeof(FluffyParseStringConverter))]
    public bool WhiteMagic { get; set; }

    [JsonProperty("x1")] public string? X1 { get; set; }

    [JsonProperty("x2")] public string? X2 { get; set; }

    [JsonProperty("y1")] public string? Y1 { get; set; }

    [JsonProperty("y2")] public string? Y2 { get; set; }
}

public class Sizes
{
    [JsonProperty("100")] public The100 The100 { get; set; }

    [JsonProperty("400")] public The100 The400 { get; set; }

    [JsonProperty("full")] public The100 Full { get; set; }

    [JsonProperty("200", NullValueHandling = NullValueHandling.Ignore)]
    public The100 The200 { get; set; }
}

public class The100
{
    [JsonProperty("h")] public long? H { get; set; }

    [JsonProperty("w")] public long? W { get; set; }
}

public class Fr
{
    [JsonProperty("angle")] public long? Angle { get; set; }

    [JsonProperty("coordinates_image_size", NullValueHandling = NullValueHandling.Ignore)]
    public string? CoordinatesImageSize { get; set; }

    [JsonProperty("geometry")] public string? Geometry { get; set; }

    [JsonProperty("imgid")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? Imgid { get; set; }

    [JsonProperty("normalize")]
    [JsonConverter(typeof(FluffyParseStringConverter))]
    public bool? Normalize { get; set; }

    [JsonProperty("rev")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? Rev { get; set; }

    [JsonProperty("sizes")] public Sizes Sizes { get; set; }

    [JsonProperty("white_magic")]
    [JsonConverter(typeof(FluffyParseStringConverter))]
    public bool? WhiteMagic { get; set; }

    [JsonProperty("x1")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? X1 { get; set; }

    [JsonProperty("x2")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? X2 { get; set; }

    [JsonProperty("y1")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? Y1 { get; set; }

    [JsonProperty("y2")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? Y2 { get; set; }
}

public class The1
{
    [JsonProperty("sizes")] public Sizes Sizes { get; set; }

    [JsonProperty("uploaded_t")] public long? UploadedT { get; set; }

    [JsonProperty("uploader")] public string? Uploader { get; set; }
}

public class ProductIngredient
{
    [JsonProperty("id")] public string? Id { get; set; }

    [JsonProperty("ingredients", NullValueHandling = NullValueHandling.Ignore)]
    public PurpleIngredient[] Ingredients { get; set; }

    [JsonProperty("percent", NullValueHandling = NullValueHandling.Ignore)]
    public double? Percent { get; set; }

    [JsonProperty("percent_estimate")] public double? PercentEstimate { get; set; }

    [JsonProperty("text")] public string? Text { get; set; }

    [JsonProperty("vegan", NullValueHandling = NullValueHandling.Ignore)]
    public FromPalmOil? Vegan { get; set; }

    [JsonProperty("vegetarian", NullValueHandling = NullValueHandling.Ignore)]
    public FromPalmOil? Vegetarian { get; set; }

    [JsonProperty("from_palm_oil", NullValueHandling = NullValueHandling.Ignore)]
    public FromPalmOil? FromPalmOil { get; set; }

    [JsonProperty("processing", NullValueHandling = NullValueHandling.Ignore)]
    public string? Processing { get; set; }
}

public class PurpleIngredient
{
    [JsonProperty("id")] public string? Id { get; set; }

    [JsonProperty("percent", NullValueHandling = NullValueHandling.Ignore)]
    public double? Percent { get; set; }

    [JsonProperty("percent_estimate")] public double? PercentEstimate { get; set; }

    [JsonProperty("text")] public string? Text { get; set; }

    [JsonProperty("ingredients", NullValueHandling = NullValueHandling.Ignore)]
    public FluffyIngredient[] Ingredients { get; set; }

    [JsonProperty("vegan", NullValueHandling = NullValueHandling.Ignore)]
    public FromPalmOil? Vegan { get; set; }

    [JsonProperty("vegetarian", NullValueHandling = NullValueHandling.Ignore)]
    public FromPalmOil? Vegetarian { get; set; }
}

public class FluffyIngredient
{
    [JsonProperty("id")] public string? Id { get; set; }

    [JsonProperty("percent_estimate")] public double? PercentEstimate { get; set; }

    [JsonProperty("text")] public string? Text { get; set; }

    [JsonProperty("vegan")] public FromPalmOil Vegan { get; set; }

    [JsonProperty("vegetarian")] public FromPalmOil Vegetarian { get; set; }
}

public class IngredientsAnalysis
{
    [JsonProperty("en:non-vegan")] public string?[] EnNonVegan { get; set; }

    [JsonProperty("en:palm-oil")] public string?[] EnPalmOil { get; set; }

    [JsonProperty("en:vegan-status-unknown")]
    public string?[] EnVeganStatusUnknown { get; set; }

    [JsonProperty("en:vegetarian-status-unknown")]
    public string?[] EnVegetarianStatusUnknown { get; set; }
}

public class Languages
{
    [JsonProperty("en:english")] public long? EnEnglish { get; set; }

    [JsonProperty("en:french")] public long? EnFrench { get; set; }

    [JsonProperty("en:german")] public long? EnGerman { get; set; }

    [JsonProperty("en:italian")] public long? EnItalian { get; set; }
}

public class LanguagesCodes
{
    [JsonProperty("de")] public long? De { get; set; }

    [JsonProperty("en")] public long? En { get; set; }

    [JsonProperty("fr")] public long? Fr { get; set; }

    [JsonProperty("it")] public long? It { get; set; }
}

public class NutrientLevels
{
    [JsonProperty("fat")] public string? Fat { get; set; }

    [JsonProperty("salt")] public string? Salt { get; set; }

    [JsonProperty("saturated-fat")] public string? SaturatedFat { get; set; }

    [JsonProperty("sugars")] public string? Sugars { get; set; }
}

public class Nutriments
{
    [JsonProperty("carbohydrates")] public double? Carbohydrates { get; set; }

    [JsonProperty("carbohydrates_100g")] public double? Carbohydrates100G { get; set; }

    [JsonProperty("carbohydrates_serving")]
    public long? CarbohydratesServing { get; set; }

    [JsonProperty("carbohydrates_unit")] public string? CarbohydratesUnit { get; set; }

    [JsonProperty("carbohydrates_value")] public double? CarbohydratesValue { get; set; }

    [JsonProperty("carbon-footprint-from-known-ingredients_100g")]
    public double? CarbonFootprintFromKnownIngredients100G { get; set; }

    [JsonProperty("carbon-footprint-from-known-ingredients_product")]
    public long? CarbonFootprintFromKnownIngredientsProduct { get; set; }

    [JsonProperty("carbon-footprint-from-known-ingredients_serving")]
    public double? CarbonFootprintFromKnownIngredientsServing { get; set; }

    [JsonProperty("energy")] public long? Energy { get; set; }

    [JsonProperty("energy-kcal")] public long? EnergyKcal { get; set; }

    [JsonProperty("energy-kcal_100g")] public long? EnergyKcal100G { get; set; }

    [JsonProperty("energy-kcal_serving")] public long? EnergyKcalServing { get; set; }

    [JsonProperty("energy-kcal_unit")] public string? EnergyKcalUnit { get; set; }

    [JsonProperty("energy-kcal_value")] public long? EnergyKcalValue { get; set; }

    [JsonProperty("energy-kcal_value_computed")]
    public double? EnergyKcalValueComputed { get; set; }

    [JsonProperty("energy-kj")] public long? EnergyKj { get; set; }

    [JsonProperty("energy-kj_100g")] public long? EnergyKj100G { get; set; }

    [JsonProperty("energy-kj_serving")] public long? EnergyKjServing { get; set; }

    [JsonProperty("energy-kj_unit")] public string? EnergyKjUnit { get; set; }

    [JsonProperty("energy-kj_value")] public long? EnergyKjValue { get; set; }

    [JsonProperty("energy-kj_value_computed")]
    public double? EnergyKjValueComputed { get; set; }

    [JsonProperty("energy_100g")] public long? Energy100G { get; set; }

    [JsonProperty("energy_serving")] public long? EnergyServing { get; set; }

    [JsonProperty("energy_unit")] public string? EnergyUnit { get; set; }

    [JsonProperty("energy_value")] public long? EnergyValue { get; set; }

    [JsonProperty("fat")] public double? Fat { get; set; }

    [JsonProperty("fat_100g")] public double? Fat100G { get; set; }

    [JsonProperty("fat_serving")] public double? FatServing { get; set; }

    [JsonProperty("fat_unit")] public string? FatUnit { get; set; }

    [JsonProperty("fat_value")] public double? FatValue { get; set; }

    [JsonProperty("fiber")] public double? Fiber { get; set; }

    [JsonProperty("fiber_100g")] public double? Fiber100G { get; set; }

    [JsonProperty("fiber_serving")] public double? FiberServing { get; set; }

    [JsonProperty("fiber_unit")] public string? FiberUnit { get; set; }

    [JsonProperty("fiber_value")] public double? FiberValue { get; set; }

    [JsonProperty("fruits-vegetables-nuts-estimate-from-ingredients_100g")]
    public long? FruitsVegetablesNutsEstimateFromIngredients100G { get; set; }

    [JsonProperty("fruits-vegetables-nuts-estimate-from-ingredients_serving")]
    public long? FruitsVegetablesNutsEstimateFromIngredientsServing { get; set; }

    [JsonProperty("nova-group")] public long? NovaGroup { get; set; }

    [JsonProperty("nova-group_100g")] public long? NovaGroup100G { get; set; }

    [JsonProperty("nova-group_serving")] public long? NovaGroupServing { get; set; }

    [JsonProperty("nutrition-score-fr")] public long? NutritionScoreFr { get; set; }

    [JsonProperty("nutrition-score-fr_100g")]
    public long? NutritionScoreFr100G { get; set; }

    [JsonProperty("proteins")] public double? Proteins { get; set; }

    [JsonProperty("proteins_100g")] public double? Proteins100G { get; set; }

    [JsonProperty("proteins_serving")] public double? ProteinsServing { get; set; }

    [JsonProperty("proteins_unit")] public string? ProteinsUnit { get; set; }

    [JsonProperty("proteins_value")] public double? ProteinsValue { get; set; }

    [JsonProperty("salt")] public double? Salt { get; set; }

    [JsonProperty("salt_100g")] public double? Salt100G { get; set; }

    [JsonProperty("salt_serving")] public double? SaltServing { get; set; }

    [JsonProperty("salt_unit")] public string? SaltUnit { get; set; }

    [JsonProperty("salt_value")] public double? SaltValue { get; set; }

    [JsonProperty("saturated-fat")] public long? SaturatedFat { get; set; }

    [JsonProperty("saturated-fat_100g")] public long? SaturatedFat100G { get; set; }

    [JsonProperty("saturated-fat_serving")]
    public double? SaturatedFatServing { get; set; }

    [JsonProperty("saturated-fat_unit")] public string? SaturatedFatUnit { get; set; }

    [JsonProperty("saturated-fat_value")] public long? SaturatedFatValue { get; set; }

    [JsonProperty("sodium")] public double? Sodium { get; set; }

    [JsonProperty("sodium_100g")] public double? Sodium100G { get; set; }

    [JsonProperty("sodium_serving")] public double? SodiumServing { get; set; }

    [JsonProperty("sodium_unit")] public string? SodiumUnit { get; set; }

    [JsonProperty("sodium_value")] public double? SodiumValue { get; set; }

    [JsonProperty("sugars")] public double? Sugars { get; set; }

    [JsonProperty("sugars_100g")] public double? Sugars100G { get; set; }

    [JsonProperty("sugars_serving")] public double? SugarsServing { get; set; }

    [JsonProperty("sugars_unit")] public string? SugarsUnit { get; set; }

    [JsonProperty("sugars_value")] public double? SugarsValue { get; set; }
}

public class NutriscoreData
{
    [JsonProperty("energy")] public long? Energy { get; set; }

    [JsonProperty("energy_points")] public long? EnergyPoints { get; set; }

    [JsonProperty("energy_value")] public long? EnergyValue { get; set; }

    [JsonProperty("fiber")] public double? Fiber { get; set; }

    [JsonProperty("fiber_points")] public long? FiberPoints { get; set; }

    [JsonProperty("fiber_value")] public double? FiberValue { get; set; }

    [JsonProperty("fruits_vegetables_nuts_colza_walnut_olive_oils")]
    public long? FruitsVegetablesNutsColzaWalnutOliveOils { get; set; }

    [JsonProperty("fruits_vegetables_nuts_colza_walnut_olive_oils_points")]
    public long? FruitsVegetablesNutsColzaWalnutOliveOilsPoints { get; set; }

    [JsonProperty("fruits_vegetables_nuts_colza_walnut_olive_oils_value")]
    public long? FruitsVegetablesNutsColzaWalnutOliveOilsValue { get; set; }

    [JsonProperty("grade")] public string? Grade { get; set; }

    [JsonProperty("is_beverage")] public long? IsBeverage { get; set; }

    [JsonProperty("is_cheese")] public long? IsCheese { get; set; }

    [JsonProperty("is_fat")] public long? IsFat { get; set; }

    [JsonProperty("is_water")] public long? IsWater { get; set; }

    [JsonProperty("negative_points")] public long? NegativePoints { get; set; }

    [JsonProperty("positive_points")] public long? PositivePoints { get; set; }

    [JsonProperty("proteins")] public double? Proteins { get; set; }

    [JsonProperty("proteins_points")] public long? ProteinsPoints { get; set; }

    [JsonProperty("proteins_value")] public double? ProteinsValue { get; set; }

    [JsonProperty("saturated_fat")] public long? SaturatedFat { get; set; }

    [JsonProperty("saturated_fat_points")] public long? SaturatedFatPoints { get; set; }

    [JsonProperty("saturated_fat_ratio")] public double? SaturatedFatRatio { get; set; }

    [JsonProperty("saturated_fat_ratio_points")]
    public long? SaturatedFatRatioPoints { get; set; }

    [JsonProperty("saturated_fat_ratio_value")]
    public double? SaturatedFatRatioValue { get; set; }

    [JsonProperty("saturated_fat_value")] public long? SaturatedFatValue { get; set; }

    [JsonProperty("score")] public long? Score { get; set; }

    [JsonProperty("sodium")] public double? Sodium { get; set; }

    [JsonProperty("sodium_points")] public long? SodiumPoints { get; set; }

    [JsonProperty("sodium_value")] public double? SodiumValue { get; set; }

    [JsonProperty("sugars")] public double? Sugars { get; set; }

    [JsonProperty("sugars_points")] public long? SugarsPoints { get; set; }

    [JsonProperty("sugars_value")] public double? SugarsValue { get; set; }
}

public class ProductPackaging
{
    [JsonProperty("shape")] public string? Shape { get; set; }
}

public class SelectedImages
{
    [JsonProperty("front")] public Front Front { get; set; }

    [JsonProperty("ingredients")] public Ingredients Ingredients { get; set; }

    [JsonProperty("nutrition")] public Nutrition Nutrition { get; set; }
}

public class Front
{
    [JsonProperty("display")] public FrontDisplay Display { get; set; }

    [JsonProperty("small")] public FrontDisplay Small { get; set; }

    [JsonProperty("thumb")] public FrontDisplay Thumb { get; set; }
}

public class FrontDisplay
{
    [JsonProperty("en")] public Uri? En { get; set; }

    [JsonProperty("fr")] public Uri? Fr { get; set; }
}

public class Ingredients
{
    [JsonProperty("display")] public IngredientsDisplay Display { get; set; }

    [JsonProperty("small")] public IngredientsDisplay Small { get; set; }

    [JsonProperty("thumb")] public IngredientsDisplay Thumb { get; set; }
}

public class IngredientsDisplay
{
    [JsonProperty("de")] public Uri? De { get; set; }

    [JsonProperty("fr")] public Uri? Fr { get; set; }

    [JsonProperty("it")] public Uri? It { get; set; }
}

public class Nutrition
{
    [JsonProperty("display")] public NutritionDisplay Display { get; set; }

    [JsonProperty("small")] public NutritionDisplay Small { get; set; }

    [JsonProperty("thumb")] public NutritionDisplay Thumb { get; set; }
}

public class NutritionDisplay
{
    [JsonProperty("fr")] public Uri? Fr { get; set; }
}

public class Source
{
    [JsonProperty("fields")] public string?[] Fields { get; set; }

    [JsonProperty("id")] public Owner Id { get; set; }

    [JsonProperty("images")] public object?[] Images { get; set; }

    [JsonProperty("import_t")] public long? ImportT { get; set; }

    [JsonProperty("manufacturer")] public long? Manufacturer { get; set; }

    [JsonProperty("name")] public Name Name { get; set; }

    [JsonProperty("url")] public object? Url { get; set; }
}

public class SourcesFields
{
    [JsonProperty("org-gs1")] public OrgGs1 OrgGs1 { get; set; }
}

public class OrgGs1
{
    [JsonProperty("gln")] public string? Gln { get; set; }

    [JsonProperty("gpcCategoryCode")]
    [JsonConverter(typeof(PurpleParseStringConverter))]
    public long? GpcCategoryCode { get; set; }

    [JsonProperty("gpcCategoryName")] public string? GpcCategoryName { get; set; }

    [JsonProperty("isAllergenRelevantDataProvided")]
    [JsonConverter(typeof(FluffyParseStringConverter))]
    public bool IsAllergenRelevantDataProvided { get; set; }

    [JsonProperty("lastChangeDateTime")] public DateTimeOffset LastChangeDateTime { get; set; }

    [JsonProperty("partyName")] public string? PartyName { get; set; }

    [JsonProperty("publicationDateTime")] public DateTimeOffset PublicationDateTime { get; set; }
}

public enum EcoscoreGrade
{
    C,
    D
}

public enum FromPalmOil
{
    Maybe,
    No,
    Yes
}

public enum Owner
{
    OrgFerreroFranceCommerciale
}

public enum Name
{
    FerreroFranceCommerciale
}

public partial class OpenFoodFact
{
    public static OpenFoodFact FromJson(string json)
    {
        return JsonConvert.DeserializeObject<OpenFoodFact>(json, Converter.Settings);
    }
}

public static class Serialize
{
    public static string ToJson(this OpenFoodFact self)
    {
        return JsonConvert.SerializeObject(self, Converter.Settings);
    }
}

internal static class Converter
{
    public static readonly JsonSerializerSettings Settings = new()
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Converters =
        {
            EcoscoreGradeConverter.Singleton,
            FromPalmOilConverter.Singleton,
            OwnerConverter.Singleton,
            NameConverter.Singleton,
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        }
    };
}

internal class PurpleParseStringConverter : JsonConverter
{
    public static readonly PurpleParseStringConverter Singleton = new();

    public override bool CanConvert(Type t)
    {
        return t == typeof(long) || t == typeof(long?);
    }

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        long l;
        if (long.TryParse(value, out l)) return l;
        throw new Exception("Cannot unmarshal type long");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }

        var value = (long)untypedValue;
        serializer.Serialize(writer, value.ToString());
    }
}

internal class EcoscoreGradeConverter : JsonConverter
{
    public static readonly EcoscoreGradeConverter Singleton = new();

    public override bool CanConvert(Type t)
    {
        return t == typeof(EcoscoreGrade) || t == typeof(EcoscoreGrade?);
    }

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "c":
                return EcoscoreGrade.C;
            case "d":
                return EcoscoreGrade.D;
        }

        return null;
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }

        var value = (EcoscoreGrade)untypedValue;
        switch (value)
        {
            case EcoscoreGrade.C:
                serializer.Serialize(writer, "c");
                return;
            case EcoscoreGrade.D:
                serializer.Serialize(writer, "d");
                return;
        }

        throw new Exception("Cannot marshal type EcoscoreGrade");
    }
}

internal class FluffyParseStringConverter : JsonConverter
{
    public static readonly FluffyParseStringConverter Singleton = new();

    public override bool CanConvert(Type t)
    {
        return t == typeof(bool) || t == typeof(bool?);
    }

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        bool b;
        if (bool.TryParse(value, out b)) return b;
        throw new Exception("Cannot unmarshal type bool");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }

        var value = (bool)untypedValue;
        var boolString = value ? "true" : "false";
        serializer.Serialize(writer, boolString);
    }
}

internal class FromPalmOilConverter : JsonConverter
{
    public static readonly FromPalmOilConverter Singleton = new();

    public override bool CanConvert(Type t)
    {
        return t == typeof(FromPalmOil) || t == typeof(FromPalmOil?);
    }

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "maybe":
                return FromPalmOil.Maybe;
            case "no":
                return FromPalmOil.No;
            case "yes":
                return FromPalmOil.Yes;
        }

        return FromPalmOil.Maybe;
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }

        var value = (FromPalmOil)untypedValue;
        switch (value)
        {
            case FromPalmOil.Maybe:
                serializer.Serialize(writer, "maybe");
                return;
            case FromPalmOil.No:
                serializer.Serialize(writer, "no");
                return;
            case FromPalmOil.Yes:
                serializer.Serialize(writer, "yes");
                return;
        }

        throw new Exception("Cannot marshal type FromPalmOil");
    }
}

internal class OwnerConverter : JsonConverter
{
    public static readonly OwnerConverter Singleton = new();

    public override bool CanConvert(Type t)
    {
        return t == typeof(Owner) || t == typeof(Owner?);
    }

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "org-ferrero-france-commerciale") return Owner.OrgFerreroFranceCommerciale;
        return null;
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }

        var value = (Owner)untypedValue;
        if (value == Owner.OrgFerreroFranceCommerciale)
        {
            serializer.Serialize(writer, "org-ferrero-france-commerciale");
            return;
        }

        throw new Exception("Cannot marshal type Owner");
    }
}

internal class NameConverter : JsonConverter
{
    public static readonly NameConverter Singleton = new();

    public override bool CanConvert(Type t)
    {
        return t == typeof(Name) || t == typeof(Name?);
    }

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "ferrero-france-commerciale") return Name.FerreroFranceCommerciale;

        return null;
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }

        var value = (Name)untypedValue;
        if (value == Name.FerreroFranceCommerciale)
        {
            serializer.Serialize(writer, "ferrero-france-commerciale");
            return;
        }

        throw new Exception("Cannot marshal type Name");
    }
}