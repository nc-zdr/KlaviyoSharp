using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace KlaviyoSharp.Infrastructure;

/// <summary>
/// A custom HttpContent for JSON data
/// </summary>
public class JsonContent : ByteArrayContent
{
    private object Data { get; set; }
    /// <summary>
    /// Creates a new JsonContent with the given RequestBody data
    /// </summary>
    /// <param name="data"></param>
    public JsonContent(object data) : base(ToBytes(data))
    {
        Data = data;
        Headers.ContentType = new MediaTypeHeaderValue("application/json");
    }
    /// <summary>
    /// Convert the RequestBody data to a byte array
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    private static byte[] ToBytes(object data)
    {
        string rawData = JsonConvert.SerializeObject(data, Formatting.None, KlaviyoJsonSerializerSettings);
        return Encoding.UTF8.GetBytes(rawData);
    }
    /// <summary>
    /// The JsonSerializerSettings to use for all JsonContent
    /// </summary>
    internal static JsonSerializerSettings KlaviyoJsonSerializerSettings
    {
        get
        {
            return new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Converters = new List<JsonConverter> {
                new DateTimeJsonConverter(),
                new DateTimeNullableJsonConverter(),
                new KlaviyoDateOnlyNullableJsonConverter()
            },
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy
                    {
                        OverrideSpecifiedNames = false
                    }
                }
            };
        }
    }
    /// <summary>
    /// Clones the JsonContent
    /// </summary>
    /// <returns></returns>
    public JsonContent Clone()
    {
        return new JsonContent(Data);
    }
}