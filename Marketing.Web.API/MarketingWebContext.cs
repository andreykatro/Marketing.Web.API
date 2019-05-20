using Marketing.Web.API.Interfaces;
using Marketing.Web.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Marketing.Web.API
{
    public class MarketingWebContext : DbContext, IMarketingWebContext
    {
        public MarketingWebContext(DbContextOptions<MarketingWebContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}
