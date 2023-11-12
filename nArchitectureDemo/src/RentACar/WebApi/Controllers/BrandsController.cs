using Application.Features.Brands.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CreateBrandCommand createBrandCommand)
        {
            var response = await Mediator.Send(createBrandCommand).ConfigureAwait(false);
            return Ok(response);
        }
    }
}
