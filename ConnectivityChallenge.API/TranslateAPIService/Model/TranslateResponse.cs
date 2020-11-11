using System.Text.Json.Serialization;

namespace ConnectivityChallenge.API.TranslateAPIService.Model
{
    public class TranslateResponse
    {
        [JsonPropertyName("success")]
        public Success Success { get; set; }

        [JsonPropertyName("contents")]
        public Contents Contents { get; set; }
    }
}
