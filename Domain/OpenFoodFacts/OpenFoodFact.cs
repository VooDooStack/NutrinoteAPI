
namespace OpenFoodFacts
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class OpenFoodFact
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public Product Product { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public long? Status { get; set; }

        [JsonProperty("status_verbose", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusVerbose { get; set; }
    }

    public partial class Product
    {
        [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("_keywords", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Keywords { get; set; }

        [JsonProperty("abbreviated_product_name_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string AbbreviatedProductNameFr { get; set; }

        [JsonProperty("abbreviated_product_name_fr_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string AbbreviatedProductNameFrImported { get; set; }

        [JsonProperty("abbreviated_product_name_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string AbbreviatedProductNameImported { get; set; }

        [JsonProperty("added_countries_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] AddedCountriesTags { get; set; }

        [JsonProperty("additives_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? AdditivesN { get; set; }

        [JsonProperty("additives_old_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? AdditivesOldN { get; set; }

        [JsonProperty("additives_old_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] AdditivesOldTags { get; set; }

        [JsonProperty("additives_original_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AdditivesOriginalTags { get; set; }

        [JsonProperty("additives_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AdditivesTags { get; set; }

        [JsonProperty("allergens", NullValueHandling = NullValueHandling.Ignore)]
        public string Allergens { get; set; }

        [JsonProperty("allergens_from_ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public string AllergensFromIngredients { get; set; }

        [JsonProperty("allergens_from_user", NullValueHandling = NullValueHandling.Ignore)]
        public string AllergensFromUser { get; set; }

        [JsonProperty("allergens_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AllergensHierarchy { get; set; }

        [JsonProperty("allergens_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string AllergensImported { get; set; }

        [JsonProperty("allergens_lc", NullValueHandling = NullValueHandling.Ignore)]
        public string AllergensLc { get; set; }

        [JsonProperty("allergens_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AllergensTags { get; set; }

        [JsonProperty("amino_acids_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] AminoAcidsTags { get; set; }

        [JsonProperty("brands", NullValueHandling = NullValueHandling.Ignore)]
        public string Brands { get; set; }

        [JsonProperty("brands_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandsImported { get; set; }

        [JsonProperty("brands_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] BrandsTags { get; set; }

        [JsonProperty("carbon_footprint_from_known_ingredients_debug", NullValueHandling = NullValueHandling.Ignore)]
        public string CarbonFootprintFromKnownIngredientsDebug { get; set; }

        [JsonProperty("carbon_footprint_percent_of_known_ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public double? CarbonFootprintPercentOfKnownIngredients { get; set; }

        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public string Categories { get; set; }

        [JsonProperty("categories_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CategoriesHierarchy { get; set; }

        [JsonProperty("categories_lc", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoriesLc { get; set; }

        [JsonProperty("categories_old", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoriesOld { get; set; }

        [JsonProperty("categories_properties", NullValueHandling = NullValueHandling.Ignore)]
        public CategoriesProperties CategoriesProperties { get; set; }

        [JsonProperty("categories_properties_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CategoriesPropertiesTags { get; set; }

        [JsonProperty("categories_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CategoriesTags { get; set; }

        [JsonProperty("category_properties", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryProperties CategoryProperties { get; set; }

        [JsonProperty("checkers_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] CheckersTags { get; set; }

        [JsonProperty("ciqual_food_name_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CiqualFoodNameTags { get; set; }

        [JsonProperty("cities_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] CitiesTags { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("codes_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CodesTags { get; set; }

        [JsonProperty("compared_to_category", NullValueHandling = NullValueHandling.Ignore)]
        public string ComparedToCategory { get; set; }

        [JsonProperty("complete", NullValueHandling = NullValueHandling.Ignore)]
        public long? Complete { get; set; }

        [JsonProperty("completeness", NullValueHandling = NullValueHandling.Ignore)]
        public double? Completeness { get; set; }

        [JsonProperty("conservation_conditions_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string ConservationConditionsFr { get; set; }

        [JsonProperty("conservation_conditions_fr_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string ConservationConditionsFrImported { get; set; }

        [JsonProperty("correctors_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CorrectorsTags { get; set; }

        [JsonProperty("countries", NullValueHandling = NullValueHandling.Ignore)]
        public string Countries { get; set; }

        [JsonProperty("countries_beforescanbot", NullValueHandling = NullValueHandling.Ignore)]
        public string CountriesBeforescanbot { get; set; }

        [JsonProperty("countries_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CountriesHierarchy { get; set; }

        [JsonProperty("countries_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string CountriesImported { get; set; }

        [JsonProperty("countries_lc", NullValueHandling = NullValueHandling.Ignore)]
        public string CountriesLc { get; set; }

        [JsonProperty("countries_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CountriesTags { get; set; }

        [JsonProperty("created_t", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedT { get; set; }

        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        [JsonProperty("customer_service_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerServiceFr { get; set; }

        [JsonProperty("customer_service_fr_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerServiceFrImported { get; set; }

        [JsonProperty("data_quality_bugs_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] DataQualityBugsTags { get; set; }

        [JsonProperty("data_quality_errors_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] DataQualityErrorsTags { get; set; }

        [JsonProperty("data_quality_info_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] DataQualityInfoTags { get; set; }

        [JsonProperty("data_quality_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] DataQualityTags { get; set; }

        [JsonProperty("data_quality_warnings_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] DataQualityWarningsTags { get; set; }

        [JsonProperty("data_sources", NullValueHandling = NullValueHandling.Ignore)]
        public string DataSources { get; set; }

        [JsonProperty("data_sources_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string DataSourcesImported { get; set; }

        [JsonProperty("data_sources_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] DataSourcesTags { get; set; }

        [JsonProperty("debug_param_sorted_langs", NullValueHandling = NullValueHandling.Ignore)]
        public string[] DebugParamSortedLangs { get; set; }

        [JsonProperty("ecoscore_data", NullValueHandling = NullValueHandling.Ignore)]
        public EcoscoreData EcoscoreData { get; set; }

        [JsonProperty("ecoscore_extended_data", NullValueHandling = NullValueHandling.Ignore)]
        public EcoscoreExtendedData EcoscoreExtendedData { get; set; }

        [JsonProperty("ecoscore_extended_data_version", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? EcoscoreExtendedDataVersion { get; set; }

        [JsonProperty("ecoscore_grade", NullValueHandling = NullValueHandling.Ignore)]
        public EcoscoreGrade? EcoscoreGrade { get; set; }

        [JsonProperty("ecoscore_score", NullValueHandling = NullValueHandling.Ignore)]
        public long? EcoscoreScore { get; set; }

        [JsonProperty("ecoscore_tags", NullValueHandling = NullValueHandling.Ignore)]
        public EcoscoreGrade[] EcoscoreTags { get; set; }

        [JsonProperty("editors_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] EditorsTags { get; set; }

        [JsonProperty("emb_codes", NullValueHandling = NullValueHandling.Ignore)]
        public string EmbCodes { get; set; }

        [JsonProperty("emb_codes_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] EmbCodesTags { get; set; }

        [JsonProperty("entry_dates_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] EntryDatesTags { get; set; }

        [JsonProperty("expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationDate { get; set; }

        [JsonProperty("food_groups", NullValueHandling = NullValueHandling.Ignore)]
        public string FoodGroups { get; set; }

        [JsonProperty("food_groups_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] FoodGroupsTags { get; set; }

        [JsonProperty("generic_name_de", NullValueHandling = NullValueHandling.Ignore)]
        public string GenericNameDe { get; set; }

        [JsonProperty("generic_name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string GenericNameEn { get; set; }

        [JsonProperty("generic_name_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string GenericNameFr { get; set; }

        [JsonProperty("generic_name_fr_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string GenericNameFrImported { get; set; }

        [JsonProperty("generic_name_it", NullValueHandling = NullValueHandling.Ignore)]
        public string GenericNameIt { get; set; }

        [JsonProperty("grades", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryProperties Grades { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        [JsonProperty("image_front_small_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageFrontSmallUrl { get; set; }

        [JsonProperty("image_front_thumb_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageFrontThumbUrl { get; set; }

        [JsonProperty("image_front_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageFrontUrl { get; set; }

        [JsonProperty("image_small_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageSmallUrl { get; set; }

        [JsonProperty("image_thumb_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageThumbUrl { get; set; }

        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ImageUrl { get; set; }

        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public Images Images { get; set; }

        [JsonProperty("informers_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] InformersTags { get; set; }

        [JsonProperty("ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public ProductIngredient[] Ingredients { get; set; }

        [JsonProperty("ingredients_analysis", NullValueHandling = NullValueHandling.Ignore)]
        public IngredientsAnalysis IngredientsAnalysis { get; set; }

        [JsonProperty("ingredients_analysis_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IngredientsAnalysisTags { get; set; }

        [JsonProperty("ingredients_from_or_that_may_be_from_palm_oil_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? IngredientsFromOrThatMayBeFromPalmOilN { get; set; }

        [JsonProperty("ingredients_from_palm_oil_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? IngredientsFromPalmOilN { get; set; }

        [JsonProperty("ingredients_from_palm_oil_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] IngredientsFromPalmOilTags { get; set; }

        [JsonProperty("ingredients_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IngredientsHierarchy { get; set; }

        [JsonProperty("ingredients_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? IngredientsN { get; set; }

        [JsonProperty("ingredients_n_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IngredientsNTags { get; set; }

        [JsonProperty("ingredients_original_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IngredientsOriginalTags { get; set; }

        [JsonProperty("ingredients_percent_analysis", NullValueHandling = NullValueHandling.Ignore)]
        public long? IngredientsPercentAnalysis { get; set; }

        [JsonProperty("ingredients_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] IngredientsTags { get; set; }

        [JsonProperty("ingredients_text", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsText { get; set; }

        [JsonProperty("ingredients_text_de", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsTextDe { get; set; }

        [JsonProperty("ingredients_text_en", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsTextEn { get; set; }

        [JsonProperty("ingredients_text_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsTextFr { get; set; }

        [JsonProperty("ingredients_text_fr_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsTextFrImported { get; set; }

        [JsonProperty("ingredients_text_it", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsTextIt { get; set; }

        [JsonProperty("ingredients_text_with_allergens", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsTextWithAllergens { get; set; }

        [JsonProperty("ingredients_text_with_allergens_de", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsTextWithAllergensDe { get; set; }

        [JsonProperty("ingredients_text_with_allergens_en", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsTextWithAllergensEn { get; set; }

        [JsonProperty("ingredients_text_with_allergens_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsTextWithAllergensFr { get; set; }

        [JsonProperty("ingredients_text_with_allergens_it", NullValueHandling = NullValueHandling.Ignore)]
        public string IngredientsTextWithAllergensIt { get; set; }

        [JsonProperty("ingredients_that_may_be_from_palm_oil_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? IngredientsThatMayBeFromPalmOilN { get; set; }

        [JsonProperty("ingredients_that_may_be_from_palm_oil_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] IngredientsThatMayBeFromPalmOilTags { get; set; }

        [JsonProperty("ingredients_with_specified_percent_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? IngredientsWithSpecifiedPercentN { get; set; }

        [JsonProperty("ingredients_with_specified_percent_sum", NullValueHandling = NullValueHandling.Ignore)]
        public double? IngredientsWithSpecifiedPercentSum { get; set; }

        [JsonProperty("ingredients_with_unspecified_percent_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? IngredientsWithUnspecifiedPercentN { get; set; }

        [JsonProperty("ingredients_with_unspecified_percent_sum", NullValueHandling = NullValueHandling.Ignore)]
        public double? IngredientsWithUnspecifiedPercentSum { get; set; }

        [JsonProperty("interface_version_created", NullValueHandling = NullValueHandling.Ignore)]
        public string InterfaceVersionCreated { get; set; }

        [JsonProperty("interface_version_modified", NullValueHandling = NullValueHandling.Ignore)]
        public string InterfaceVersionModified { get; set; }

        [JsonProperty("known_ingredients_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? KnownIngredientsN { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public string Labels { get; set; }

        [JsonProperty("labels_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public string[] LabelsHierarchy { get; set; }

        [JsonProperty("labels_lc", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelsLc { get; set; }

        [JsonProperty("labels_old", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelsOld { get; set; }

        [JsonProperty("labels_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] LabelsTags { get; set; }

        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        public string Lang { get; set; }

        [JsonProperty("lang_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string LangImported { get; set; }

        [JsonProperty("languages", NullValueHandling = NullValueHandling.Ignore)]
        public Languages Languages { get; set; }

        [JsonProperty("languages_codes", NullValueHandling = NullValueHandling.Ignore)]
        public LanguagesCodes LanguagesCodes { get; set; }

        [JsonProperty("languages_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public string[] LanguagesHierarchy { get; set; }

        [JsonProperty("languages_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] LanguagesTags { get; set; }

        [JsonProperty("last_edit_dates_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] LastEditDatesTags { get; set; }

        [JsonProperty("last_editor", NullValueHandling = NullValueHandling.Ignore)]
        public string LastEditor { get; set; }

        [JsonProperty("last_image_dates_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] LastImageDatesTags { get; set; }

        [JsonProperty("last_image_t", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastImageT { get; set; }

        [JsonProperty("last_modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifiedBy { get; set; }

        [JsonProperty("last_modified_t", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastModifiedT { get; set; }

        [JsonProperty("lc", NullValueHandling = NullValueHandling.Ignore)]
        public string Lc { get; set; }

        [JsonProperty("lc_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string LcImported { get; set; }

        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        [JsonProperty("main_countries_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] MainCountriesTags { get; set; }

        [JsonProperty("manufacturing_places", NullValueHandling = NullValueHandling.Ignore)]
        public string ManufacturingPlaces { get; set; }

        [JsonProperty("manufacturing_places_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ManufacturingPlacesTags { get; set; }

        [JsonProperty("max_imgid", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? MaxImgid { get; set; }

        [JsonProperty("minerals_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] MineralsTags { get; set; }

        [JsonProperty("misc_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] MiscTags { get; set; }

        [JsonProperty("no_nutrition_data", NullValueHandling = NullValueHandling.Ignore)]
        public string NoNutritionData { get; set; }

        [JsonProperty("no_nutrition_data_imported", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? NoNutritionDataImported { get; set; }

        [JsonProperty("nova_group", NullValueHandling = NullValueHandling.Ignore)]
        public long? NovaGroup { get; set; }

        [JsonProperty("nova_group_debug", NullValueHandling = NullValueHandling.Ignore)]
        public string NovaGroupDebug { get; set; }

        [JsonProperty("nova_groups", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? NovaGroups { get; set; }

        [JsonProperty("nova_groups_markers", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string[][]> NovaGroupsMarkers { get; set; }

        [JsonProperty("nova_groups_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] NovaGroupsTags { get; set; }

        [JsonProperty("nucleotides_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] NucleotidesTags { get; set; }

        [JsonProperty("nutrient_levels", NullValueHandling = NullValueHandling.Ignore)]
        public NutrientLevels NutrientLevels { get; set; }

        [JsonProperty("nutrient_levels_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] NutrientLevelsTags { get; set; }

        [JsonProperty("nutriments", NullValueHandling = NullValueHandling.Ignore)]
        public Nutriments Nutriments { get; set; }

        [JsonProperty("nutriscore_data", NullValueHandling = NullValueHandling.Ignore)]
        public NutriscoreData NutriscoreData { get; set; }

        [JsonProperty("nutriscore_grade", NullValueHandling = NullValueHandling.Ignore)]
        public string NutriscoreGrade { get; set; }

        [JsonProperty("nutriscore_score", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutriscoreScore { get; set; }

        [JsonProperty("nutriscore_score_opposite", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutriscoreScoreOpposite { get; set; }

        [JsonProperty("nutrition_data", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionData { get; set; }

        [JsonProperty("nutrition_data_per", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionDataPer { get; set; }

        [JsonProperty("nutrition_data_per_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionDataPerImported { get; set; }

        [JsonProperty("nutrition_data_prepared", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionDataPrepared { get; set; }

        [JsonProperty("nutrition_data_prepared_per", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionDataPreparedPer { get; set; }

        [JsonProperty("nutrition_grade_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionGradeFr { get; set; }

        [JsonProperty("nutrition_grades", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionGrades { get; set; }

        [JsonProperty("nutrition_grades_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] NutritionGradesTags { get; set; }

        [JsonProperty("nutrition_score_beverage", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreBeverage { get; set; }

        [JsonProperty("nutrition_score_debug", NullValueHandling = NullValueHandling.Ignore)]
        public string NutritionScoreDebug { get; set; }

        [JsonProperty("nutrition_score_warning_fruits_vegetables_nuts_estimate_from_ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreWarningFruitsVegetablesNutsEstimateFromIngredients { get; set; }

        [JsonProperty("nutrition_score_warning_fruits_vegetables_nuts_estimate_from_ingredients_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreWarningFruitsVegetablesNutsEstimateFromIngredientsValue { get; set; }

        [JsonProperty("obsolete", NullValueHandling = NullValueHandling.Ignore)]
        public string Obsolete { get; set; }

        [JsonProperty("obsolete_imported", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? ObsoleteImported { get; set; }

        [JsonProperty("obsolete_since_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsoleteSinceDate { get; set; }

        [JsonProperty("origin_de", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginDe { get; set; }

        [JsonProperty("origin_en", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginEn { get; set; }

        [JsonProperty("origin_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginFr { get; set; }

        [JsonProperty("origin_it", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginIt { get; set; }

        [JsonProperty("origins", NullValueHandling = NullValueHandling.Ignore)]
        public string Origins { get; set; }

        [JsonProperty("origins_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public string[] OriginsHierarchy { get; set; }

        [JsonProperty("origins_lc", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginsLc { get; set; }

        [JsonProperty("origins_old", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginsOld { get; set; }

        [JsonProperty("origins_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] OriginsTags { get; set; }

        [JsonProperty("other_nutritional_substances_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] OtherNutritionalSubstancesTags { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public Owner? Owner { get; set; }

        [JsonProperty("owner_fields", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> OwnerFields { get; set; }

        [JsonProperty("owner_imported", NullValueHandling = NullValueHandling.Ignore)]
        public Owner? OwnerImported { get; set; }

        [JsonProperty("owners_tags", NullValueHandling = NullValueHandling.Ignore)]
        public Owner? OwnersTags { get; set; }

        [JsonProperty("packaging", NullValueHandling = NullValueHandling.Ignore)]
        public string Packaging { get; set; }

        [JsonProperty("packaging_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PackagingHierarchy { get; set; }

        [JsonProperty("packaging_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagingImported { get; set; }

        [JsonProperty("packaging_lc", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagingLc { get; set; }

        [JsonProperty("packaging_old", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagingOld { get; set; }

        [JsonProperty("packaging_old_before_taxonomization", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagingOldBeforeTaxonomization { get; set; }

        [JsonProperty("packaging_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PackagingTags { get; set; }

        [JsonProperty("packaging_text_de", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagingTextDe { get; set; }

        [JsonProperty("packaging_text_en", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagingTextEn { get; set; }

        [JsonProperty("packaging_text_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagingTextFr { get; set; }

        [JsonProperty("packaging_text_it", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagingTextIt { get; set; }

        [JsonProperty("packagings", NullValueHandling = NullValueHandling.Ignore)]
        public ProductPackaging[] Packagings { get; set; }

        [JsonProperty("photographers_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PhotographersTags { get; set; }

        [JsonProperty("pnns_groups_1", NullValueHandling = NullValueHandling.Ignore)]
        public string PnnsGroups1 { get; set; }

        [JsonProperty("pnns_groups_1_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PnnsGroups1_Tags { get; set; }

        [JsonProperty("pnns_groups_2", NullValueHandling = NullValueHandling.Ignore)]
        public string PnnsGroups2 { get; set; }

        [JsonProperty("pnns_groups_2_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PnnsGroups2_Tags { get; set; }

        [JsonProperty("popularity_key", NullValueHandling = NullValueHandling.Ignore)]
        public long? PopularityKey { get; set; }

        [JsonProperty("popularity_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PopularityTags { get; set; }

        [JsonProperty("producer_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string? ProducerVersionId { get; set; }

        [JsonProperty("producer_version_id_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string? ProducerVersionIdImported { get; set; }

        [JsonProperty("product_name_de", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductNameDe { get; set; }
        
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        [JsonProperty("product_name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductNameEn { get; set; }

        [JsonProperty("product_name_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductNameFr { get; set; }

        [JsonProperty("product_name_fr_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductNameFrImported { get; set; }

        [JsonProperty("product_name_it", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductNameIt { get; set; }

        [JsonProperty("product_quantity", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? ProductQuantity { get; set; }

        [JsonProperty("purchase_places", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchasePlaces { get; set; }

        [JsonProperty("purchase_places_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PurchasePlacesTags { get; set; }

        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string Quantity { get; set; }

        [JsonProperty("quantity_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string QuantityImported { get; set; }

        [JsonProperty("removed_countries_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] RemovedCountriesTags { get; set; }

        [JsonProperty("rev", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rev { get; set; }

        [JsonProperty("scans_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? ScansN { get; set; }

        [JsonProperty("scores", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryProperties Scores { get; set; }

        [JsonProperty("selected_images", NullValueHandling = NullValueHandling.Ignore)]
        public SelectedImages SelectedImages { get; set; }

        [JsonProperty("serving_quantity", NullValueHandling = NullValueHandling.Ignore)]
         public double? ServingQuantity { get; set; }

        [JsonProperty("serving_size", NullValueHandling = NullValueHandling.Ignore)]
        public string ServingSize { get; set; }

        [JsonProperty("serving_size_imported", NullValueHandling = NullValueHandling.Ignore)]
        public string ServingSizeImported { get; set; }

        [JsonProperty("sortkey", NullValueHandling = NullValueHandling.Ignore)]
        public long? Sortkey { get; set; }

        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public Source[] Sources { get; set; }

        [JsonProperty("sources_fields", NullValueHandling = NullValueHandling.Ignore)]
        public SourcesFields SourcesFields { get; set; }

        [JsonProperty("states", NullValueHandling = NullValueHandling.Ignore)]
        public string States { get; set; }

        [JsonProperty("states_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public string[] StatesHierarchy { get; set; }

        [JsonProperty("states_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] StatesTags { get; set; }

        [JsonProperty("stores", NullValueHandling = NullValueHandling.Ignore)]
        public string Stores { get; set; }

        [JsonProperty("stores_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] StoresTags { get; set; }

        [JsonProperty("teams", NullValueHandling = NullValueHandling.Ignore)]
        public string Teams { get; set; }

        [JsonProperty("teams_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] TeamsTags { get; set; }

        [JsonProperty("traces", NullValueHandling = NullValueHandling.Ignore)]
        public string Traces { get; set; }

        [JsonProperty("traces_from_ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public string TracesFromIngredients { get; set; }

        [JsonProperty("traces_from_user", NullValueHandling = NullValueHandling.Ignore)]
        public string TracesFromUser { get; set; }

        [JsonProperty("traces_hierarchy", NullValueHandling = NullValueHandling.Ignore)]
        public string[] TracesHierarchy { get; set; }

        [JsonProperty("traces_lc", NullValueHandling = NullValueHandling.Ignore)]
        public string TracesLc { get; set; }

        [JsonProperty("traces_tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] TracesTags { get; set; }

        [JsonProperty("unique_scans_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? UniqueScansN { get; set; }

        [JsonProperty("unknown_ingredients_n", NullValueHandling = NullValueHandling.Ignore)]
        public long? UnknownIngredientsN { get; set; }

        [JsonProperty("unknown_nutrients_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] UnknownNutrientsTags { get; set; }

        [JsonProperty("update_key", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateKey { get; set; }

        [JsonProperty("vitamins_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] VitaminsTags { get; set; }

        [JsonProperty("weighers_tags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] WeighersTags { get; set; }
    }

    public partial class CategoriesProperties
    {
        [JsonProperty("agribalyse_proxy_food_code:en", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? AgribalyseProxyFoodCodeEn { get; set; }
    }

    public partial class CategoryProperties
    {
    }

    public partial class EcoscoreData
    {
        [JsonProperty("adjustments", NullValueHandling = NullValueHandling.Ignore)]
        public Adjustments Adjustments { get; set; }

        [JsonProperty("agribalyse", NullValueHandling = NullValueHandling.Ignore)]
        public Agribalyse Agribalyse { get; set; }

        [JsonProperty("grade", NullValueHandling = NullValueHandling.Ignore)]
        public EcoscoreGrade? Grade { get; set; }

        [JsonProperty("grades", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, EcoscoreGrade> Grades { get; set; }

        [JsonProperty("missing", NullValueHandling = NullValueHandling.Ignore)]
        public Missing Missing { get; set; }

        [JsonProperty("missing_data_warning", NullValueHandling = NullValueHandling.Ignore)]
        public long? MissingDataWarning { get; set; }

        [JsonProperty("previous_data", NullValueHandling = NullValueHandling.Ignore)]
        public PreviousData PreviousData { get; set; }

        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public long? Score { get; set; }

        [JsonProperty("scores", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> Scores { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }

    public partial class Adjustments
    {
        [JsonProperty("origins_of_ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public OriginsOfIngredients OriginsOfIngredients { get; set; }

        [JsonProperty("packaging", NullValueHandling = NullValueHandling.Ignore)]
        public AdjustmentsPackaging Packaging { get; set; }

        [JsonProperty("production_system", NullValueHandling = NullValueHandling.Ignore)]
        public ProductionSystem ProductionSystem { get; set; }

        [JsonProperty("threatened_species", NullValueHandling = NullValueHandling.Ignore)]
        public ThreatenedSpecies ThreatenedSpecies { get; set; }
    }

    public partial class OriginsOfIngredients
    {
        [JsonProperty("aggregated_origins", NullValueHandling = NullValueHandling.Ignore)]
        public AggregatedOrigin[] AggregatedOrigins { get; set; }

        [JsonProperty("epi_score", NullValueHandling = NullValueHandling.Ignore)]
        public long? EpiScore { get; set; }

        [JsonProperty("epi_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? EpiValue { get; set; }

        [JsonProperty("origins_from_origins_field", NullValueHandling = NullValueHandling.Ignore)]
        public string[] OriginsFromOriginsField { get; set; }

        [JsonProperty("transportation_score", NullValueHandling = NullValueHandling.Ignore)]
        public long? TransportationScore { get; set; }

        [JsonProperty("transportation_scores", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> TransportationScores { get; set; }

        [JsonProperty("transportation_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? TransportationValue { get; set; }

        [JsonProperty("transportation_values", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> TransportationValues { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> Values { get; set; }
    }

    public partial class AggregatedOrigin
    {
        [JsonProperty("epi_score", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? EpiScore { get; set; }

        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public string Origin { get; set; }

        [JsonProperty("percent", NullValueHandling = NullValueHandling.Ignore)]
        public long? Percent { get; set; }

        [JsonProperty("transportation_score")]
        public object TransportationScore { get; set; }
    }

    public partial class AdjustmentsPackaging
    {
        [JsonProperty("non_recyclable_and_non_biodegradable_materials", NullValueHandling = NullValueHandling.Ignore)]
        public long? NonRecyclableAndNonBiodegradableMaterials { get; set; }

        [JsonProperty("packagings", NullValueHandling = NullValueHandling.Ignore)]
        public PackagingPackaging[] Packagings { get; set; }

        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public long? Score { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        [JsonProperty("warning", NullValueHandling = NullValueHandling.Ignore)]
        public string Warning { get; set; }
    }

    public partial class PackagingPackaging
    {
        [JsonProperty("ecoscore_material_score", NullValueHandling = NullValueHandling.Ignore)]
        public long? EcoscoreMaterialScore { get; set; }

        [JsonProperty("ecoscore_shape_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public double? EcoscoreShapeRatio { get; set; }

        [JsonProperty("material", NullValueHandling = NullValueHandling.Ignore)]
        public string Material { get; set; }

        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
        public string Shape { get; set; }
    }

    public partial class ProductionSystem
    {
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Labels { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }

        [JsonProperty("warning", NullValueHandling = NullValueHandling.Ignore)]
        public string Warning { get; set; }
    }

    public partial class ThreatenedSpecies
    {
        [JsonProperty("ingredient", NullValueHandling = NullValueHandling.Ignore)]
        public string Ingredient { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public long? Value { get; set; }
    }

    public partial class Agribalyse
    {
        [JsonProperty("agribalyse_proxy_food_code", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? AgribalyseProxyFoodCode { get; set; }

        [JsonProperty("co2_agriculture", NullValueHandling = NullValueHandling.Ignore)]
        public double? Co2Agriculture { get; set; }

        [JsonProperty("co2_consumption", NullValueHandling = NullValueHandling.Ignore)]
        public long? Co2Consumption { get; set; }

        [JsonProperty("co2_distribution", NullValueHandling = NullValueHandling.Ignore)]
        public double? Co2Distribution { get; set; }

        [JsonProperty("co2_packaging", NullValueHandling = NullValueHandling.Ignore)]
        public double? Co2Packaging { get; set; }

        [JsonProperty("co2_processing", NullValueHandling = NullValueHandling.Ignore)]
        public double? Co2Processing { get; set; }

        [JsonProperty("co2_total", NullValueHandling = NullValueHandling.Ignore)]
        public double? Co2Total { get; set; }

        [JsonProperty("co2_transportation", NullValueHandling = NullValueHandling.Ignore)]
        public double? Co2Transportation { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Code { get; set; }

        [JsonProperty("dqr", NullValueHandling = NullValueHandling.Ignore)]
        public string Dqr { get; set; }

        [JsonProperty("ef_agriculture", NullValueHandling = NullValueHandling.Ignore)]
        public double? EfAgriculture { get; set; }

        [JsonProperty("ef_consumption", NullValueHandling = NullValueHandling.Ignore)]
        public long? EfConsumption { get; set; }

        [JsonProperty("ef_distribution", NullValueHandling = NullValueHandling.Ignore)]
        public double? EfDistribution { get; set; }

        [JsonProperty("ef_packaging", NullValueHandling = NullValueHandling.Ignore)]
        public double? EfPackaging { get; set; }

        [JsonProperty("ef_processing", NullValueHandling = NullValueHandling.Ignore)]
        public double? EfProcessing { get; set; }

        [JsonProperty("ef_total", NullValueHandling = NullValueHandling.Ignore)]
        public double? EfTotal { get; set; }

        [JsonProperty("ef_transportation", NullValueHandling = NullValueHandling.Ignore)]
        public double? EfTransportation { get; set; }

        [JsonProperty("is_beverage", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsBeverage { get; set; }

        [JsonProperty("name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEn { get; set; }

        [JsonProperty("name_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string NameFr { get; set; }

        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public long? Score { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class Missing
    {
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public long? Labels { get; set; }

        [JsonProperty("packagings", NullValueHandling = NullValueHandling.Ignore)]
        public long? Packagings { get; set; }
    }

    public partial class PreviousData
    {
        [JsonProperty("agribalyse", NullValueHandling = NullValueHandling.Ignore)]
        public Agribalyse Agribalyse { get; set; }

        [JsonProperty("grade", NullValueHandling = NullValueHandling.Ignore)]
        public EcoscoreGrade? Grade { get; set; }

        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public long? Score { get; set; }
    }

    public partial class EcoscoreExtendedData
    {
        [JsonProperty("impact", NullValueHandling = NullValueHandling.Ignore)]
        public Impact Impact { get; set; }
    }

    public partial class Impact
    {
        [JsonProperty("ef_single_score_log_stddev", NullValueHandling = NullValueHandling.Ignore)]
        public double? EfSingleScoreLogStddev { get; set; }

        [JsonProperty("likeliest_impacts", NullValueHandling = NullValueHandling.Ignore)]
        public LikeliestImpacts LikeliestImpacts { get; set; }

        [JsonProperty("likeliest_recipe", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, double> LikeliestRecipe { get; set; }

        [JsonProperty("mass_ratio_uncharacterized", NullValueHandling = NullValueHandling.Ignore)]
        public double? MassRatioUncharacterized { get; set; }

        [JsonProperty("uncharacterized_ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public UncharacterizedIngredients UncharacterizedIngredients { get; set; }

        [JsonProperty("uncharacterized_ingredients_mass_proportion", NullValueHandling = NullValueHandling.Ignore)]
        public UncharacterizedIngredientsMassProportionClass UncharacterizedIngredientsMassProportion { get; set; }

        [JsonProperty("uncharacterized_ingredients_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public UncharacterizedIngredientsMassProportionClass UncharacterizedIngredientsRatio { get; set; }

        [JsonProperty("warnings", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Warnings { get; set; }
    }

    public partial class LikeliestImpacts
    {
        [JsonProperty("Climate_change", NullValueHandling = NullValueHandling.Ignore)]
        public double? ClimateChange { get; set; }

        [JsonProperty("EF_single_score", NullValueHandling = NullValueHandling.Ignore)]
        public double? EfSingleScore { get; set; }
    }

    public partial class UncharacterizedIngredients
    {
        [JsonProperty("impact", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Impact { get; set; }

        [JsonProperty("nutrition", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Nutrition { get; set; }
    }

    public partial class UncharacterizedIngredientsMassProportionClass
    {
        [JsonProperty("impact", NullValueHandling = NullValueHandling.Ignore)]
        public double? Impact { get; set; }

        [JsonProperty("nutrition", NullValueHandling = NullValueHandling.Ignore)]
        public double? Nutrition { get; set; }
    }

    public partial class Images
    {
        [JsonProperty("1", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The1 { get; set; }

        [JsonProperty("2", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The2 { get; set; }

        [JsonProperty("3", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The3 { get; set; }

        [JsonProperty("5", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The5 { get; set; }

        [JsonProperty("6", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The6 { get; set; }

        [JsonProperty("7", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The7 { get; set; }

        [JsonProperty("8", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The8 { get; set; }

        [JsonProperty("9", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The9 { get; set; }

        [JsonProperty("10", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The10 { get; set; }

        [JsonProperty("11", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The11 { get; set; }

        [JsonProperty("12", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The12 { get; set; }

        [JsonProperty("13", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The13 { get; set; }

        [JsonProperty("14", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The14 { get; set; }

        [JsonProperty("15", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The15 { get; set; }

        [JsonProperty("16", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The16 { get; set; }

        [JsonProperty("17", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The17 { get; set; }

        [JsonProperty("18", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The18 { get; set; }

        [JsonProperty("19", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The19 { get; set; }

        [JsonProperty("20", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The20 { get; set; }

        [JsonProperty("21", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The21 { get; set; }

        [JsonProperty("22", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The22 { get; set; }

        [JsonProperty("23", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The23 { get; set; }

        [JsonProperty("24", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The24 { get; set; }

        [JsonProperty("25", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The25 { get; set; }

        [JsonProperty("26", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The26 { get; set; }

        [JsonProperty("27", NullValueHandling = NullValueHandling.Ignore)]
        public The1 The27 { get; set; }

        [JsonProperty("front_en", NullValueHandling = NullValueHandling.Ignore)]
        public FrontEn FrontEn { get; set; }

        [JsonProperty("front_fr", NullValueHandling = NullValueHandling.Ignore)]
        public Fr FrontFr { get; set; }

        [JsonProperty("ingredients_de", NullValueHandling = NullValueHandling.Ignore)]
        public FrontEn IngredientsDe { get; set; }

        [JsonProperty("ingredients_fr", NullValueHandling = NullValueHandling.Ignore)]
        public Fr IngredientsFr { get; set; }

        [JsonProperty("ingredients_it", NullValueHandling = NullValueHandling.Ignore)]
        public FrontEn IngredientsIt { get; set; }

        [JsonProperty("nutrition_fr", NullValueHandling = NullValueHandling.Ignore)]
        public Fr NutritionFr { get; set; }
    }

    public partial class FrontEn
    {
        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Angle { get; set; }

        [JsonProperty("coordinates_image_size", NullValueHandling = NullValueHandling.Ignore)]
        public string CoordinatesImageSize { get; set; }

        [JsonProperty("geometry", NullValueHandling = NullValueHandling.Ignore)]
        public string Geometry { get; set; }

        [JsonProperty("imgid", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Imgid { get; set; }

        [JsonProperty("normalize", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Normalize { get; set; }

        [JsonProperty("rev", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Rev { get; set; }

        [JsonProperty("sizes", NullValueHandling = NullValueHandling.Ignore)]
        public Sizes Sizes { get; set; }

        [JsonProperty("white_magic", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? WhiteMagic { get; set; }

        [JsonProperty("x1", NullValueHandling = NullValueHandling.Ignore)]
        public string X1 { get; set; }

        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public string X2 { get; set; }

        [JsonProperty("y1", NullValueHandling = NullValueHandling.Ignore)]
        public string Y1 { get; set; }

        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public string Y2 { get; set; }
    }

    public partial class Sizes
    {
        [JsonProperty("100", NullValueHandling = NullValueHandling.Ignore)]
        public The100 The100 { get; set; }

        [JsonProperty("400", NullValueHandling = NullValueHandling.Ignore)]
        public The100 The400 { get; set; }

        [JsonProperty("full", NullValueHandling = NullValueHandling.Ignore)]
        public The100 Full { get; set; }

        [JsonProperty("200", NullValueHandling = NullValueHandling.Ignore)]
        public The100 The200 { get; set; }
    }

    public partial class The100
    {
        [JsonProperty("h", NullValueHandling = NullValueHandling.Ignore)]
        public long? H { get; set; }

        [JsonProperty("w", NullValueHandling = NullValueHandling.Ignore)]
        public long? W { get; set; }
    }

    public partial class Fr
    {
        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        public long? Angle { get; set; }

        [JsonProperty("coordinates_image_size", NullValueHandling = NullValueHandling.Ignore)]
        public string CoordinatesImageSize { get; set; }

        [JsonProperty("geometry", NullValueHandling = NullValueHandling.Ignore)]
        public string Geometry { get; set; }

        [JsonProperty("imgid", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Imgid { get; set; }

        [JsonProperty("normalize")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Normalize { get; set; }

        [JsonProperty("rev", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Rev { get; set; }

        [JsonProperty("sizes", NullValueHandling = NullValueHandling.Ignore)]
        public Sizes Sizes { get; set; }

        [JsonProperty("white_magic")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? WhiteMagic { get; set; }

        [JsonProperty("x1", NullValueHandling = NullValueHandling.Ignore)]
         public string? X1 { get; set; }

        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
         public string? X2 { get; set; }

        [JsonProperty("y1", NullValueHandling = NullValueHandling.Ignore)]
         public string? Y1 { get; set; }

        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
         public  string? Y2 { get; set; }
    }

    public partial class The1
    {
        [JsonProperty("sizes", NullValueHandling = NullValueHandling.Ignore)]
        public Sizes Sizes { get; set; }

        [JsonProperty("uploaded_t", NullValueHandling = NullValueHandling.Ignore)]
        public long? UploadedT { get; set; }

        [JsonProperty("uploader", NullValueHandling = NullValueHandling.Ignore)]
        public string Uploader { get; set; }
    }

    public partial class ProductIngredient
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleIngredient[] Ingredients { get; set; }

        [JsonProperty("percent", NullValueHandling = NullValueHandling.Ignore)]
        public double? Percent { get; set; }

        [JsonProperty("percent_estimate", NullValueHandling = NullValueHandling.Ignore)]
        public double? PercentEstimate { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("vegan", NullValueHandling = NullValueHandling.Ignore)]
        public FromPalmOil? Vegan { get; set; }

        [JsonProperty("vegetarian", NullValueHandling = NullValueHandling.Ignore)]
        public FromPalmOil? Vegetarian { get; set; }

        [JsonProperty("from_palm_oil", NullValueHandling = NullValueHandling.Ignore)]
        public FromPalmOil? FromPalmOil { get; set; }

        [JsonProperty("processing", NullValueHandling = NullValueHandling.Ignore)]
        public string Processing { get; set; }
    }

    public partial class PurpleIngredient
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("percent", NullValueHandling = NullValueHandling.Ignore)]
        public double? Percent { get; set; }

        [JsonProperty("percent_estimate", NullValueHandling = NullValueHandling.Ignore)]
        public double? PercentEstimate { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public FluffyIngredient[] Ingredients { get; set; }

        [JsonProperty("vegan", NullValueHandling = NullValueHandling.Ignore)]
        public FromPalmOil? Vegan { get; set; }

        [JsonProperty("vegetarian", NullValueHandling = NullValueHandling.Ignore)]
        public FromPalmOil? Vegetarian { get; set; }
    }

    public partial class FluffyIngredient
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("percent_estimate", NullValueHandling = NullValueHandling.Ignore)]
        public double? PercentEstimate { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("vegan", NullValueHandling = NullValueHandling.Ignore)]
        public FromPalmOil? Vegan { get; set; }

        [JsonProperty("vegetarian", NullValueHandling = NullValueHandling.Ignore)]
        public FromPalmOil? Vegetarian { get; set; }
    }

    public partial class IngredientsAnalysis
    {
        [JsonProperty("en:non-vegan", NullValueHandling = NullValueHandling.Ignore)]
        public string[] EnNonVegan { get; set; }

        [JsonProperty("en:palm-oil", NullValueHandling = NullValueHandling.Ignore)]
        public string[] EnPalmOil { get; set; }

        [JsonProperty("en:vegan-status-unknown", NullValueHandling = NullValueHandling.Ignore)]
        public string[] EnVeganStatusUnknown { get; set; }

        [JsonProperty("en:vegetarian-status-unknown", NullValueHandling = NullValueHandling.Ignore)]
        public string[] EnVegetarianStatusUnknown { get; set; }
    }

    public partial class Languages
    {
        [JsonProperty("en:english", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnEnglish { get; set; }

        [JsonProperty("en:french", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnFrench { get; set; }

        [JsonProperty("en:german", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnGerman { get; set; }

        [JsonProperty("en:italian", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnItalian { get; set; }
    }

    public partial class LanguagesCodes
    {
        [JsonProperty("de", NullValueHandling = NullValueHandling.Ignore)]
        public long? De { get; set; }

        [JsonProperty("en", NullValueHandling = NullValueHandling.Ignore)]
        public long? En { get; set; }

        [JsonProperty("fr", NullValueHandling = NullValueHandling.Ignore)]
        public long? Fr { get; set; }

        [JsonProperty("it", NullValueHandling = NullValueHandling.Ignore)]
        public long? It { get; set; }
    }

    public partial class NutrientLevels
    {
        [JsonProperty("fat", NullValueHandling = NullValueHandling.Ignore)]
        public string Fat { get; set; }

        [JsonProperty("salt", NullValueHandling = NullValueHandling.Ignore)]
        public string Salt { get; set; }

        [JsonProperty("saturated-fat", NullValueHandling = NullValueHandling.Ignore)]
        public string SaturatedFat { get; set; }

        [JsonProperty("sugars", NullValueHandling = NullValueHandling.Ignore)]
        public string Sugars { get; set; }
    }

    public partial class Nutriments
    {
        [JsonProperty("carbohydrates", NullValueHandling = NullValueHandling.Ignore)]
        public double? Carbohydrates { get; set; }

        [JsonProperty("carbohydrates_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? Carbohydrates100G { get; set; }

        [JsonProperty("carbohydrates_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? CarbohydratesServing { get; set; }

        [JsonProperty("carbohydrates_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string CarbohydratesUnit { get; set; }

        [JsonProperty("carbohydrates_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? CarbohydratesValue { get; set; }

        [JsonProperty("carbon-footprint-from-known-ingredients_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? CarbonFootprintFromKnownIngredients100G { get; set; }

        [JsonProperty("carbon-footprint-from-known-ingredients_product", NullValueHandling = NullValueHandling.Ignore)]
        public long? CarbonFootprintFromKnownIngredientsProduct { get; set; }

        [JsonProperty("carbon-footprint-from-known-ingredients_serving", NullValueHandling = NullValueHandling.Ignore)]
        public double? CarbonFootprintFromKnownIngredientsServing { get; set; }

        [JsonProperty("energy", NullValueHandling = NullValueHandling.Ignore)]
        public long? Energy { get; set; }

        [JsonProperty("energy-kcal", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyKcal { get; set; }

        [JsonProperty("energy-kcal_100g", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyKcal100G { get; set; }

        [JsonProperty("energy-kcal_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyKcalServing { get; set; }

        [JsonProperty("energy-kcal_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string EnergyKcalUnit { get; set; }

        [JsonProperty("energy-kcal_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyKcalValue { get; set; }

        [JsonProperty("energy-kcal_value_computed", NullValueHandling = NullValueHandling.Ignore)]
        public double? EnergyKcalValueComputed { get; set; }

        [JsonProperty("energy-kj", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyKj { get; set; }

        [JsonProperty("energy-kj_100g", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyKj100G { get; set; }

        [JsonProperty("energy-kj_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyKjServing { get; set; }

        [JsonProperty("energy-kj_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string EnergyKjUnit { get; set; }

        [JsonProperty("energy-kj_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyKjValue { get; set; }

        [JsonProperty("energy-kj_value_computed", NullValueHandling = NullValueHandling.Ignore)]
        public double? EnergyKjValueComputed { get; set; }

        [JsonProperty("energy_100g", NullValueHandling = NullValueHandling.Ignore)]
        public long? Energy100G { get; set; }

        [JsonProperty("energy_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyServing { get; set; }

        [JsonProperty("energy_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string EnergyUnit { get; set; }

        [JsonProperty("energy_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyValue { get; set; }

        [JsonProperty("fat", NullValueHandling = NullValueHandling.Ignore)]
        public double? Fat { get; set; }

        [JsonProperty("fat_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? Fat100G { get; set; }

        [JsonProperty("fat_serving", NullValueHandling = NullValueHandling.Ignore)]
        public double? FatServing { get; set; }

        [JsonProperty("fat_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string FatUnit { get; set; }

        [JsonProperty("fat_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? FatValue { get; set; }

        [JsonProperty("fiber", NullValueHandling = NullValueHandling.Ignore)]
        public double? Fiber { get; set; }

        [JsonProperty("fiber_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? Fiber100G { get; set; }

        [JsonProperty("fiber_serving", NullValueHandling = NullValueHandling.Ignore)]
        public double? FiberServing { get; set; }

        [JsonProperty("fiber_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string FiberUnit { get; set; }

        [JsonProperty("fiber_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? FiberValue { get; set; }

        [JsonProperty("fruits-vegetables-nuts-estimate-from-ingredients_100g", NullValueHandling = NullValueHandling.Ignore)]
        public long? FruitsVegetablesNutsEstimateFromIngredients100G { get; set; }

        [JsonProperty("fruits-vegetables-nuts-estimate-from-ingredients_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? FruitsVegetablesNutsEstimateFromIngredientsServing { get; set; }

        [JsonProperty("nova-group", NullValueHandling = NullValueHandling.Ignore)]
        public long? NovaGroup { get; set; }

        [JsonProperty("nova-group_100g", NullValueHandling = NullValueHandling.Ignore)]
        public long? NovaGroup100G { get; set; }

        [JsonProperty("nova-group_serving", NullValueHandling = NullValueHandling.Ignore)]
        public long? NovaGroupServing { get; set; }

        [JsonProperty("nutrition-score-fr", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreFr { get; set; }

        [JsonProperty("nutrition-score-fr_100g", NullValueHandling = NullValueHandling.Ignore)]
        public long? NutritionScoreFr100G { get; set; }

        [JsonProperty("proteins", NullValueHandling = NullValueHandling.Ignore)]
        public double? Proteins { get; set; }

        [JsonProperty("proteins_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? Proteins100G { get; set; }

        [JsonProperty("proteins_serving", NullValueHandling = NullValueHandling.Ignore)]
        public double? ProteinsServing { get; set; }

        [JsonProperty("proteins_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string ProteinsUnit { get; set; }

        [JsonProperty("proteins_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? ProteinsValue { get; set; }

        [JsonProperty("salt", NullValueHandling = NullValueHandling.Ignore)]
        public double? Salt { get; set; }

        [JsonProperty("salt_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? Salt100G { get; set; }

        [JsonProperty("salt_serving", NullValueHandling = NullValueHandling.Ignore)]
        public double? SaltServing { get; set; }

        [JsonProperty("salt_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string SaltUnit { get; set; }

        [JsonProperty("salt_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? SaltValue { get; set; }

        [JsonProperty("saturated-fat", NullValueHandling = NullValueHandling.Ignore)]
        public long? SaturatedFat { get; set; }

        [JsonProperty("saturated-fat_100g", NullValueHandling = NullValueHandling.Ignore)]
        public long? SaturatedFat100G { get; set; }

        [JsonProperty("saturated-fat_serving", NullValueHandling = NullValueHandling.Ignore)]
        public double? SaturatedFatServing { get; set; }

        [JsonProperty("saturated-fat_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string SaturatedFatUnit { get; set; }

        [JsonProperty("saturated-fat_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? SaturatedFatValue { get; set; }

        [JsonProperty("sodium", NullValueHandling = NullValueHandling.Ignore)]
        public double? Sodium { get; set; }

        [JsonProperty("sodium_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? Sodium100G { get; set; }

        [JsonProperty("sodium_serving", NullValueHandling = NullValueHandling.Ignore)]
        public double? SodiumServing { get; set; }

        [JsonProperty("sodium_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string SodiumUnit { get; set; }

        [JsonProperty("sodium_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? SodiumValue { get; set; }

        [JsonProperty("sugars", NullValueHandling = NullValueHandling.Ignore)]
        public double? Sugars { get; set; }

        [JsonProperty("sugars_100g", NullValueHandling = NullValueHandling.Ignore)]
        public double? Sugars100G { get; set; }

        [JsonProperty("sugars_serving", NullValueHandling = NullValueHandling.Ignore)]
        public double? SugarsServing { get; set; }

        [JsonProperty("sugars_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string SugarsUnit { get; set; }

        [JsonProperty("sugars_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? SugarsValue { get; set; }
    }

    public partial class NutriscoreData
    {
        [JsonProperty("energy", NullValueHandling = NullValueHandling.Ignore)]
        public long? Energy { get; set; }

        [JsonProperty("energy_points", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyPoints { get; set; }

        [JsonProperty("energy_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnergyValue { get; set; }

        [JsonProperty("fiber", NullValueHandling = NullValueHandling.Ignore)]
        public double? Fiber { get; set; }

        [JsonProperty("fiber_points", NullValueHandling = NullValueHandling.Ignore)]
        public long? FiberPoints { get; set; }

        [JsonProperty("fiber_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? FiberValue { get; set; }

        [JsonProperty("fruits_vegetables_nuts_colza_walnut_olive_oils", NullValueHandling = NullValueHandling.Ignore)]
        public long? FruitsVegetablesNutsColzaWalnutOliveOils { get; set; }

        [JsonProperty("fruits_vegetables_nuts_colza_walnut_olive_oils_points", NullValueHandling = NullValueHandling.Ignore)]
        public long? FruitsVegetablesNutsColzaWalnutOliveOilsPoints { get; set; }

        [JsonProperty("fruits_vegetables_nuts_colza_walnut_olive_oils_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? FruitsVegetablesNutsColzaWalnutOliveOilsValue { get; set; }

        [JsonProperty("grade", NullValueHandling = NullValueHandling.Ignore)]
        public string Grade { get; set; }

        [JsonProperty("is_beverage", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsBeverage { get; set; }

        [JsonProperty("is_cheese", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsCheese { get; set; }

        [JsonProperty("is_fat", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsFat { get; set; }

        [JsonProperty("is_water", NullValueHandling = NullValueHandling.Ignore)]
        public long? IsWater { get; set; }

        [JsonProperty("negative_points", NullValueHandling = NullValueHandling.Ignore)]
        public long? NegativePoints { get; set; }

        [JsonProperty("positive_points", NullValueHandling = NullValueHandling.Ignore)]
        public long? PositivePoints { get; set; }

        [JsonProperty("proteins", NullValueHandling = NullValueHandling.Ignore)]
        public double? Proteins { get; set; }

        [JsonProperty("proteins_points", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProteinsPoints { get; set; }

        [JsonProperty("proteins_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? ProteinsValue { get; set; }

        [JsonProperty("saturated_fat", NullValueHandling = NullValueHandling.Ignore)]
        public long? SaturatedFat { get; set; }

        [JsonProperty("saturated_fat_points", NullValueHandling = NullValueHandling.Ignore)]
        public long? SaturatedFatPoints { get; set; }

        [JsonProperty("saturated_fat_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public double? SaturatedFatRatio { get; set; }

        [JsonProperty("saturated_fat_ratio_points", NullValueHandling = NullValueHandling.Ignore)]
        public long? SaturatedFatRatioPoints { get; set; }

        [JsonProperty("saturated_fat_ratio_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? SaturatedFatRatioValue { get; set; }

        [JsonProperty("saturated_fat_value", NullValueHandling = NullValueHandling.Ignore)]
        public long? SaturatedFatValue { get; set; }

        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public long? Score { get; set; }

        [JsonProperty("sodium", NullValueHandling = NullValueHandling.Ignore)]
        public double? Sodium { get; set; }

        [JsonProperty("sodium_points", NullValueHandling = NullValueHandling.Ignore)]
        public long? SodiumPoints { get; set; }

        [JsonProperty("sodium_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? SodiumValue { get; set; }

        [JsonProperty("sugars", NullValueHandling = NullValueHandling.Ignore)]
        public double? Sugars { get; set; }

        [JsonProperty("sugars_points", NullValueHandling = NullValueHandling.Ignore)]
        public long? SugarsPoints { get; set; }

        [JsonProperty("sugars_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? SugarsValue { get; set; }
    }

    public partial class ProductPackaging
    {
        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
        public string Shape { get; set; }
    }

    public partial class SelectedImages
    {
        [JsonProperty("front", NullValueHandling = NullValueHandling.Ignore)]
        public Front Front { get; set; }

        [JsonProperty("ingredients", NullValueHandling = NullValueHandling.Ignore)]
        public Ingredients Ingredients { get; set; }

        [JsonProperty("nutrition", NullValueHandling = NullValueHandling.Ignore)]
        public Nutrition Nutrition { get; set; }
    }

    public partial class Front
    {
        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public FrontDisplay Display { get; set; }

        [JsonProperty("small", NullValueHandling = NullValueHandling.Ignore)]
        public FrontDisplay Small { get; set; }

        [JsonProperty("thumb", NullValueHandling = NullValueHandling.Ignore)]
        public FrontDisplay Thumb { get; set; }
    }

    public partial class FrontDisplay
    {
        [JsonProperty("en", NullValueHandling = NullValueHandling.Ignore)]
        public Uri En { get; set; }

        [JsonProperty("fr", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Fr { get; set; }
    }

    public partial class Ingredients
    {
        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public IngredientsDisplay Display { get; set; }

        [JsonProperty("small", NullValueHandling = NullValueHandling.Ignore)]
        public IngredientsDisplay Small { get; set; }

        [JsonProperty("thumb", NullValueHandling = NullValueHandling.Ignore)]
        public IngredientsDisplay Thumb { get; set; }
    }

    public partial class IngredientsDisplay
    {
        [JsonProperty("de", NullValueHandling = NullValueHandling.Ignore)]
        public Uri De { get; set; }

        [JsonProperty("fr", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Fr { get; set; }

        [JsonProperty("it", NullValueHandling = NullValueHandling.Ignore)]
        public Uri It { get; set; }
    }

    public partial class Nutrition
    {
        [JsonProperty("display", NullValueHandling = NullValueHandling.Ignore)]
        public NutritionDisplay Display { get; set; }

        [JsonProperty("small", NullValueHandling = NullValueHandling.Ignore)]
        public NutritionDisplay Small { get; set; }

        [JsonProperty("thumb", NullValueHandling = NullValueHandling.Ignore)]
        public NutritionDisplay Thumb { get; set; }
    }

    public partial class NutritionDisplay
    {
        [JsonProperty("fr", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Fr { get; set; }
    }

    public partial class Source
    {
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Fields { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Owner? Id { get; set; }

        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Images { get; set; }

        [JsonProperty("import_t", NullValueHandling = NullValueHandling.Ignore)]
        public long? ImportT { get; set; }

        [JsonProperty("manufacturer", NullValueHandling = NullValueHandling.Ignore)]
        public long? Manufacturer { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public Name? Name { get; set; }

        [JsonProperty("url")]
        public object Url { get; set; }
    }

    public partial class SourcesFields
    {
        [JsonProperty("org-gs1", NullValueHandling = NullValueHandling.Ignore)]
        public OrgGs1 OrgGs1 { get; set; }
    }

    public partial class OrgGs1
    {
        [JsonProperty("gln", NullValueHandling = NullValueHandling.Ignore)]
        public string Gln { get; set; }

        [JsonProperty("gpcCategoryCode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? GpcCategoryCode { get; set; }

        [JsonProperty("gpcCategoryName", NullValueHandling = NullValueHandling.Ignore)]
        public string GpcCategoryName { get; set; }

        [JsonProperty("isAllergenRelevantDataProvided", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? IsAllergenRelevantDataProvided { get; set; }

        [JsonProperty("lastChangeDateTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastChangeDateTime { get; set; }

        [JsonProperty("partyName", NullValueHandling = NullValueHandling.Ignore)]
        public string PartyName { get; set; }

        [JsonProperty("publicationDateTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PublicationDateTime { get; set; }
    }

    public enum EcoscoreGrade { A, B, C, D, E };

    public enum FromPalmOil { Maybe, No, Yes, Unknown};

    public enum Owner { OrgFerreroFranceCommerciale };

    public enum Name { FerreroFranceCommerciale };

    public partial class OpenFoodFact
    {
        public static OpenFoodFact FromJson(string json) => JsonConvert.DeserializeObject<OpenFoodFact>(json, OpenFoodFacts.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this OpenFoodFact self) => JsonConvert.SerializeObject(self, OpenFoodFacts.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            Converters =
            {
                EcoscoreGradeConverter.Singleton,
                FromPalmOilConverter.Singleton,
                OwnerConverter.Singleton,
                NameConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class PurpleParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return (long)l;
            }
            else if (double.TryParse(value, out double d))
            {
                return d;
            }
            Console.WriteLine("cannot parse " + value + " to long");
            return null;
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
            return;
        }

        public static readonly PurpleParseStringConverter Singleton = new PurpleParseStringConverter();
    }

    internal class EcoscoreGradeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EcoscoreGrade) || t == typeof(EcoscoreGrade?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "a":
                    return EcoscoreGrade.A;
                case "b":
                    return EcoscoreGrade.B;
                case "c":
                    return EcoscoreGrade.C;
                case "d":
                    return EcoscoreGrade.D;
                case "e":
                    return EcoscoreGrade.E;
                default:
                    return EcoscoreGrade.C;
            }
            Console.WriteLine("cannot marshal type ecoscore"); return null;
            throw new Exception("Cannot unmarshal type EcoscoreGrade");
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
            Console.WriteLine("cannot marshal type"); return; 
            //// throw new Exception("Cannot marshal type EcoscoreGrade");
        }

        public static readonly EcoscoreGradeConverter Singleton = new EcoscoreGradeConverter();
    }

    internal class FluffyParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(bool) || t == typeof(bool?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            bool b;
            if (Boolean.TryParse(value, out b))
            {
                return b;
            }
            return null;
            Console.WriteLine("cannot parse " + value + " to bool");
            // throw new Exception("Cannot unmarshal type bool");
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
            return;
        }

        public static readonly FluffyParseStringConverter Singleton = new FluffyParseStringConverter();
    }

    internal class FromPalmOilConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FromPalmOil) || t == typeof(FromPalmOil?);

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
                default: 
                    return FromPalmOil.Unknown;
            }
            throw new Exception("Cannot unmarshal type FromPalmOil");
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
            Console.WriteLine("cannot marshal type"); return; 
            //throw new Exception("Cannot marshal type FromPalmOil");
        }

        public static readonly FromPalmOilConverter Singleton = new FromPalmOilConverter();
    }

    internal class OwnerConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Owner) || t == typeof(Owner?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "org-ferrero-france-commerciale")
            {
                return Owner.OrgFerreroFranceCommerciale;
            }
            Console.WriteLine("cannot parse " + value + " to Owner");
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
            Console.WriteLine("cannot marshal type"); return; 
            //throw new Exception("Cannot marshal type Owner");
        }

        public static readonly OwnerConverter Singleton = new OwnerConverter();
    }

    internal class NameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Name) || t == typeof(Name?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "ferrero-france-commerciale")
            {
                return Name.FerreroFranceCommerciale;
            }
            Console.WriteLine("cannot parse " + value + " to Name");
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
            Console.WriteLine("cannot marshal type"); return; 
            //throw new Exception("Cannot marshal type Name");
        }

        public static readonly NameConverter Singleton = new NameConverter();
    }
}
