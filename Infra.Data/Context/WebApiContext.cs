using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(WebApiContext).Assembly);

            base.OnModelCreating(builder);
        }
    }
}
