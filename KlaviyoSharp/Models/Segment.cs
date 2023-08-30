namespace KlaviyoSharp.Models;

/// <summary>
/// A Segment in Klaviyo
/// </summary>
public class Segment : KlaviyoObject<SegmentAttributes, SegmentRelationships>
{
    /// <summary>
    /// Creates a new instance of the Segment class
    /// </summary>
    /// <returns></returns>
    public static new Segment Create()
    {
        return new Segment() { Type = "segment" };
    }
}

/// <summary>
/// Related objects for the Segment
/// </summary>
public class SegmentRelationships
{
    /// <summary>
    /// Profiles associated with the Profile
    /// </summary>
    public DataListObjectRelated<GenericObject> Profiles { get; set; }
    /// <summary>
    /// Profiles associated with the Profile
    /// </summary>
    public DataListObjectRelated<GenericObject> Tags { get; set; }
}

/// <summary>
/// Attributes for the Segment
/// </summary>
public class SegmentAttributes
{
    /// <summary>
    /// A helpful name to label the segment
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Date and time when the segment was created, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)
    /// </summary>
    public DateTime? Created { get; set; }
    /// <summary>
    /// Date and time when the segment was last updated, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)
    /// </summary>
    public DateTime? Updated { get; set; }
    /// <summary>
    /// Undocumented
    /// </summary>
    public int? ProfileCount { get; set; }
}