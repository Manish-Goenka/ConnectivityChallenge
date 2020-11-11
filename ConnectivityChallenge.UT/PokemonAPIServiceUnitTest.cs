using System;
using System.Threading.Tasks;
using ConnectivityChallenge.API.PokemonAPIService.Service;
using NUnit.Framework;

namespace ConnectivityChallenge.UT
{
    public class PokemonServiceUnitTest : BaseSetup
    {
        private string pokemonSpeciesPath = string.Empty;

        [SetUp]
        public void Setup()
        {
            pokemonSpeciesPath = "/api/v2/pokemon-species";
        }

        [Test]
        public async Task TestEmptyPokemonNameReturnsNoRecord()
        {
            PokemonAPIService pokemonAPIService = new PokemonAPIService();
            var response = await pokemonAPIService.GetPokemanDetailsAsync(string.Empty);

            Assert.That(response.Id, Is.EqualTo(0));
        }

        [Test]
        public void TestNonExistantPokemonNameReturnsApplicationException()
        {
            PokemonAPIService pokemonAPIService = new PokemonAPIService();
            ApplicationException ex = Assert.ThrowsAsync<ApplicationException>(async () => await pokemonAPIService.GetPokemanDetailsAsync("NonExistantPokemon"));

            Assert.That(ex.Message, Is.EqualTo("Not Found"));
        }

        [Test]
        public async Task TestValidPokemonNameReturnsSuccess()
        {
            PokemonAPIService pokemonAPIService = new PokemonAPIService();
            var response = await pokemonAPIService.GetPokemanDetailsAsync("charizard");

            Assert.That(response, !Is.Null);
        }

        [Test]
        public void TestNonExistantPokemonSpeciesReturnsApplicationException()
        {
            PokemonAPIService pokemonAPIService = new PokemonAPIService();
            ApplicationException ex = Assert.ThrowsAsync<ApplicationException>(async () => await pokemonAPIService.GetPokemanSpeciesDetailsAsync($"{pokemonSpeciesPath}/NonExistantPokemonSpecies"));

            Assert.That(ex.Message, Is.EqualTo("Not Found"));
        }

        [Test]
        public async Task TestValidPokemonSpeciesReturnsSuccess()
        {
            PokemonAPIService pokemonAPIService = new PokemonAPIService();
            
            var response = await pokemonAPIService.GetPokemanSpeciesDetailsAsync($"{pokemonSpeciesPath}/6");

            Assert.That(response.Id, Is.EqualTo(6));
        }
    }
}