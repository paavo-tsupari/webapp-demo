using System.Runtime.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Abstractions;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        private readonly IListingService listingService;
        public ListingsController(IListingService listingService)
        {
            this.listingService = listingService;
        }

        [HttpGet]
        [Route("/")]
        public async Task<IActionResult> GetListings()
        {
            var listings = await listingService.GetListings();

            return Ok(listings);
        }
    }
}
