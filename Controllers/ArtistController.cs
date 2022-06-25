using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi.Context;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private Context_DB _dbContext;
        public ArtistController(Context_DB dbContext)
        {
            _dbContext = dbContext;
        }
        public ActionResult Get()
        {

        }
         
    }
}
 