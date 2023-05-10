using Microsoft.EntityFrameworkCore;
using VisitorKeeper.Domains.Visitor;

namespace VisitorKeeper.Infrastructure.Persistence;

public class DefaultDbContext : DbContext
{
    public DbSet<VisitorEntity> Visitors { get; set; } = default!;

    public DefaultDbContext(DbContextOptions options) : base(options)
    {
        
    }
}