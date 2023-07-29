using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace KlaviyoSharp.Models;
/// <summary>
/// Klaviyo Catalog Category Bulk Create Job
/// </summary>
public class CatalogCategoryBulkJob : KlaviyoObject<CatalogCategoryBulkJobAttributes, CatalogCategoryBulkJobRelationships>
{
    /// <summary>
    /// Not implemented. Use specific methods for creating bulk jobs.
    /// </summary>
    /// <returns></returns>
    public static new CatalogCategoryBulkJob Create()
    {
        throw new NotImplementedException("Use specific methods for creating bulk jobs.");
    }
    /// <summary>
    /// Creates a new instance with the type set to "catalog-category-bulk-create-job"
    /// </summary>
    /// <returns></returns>
    public static CatalogCategoryBulkJob CreateCreateJob()
    {
        return new() { Type = "catalog-category-bulk-create-job" };
    }

    /// <summary>
    /// Creates a new instance with the type set to "catalog-category-bulk-update-job"
    /// </summary>
    /// <returns></returns>
    public static CatalogCategoryBulkJob CreateUpdateJob()
    {
        return new() { Type = "catalog-category-bulk-update-job" };
    }

    /// <summary>
    /// Creates a new instance with the type set to "catalog-category-bulk-delete-job"
    /// </summary>
    /// <returns></returns>
    public static CatalogCategoryBulkJob CreateDeleteJob()
    {
        return new() { Type = "catalog-category-bulk-delete-job" };
    }
}
/// <summary>
/// Relationships of the CatalogCategoryBulkCreateJob
/// </summary>
public class CatalogCategoryBulkJobRelationships
{
    /// <summary>
    /// Catalog Categorys associated with the CatalogCategoryBulkCreateJob
    /// </summary>
    [JsonProperty("categories")]
    public DataListObject<GenericObject> Categories { get; set; }
}
/// <summary>
/// Attributes of the CatalogCategoryBulkCreateJob
/// </summary>
public class CatalogCategoryBulkJobAttributes
{
    /// <summary>
    /// Unique identifier for retrieving the job. Generated by Klaviyo.
    /// </summary>
    [JsonProperty("job_id")]
    public string JobId { get; set; }
    /// <summary>
    /// Status of the asynchronous job. One of: cancelled, complete, processing, queued
    /// </summary>
    [JsonProperty("status")]
    public string Status { get; set; }
    /// <summary>
    /// The date and time the job was created in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).
    /// </summary>
    [JsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }
    /// <summary>
    /// The total number of operations to be processed by the job. See completed_count for the job's current progress.
    /// </summary>
    [JsonProperty("total_count")]
    public int? TotalCount { get; set; }
    /// <summary>
    /// The total number of operations that have been completed by the job.
    /// </summary>
    [JsonProperty("completed_count")]
    public int? CompletedCount { get; set; }
    /// <summary>
    /// The total number of operations that have failed as part of the job.
    /// </summary>
    [JsonProperty("failed_count")]
    public int? FailedCount { get; set; }
    /// <summary>
    /// Date and time the job was completed in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).
    /// </summary>
    [JsonProperty("completed_at")]
    public DateTime? CompletedAt { get; set; }
    /// <summary>
    /// Date and time the job expires in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).
    /// </summary>
    [JsonProperty("expires_at")]
    public DateTime? ExpiresAt { get; set; }
    /// <summary>
    /// Array of errors encountered during the processing of the job.
    /// </summary>
    [JsonProperty("errors")]
    public List<KlaviyoErrorDetails> Errors { get; set; }
    /// <summary>
    /// Array of catalog Categorys to create.
    /// </summary>
    [JsonProperty("categories")]
    public List<CatalogCategory> Categories { get; set; }
}