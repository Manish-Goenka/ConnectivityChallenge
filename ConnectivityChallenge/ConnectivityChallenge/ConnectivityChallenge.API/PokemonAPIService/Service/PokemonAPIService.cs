using System.Threading.Tasks;
using ConnectivityChallenge.API.PokemonAPIService.Model;

namespace ConnectivityChallenge.API.PokemonAPIService.Service
{
    public class PokemonAPIService : BaseAPI, IPokemonAPIService
    {
        private const string PokemonAPIBaseURI = "https://pokeapi.co";

        public async Task<PokemonDetail> GetPokemanDetailsAsync(string pokemonName)
        {
            return await this.GetAsync<PokemonDetail>(PokemonAPIBaseURI, $"/api/v2/pokemon/{pokemonName}");
        }

        public async Task<PokemonSpeciesDetail> GetPokemanSpeciesDetailsAsync(string path)
        {
            return await this.GetAsync<PokemonSpeciesDetail>(PokemonAPIBaseURI, path);
        }
    }
}
