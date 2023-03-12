using CaglarHekimci_JosephusProblem.Services;
using Microsoft.AspNetCore.Mvc;

namespace CaglarHekimci_JosephusProblem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LastPlayerController : Controller
    {
        private static IFindLastPlayer _findLastPlayerClient;
        public LastPlayerController(IFindLastPlayer findLastPlayer)
        {
            _findLastPlayerClient = findLastPlayer;
        }
        [HttpGet("{bodyCount}")]
        public string FindLastPlayerNumber(int bodyCount)
        {
            if (bodyCount <= 0)
            {
                return "The number of players in the group must be at least 1 !!!";
            }
            else
            {

                return _findLastPlayerClient.FindLastPlayerNumber(bodyCount);
            }
        }
    }
}
