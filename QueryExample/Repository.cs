using Microsoft.EntityFrameworkCore;
using QueryExample.Entities;
using QueryExample.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueryExample
{
    public class Repository : IRepository
    {
        private readonly QueryExampleContext _context;

        public Repository(QueryExampleContext context)
        {
            _context = context;
        }

        public Task<List<ShopOffer>> GetAvailableShopOffersAsync()
        {
            var borderDate = new DateTimeOffset(2018, 03, 02, 18, 00, 00, TimeSpan.FromHours(3));

            return _context.ShopOffers.Include(so => so.Item)
                .Where(so => so.IsActive && (so.ExpiresAt == null || borderDate < so.ExpiresAt))
                .OrderBy(so => so.Position).ThenBy(so => so.Id)
                .ToListAsync();
        }
    }
}
