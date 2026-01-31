using System.Runtime.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Abstractions;
using Domain.Entities;

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
        public async Task<IActionResult> GetListings()
        {
            var listings = await listingService.GetListings();

            return Ok(listings);
        }
        [HttpPost]
        
        public async Task<IActionResult> AddListing(ListingEntity listing)
        {
            await listingService.AddListings(listing);
            return Ok();
        }
    }
}
