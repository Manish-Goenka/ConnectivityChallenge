using System;
using System.Threading.Tasks;
using ConnectivityChallenge.API.PokemonAPIService.Service;
using ConnectivityChallenge.API.TranslateAPIService.Service;
using ConnectivityChallenge.BLL;
using ConnectivityChallenge.Controllers;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ConnectivityChallenge.UT
{
    public class PokemonControllerUnitTest : BaseSetup
    {
        private TranslateAPIService translateAPIService;
        private PokemonAPIService pokemonAPIService;
        private PokemonService pokemonService;
        private PokemonController pokemonController;

        [SetUp]
        public void Setup()
        {
            translateAPIService = new TranslateAPIService();
            pokemonAPIService = new PokemonAPIService();
            pokemonService = new PokemonService(translateAPIService, pokemonAPIService, Mapper);
            pokemonController = new PokemonController(pokemonService);
        }

        [Test]
        public void TestEmptyPokemonNameReturnsApplicationException()
        {
            ApplicationException ex = Assert.ThrowsAsync<ApplicationException>(async () => await pokemonController.GetAsync(string.Empty));

            Assert.That(ex.Message, Is.EqualTo("Pokemon name must be passed in the URI as a parameter."));
        }

        [Test]
        public void TestInvalidPokemonNameReturnsApplicationException()
        {
            ApplicationException ex = Assert.ThrowsAsync<ApplicationException>(async () => await pokemonController.GetAsync("I am a invalid Pokemon"));

            Assert.That(ex.Message, Is.EqualTo("Not Found"));
        }

        [Test]
        public async Task TestValidPokemonNameReturnsResult()
        {
            BLL.Model.TranslatedResponse response = (await pokemonController.GetAsync("charizard")).Value;

            Assert.That(response.Description, Is.EqualTo("Charizard flies 'round the sky insearch of powerful opponents.'t breathes fire of such most wondrous heat yond 't melts aught. However,  itnever turns its fiery breath on anyopponent weaker than itself."));

        }
    }
}