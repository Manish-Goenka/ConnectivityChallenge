using System.Threading.Tasks;
using ConnectivityChallenge.BLL;
using ConnectivityChallenge.BLL.Model;
using Microsoft.AspNetCore.Mvc;

namespace ConnectivityChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            this.pokemonService = pokemonService;
        }

        [HttpGet("{pokemonName}")]
        public async Task<ActionResult<TranslatedResponse>> GetAsync([FromRoute]string pokemonName)
        {
            return await this.pokemonService.TranslateToShakespearStyleAsync(pokemonName);
        }
    }
}
