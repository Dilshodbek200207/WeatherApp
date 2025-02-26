using System.Text.Json.Serialization;

class MainDate
{
    [JsonPropertyName("temp")]
    public float Temp { get; set; }
}