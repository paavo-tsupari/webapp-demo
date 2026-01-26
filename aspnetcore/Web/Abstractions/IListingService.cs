namespace Web.Abstractions;
using Domain.Entities;

using Microsoft.AspNetCore.Mvc;

public interface IListingService
{
    Task<List<ListingEntity>> GetListings();
    Task<List<ListingEntity>> SetListings();
}
