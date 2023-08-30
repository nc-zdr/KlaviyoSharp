namespace KlaviyoSharp.Models;

/// <summary>
/// Klaviyo Catalog Variant
/// </summary>
public class CatalogVariant : KlaviyoObject<CatalogVariantAttributes, CatalogVariantRelationships>
{
    /// <summary>
    /// Creates a new instance of the Catalog Variant class, setting the type to catalog-variant
    /// </summary>
    /// <returns></returns>
    public static new CatalogVariant Create() => new() { Type = "catalog-variant" };
}

/// <summary>
/// Klaviyo Catalog Variant Relationships
/// </summary>
public class CatalogVariantRelationships
{
    /// <summary>
    /// Related Catalog Item
    /// </summary>
    public DataObject<GenericObject> Item { get; set; }
}

/// <summary>
/// Klaviyo Catalog Variant Attributes
/// </summary>
public class CatalogVariantAttributes
{
    /// <summary>
    /// The ID of the catalog item variant in an external system.
    /// </summary>
    public string ExternalId { get; set; }
    /// <summary>
    /// The title of the catalog item variant.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// A description of the catalog item variant.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// The SKU of the catalog item variant.
    /// </summary>
    public string Sku { get; set; }
    /// <summary>
    /// This field controls the visibility of this catalog item variant in product feeds/blocks. This field supports
    /// the following values: 1 - a product will not appear in dynamic product recommendation feeds and blocks if it
    /// is out of stock. 0 or 2 - a product can appear in dynamic product recommendation feeds and blocks regardless
    /// of inventory quantity.
    /// </summary>
    public int? InventoryPolicy { get; set; }
    /// <summary>
    /// The quantity of the catalog item variant currently in stock.
    /// </summary>
    public double? InventoryQuantity { get; set; }
    /// <summary>
    /// This field can be used to set the price on the catalog item variant, which is what gets displayed for the item
    /// variant when included in emails. For most price-update use cases, you will also want to update the price on any
    /// parent items using the Update Catalog Item Endpoint.
    /// </summary>
    public double? Price { get; set; }
    /// <summary>
    /// URL pointing to the location of the catalog item variant on your website.
    /// </summary>
    public string Url { get; set; }
    /// <summary>
    /// URL pointing to the location of a full image of the catalog item variant.
    /// </summary>
    public string ImageFullUrl { get; set; }
    /// <summary>
    /// URL pointing to the location of an image thumbnail of the catalog item variant.
    /// </summary>
    public string ImageThumbnailUrl { get; set; }
    /// <summary>
    /// List of URLs pointing to the locations of images of the catalog item variant.
    /// </summary>
    public List<string> Images { get; set; }
    /// <summary>
    /// Flat JSON blob to provide custom metadata about the catalog item variant. May not exceed 100kb.
    /// </summary>
    public Dictionary<string, object> CustomMetadata { get; set; }
    /// <summary>
    /// Boolean value indicating whether the catalog item variant is published.
    /// </summary>
    public bool? Published { get; set; }
    /// <summary>
    /// Date and time when the catalog item variant was created, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).
    /// </summary>
    public DateTime? Created { get; set; }
    /// <summary>
    /// Date and time when the catalog item variant was last updated, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).
    /// </summary>
    public DateTime? Updated { get; set; }
    /// <summary>
    /// The type of catalog. Currently only "$default" is supported.
    /// </summary>
    public string CatalogType { get; set; }
    /// <summary>
    /// The integration type. Currently only "$custom" is supported.
    /// </summary>
    public string IntegrationType { get; set; }
}