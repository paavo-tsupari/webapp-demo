using Web.Abstractions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Web.services;
public class ListingService : IListingService
{
    private readonly ApplicationDbContext _context;
    
    public ListingService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<ListingEntity>> GetListings()
    {
        return await _context.ListingEntities.ToListAsync();
    }
    public  Task<List<ListingEntity>> SetListings()
    {
        return null;
    }

}