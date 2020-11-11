using System.Threading.Tasks;
using ConnectivityChallenge.API.TranslateAPIService.Model;

namespace ConnectivityChallenge.API.TranslateAPIService.Service
{
    public interface ITranslateAPIService
    {
        Task<TranslateResponse> GetShakespeareDescriptionAsync(string pokemonName);
    }
}