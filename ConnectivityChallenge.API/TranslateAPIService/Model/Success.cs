using System.Text.Json.Serialization;

namespace ConnectivityChallenge.API.TranslateAPIService.Model
{
    public class Success
    {
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
