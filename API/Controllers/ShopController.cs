using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ShopController : ControllerBase
    {
        private readonly IShopService ShopService;

        public ShopController(IShopService shopService)
        {
            this.ShopService = shopService;
        }
        [HttpGet]
         public async Task<IActionResult> List()
        {
            var Shops = await ShopService.List();

            return Ok(Shops);
        }
    }
}
