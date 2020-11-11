using System.Threading.Tasks;
using ConnectivityChallenge.API.PokemonAPIService.Model;

namespace ConnectivityChallenge.API.PokemonAPIService.Service
{
    public interface IPokemonAPIService
    {
        Task<PokemonDetail> GetPokemanDetailsAsync(string pokemonName);
        Task<PokemonSpeciesDetail> GetPokemanSpeciesDetailsAsync(string path);
    }
}