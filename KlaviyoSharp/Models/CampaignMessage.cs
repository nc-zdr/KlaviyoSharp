using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace KlaviyoSharp.Models;
/// <summary>
/// Klaviyo Campaign Message
/// </summary>
public class CampaignMessage : KlaviyoObject<CampaignMessageAttributes>
{
    /// <summary>
    /// Creates a new Campaign Message with default values
    /// </summary>
    /// <returns></returns>
    public static new CampaignMessage Create()
    {
        return new() { Type = "campaign-message" };
    }
}
/// <summary>
/// Campaign Message Attributes
/// </summary>
public class CampaignMessageAttributes
{
    /// <summary>
    /// The label or name on the message
    /// </summary>
    [JsonProperty("label")]
    public string Label { get; set; }
    /// <summary>
    /// The channel the message is to be sent on
    /// </summary>
    [JsonProperty("channel")]
    public string Channel { get; set; }
    /// <summary>
    /// Additional attributes relating to the content of the message
    /// </summary>
    [JsonProperty("content")]
    public CampaignMessageContent Content { get; set; }
    /// <summary>
    /// The list of appropriate Send Time Sub-objects associated with the message
    /// </summary>
    [JsonProperty("send_times")]
    public List<CampaignMessageSendTimes> SendTimes { get; set; }
    /// <summary>
    /// The datetime when the message was created
    /// </summary>
    [JsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }
    /// <summary>
    /// The datetime when the message was last updated
    /// </summary>
    [JsonProperty("updated_at")]
    public DateTime? UpdatedAt { get; set; }
    /// <summary>
    /// The parent campaign id
    /// </summary>
    [JsonProperty("campaign_id")]
    public string CampaignId { get; set; }
}
/// <summary>
/// Campaign Message Content
/// </summary>
public class CampaignMessageContent
{
    /// <summary>
    /// The subject of the message
    /// </summary>
    [JsonProperty("subject")]
    public string Subject { get; set; }
    /// <summary>
    /// Preview text associated with the message
    /// </summary>
    [JsonProperty("preview_text")]
    public string PreviewText { get; set; }
    /// <summary>
    /// The email the message should be sent from
    /// </summary>
    [JsonProperty("from_email")]
    public string FromEmail { get; set; }
    /// <summary>
    /// The label associated with the from_email
    /// </summary>
    [JsonProperty("from_label")]
    public string FromLabel { get; set; }
    /// <summary>
    /// The ID of the template associated to the message
    /// </summary>
    [JsonProperty("template_id")]
    public string TemplateId { get; set; }
    /// <summary>
    /// The name of the template associated to the message
    /// </summary>
    [JsonProperty("template_name")]
    public string TemplateName { get; set; }
}

/// <summary>
/// Campaign Message Send Times
/// </summary>
public class CampaignMessageSendTimes
{
    /// <summary>
    /// The datetime that the message is to be sent
    /// </summary>
    [JsonProperty("datetime")]
    public DateTime? DateTime { get; set; }
    /// <summary>
    /// Whether that datetime is to be a local datetime for the recipient
    /// </summary>
    [JsonProperty("is_local")]
    public bool? IsLocal { get; set; }
}