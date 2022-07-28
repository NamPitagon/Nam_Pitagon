using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GoogleConvert.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GgConvertController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public GgConvertController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
