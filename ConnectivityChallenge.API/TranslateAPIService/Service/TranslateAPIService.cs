using System.Threading.Tasks;
using ConnectivityChallenge.API.TranslateAPIService.Model;

namespace ConnectivityChallenge.API.TranslateAPIService.Service
{
    public class TranslateAPIService : BaseAPI, ITranslateAPIService
    {
        private const string FunTranslationsBaseURI = "https://api.funtranslations.com";

        public async Task<TranslateResponse> GetShakespeareDescriptionAsync(string pokemonName)
        {
            return await this.GetAsync<TranslateResponse>(FunTranslationsBaseURI, $"/translate/shakespeare.json?text={pokemonName}");
        }
    }
}
