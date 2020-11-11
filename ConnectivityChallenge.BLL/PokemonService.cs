using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ConnectivityChallenge.API.PokemonAPIService.Model;
using ConnectivityChallenge.API.PokemonAPIService.Service;
using ConnectivityChallenge.API.TranslateAPIService.Model;
using ConnectivityChallenge.API.TranslateAPIService.Service;
using ConnectivityChallenge.BLL.Model;

namespace ConnectivityChallenge.BLL
{
    public class PokemonService : IPokemonService
    {
        private ITranslateAPIService translateAPIService;
        private IPokemonAPIService pokemonAPIService;
        private IMapper mapper;

        public PokemonService(ITranslateAPIService translateAPIService, IPokemonAPIService pokemonAPIService, IMapper mapper)
        {
            this.translateAPIService = translateAPIService;
            this.pokemonAPIService = pokemonAPIService;
            this.mapper = mapper;
        }

        public async Task<TranslatedResponse> TranslateToShakespearStyleAsync(string pokemonName)
        {
            if (string.IsNullOrWhiteSpace(pokemonName))
            {
                throw new ApplicationException("Pokemon name must be passed in the URI as a parameter.");
            }

            PokemonDetail details = await this.pokemonAPIService.GetPokemanDetailsAsync(pokemonName);

            PokemonSpeciesDetail speciesDetail = await this.pokemonAPIService.GetPokemanSpeciesDetailsAsync(details.Species.Url.PathAndQuery);

            string description = speciesDetail.FlavorTextEntries.FirstOrDefault(x => x.Version.Name == "ruby")?.FlavorText.Replace("\n", "").Replace("\r", "");

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ApplicationException($"No details found for Pokemon {pokemonName}");
            }

            TranslateResponse translateResponse = await this.translateAPIService.GetShakespeareDescriptionAsync(description);

            TranslatedResponse translatedResponse = this.mapper.Map<TranslatedResponse>(translateResponse);
            translatedResponse.Name = pokemonName;

            return translatedResponse;
        }
    }
}
