using System.Threading.Tasks;
using ConnectivityChallenge.BLL.Model;

namespace ConnectivityChallenge.BLL
{
    public interface IPokemonService
    {
        Task<TranslatedResponse> TranslateToShakespearStyleAsync(string pokemonName);
    }
}