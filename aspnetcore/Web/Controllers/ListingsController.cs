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

        [HttpGet]
        [Route("/")]
        public IActionResult GetListings()
        {
            var listings = listingService.GetListings;

            return Ok(listings);
        }
    }
}
