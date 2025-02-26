using System.Text.Json.Serialization;

class WeatherInfo
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}