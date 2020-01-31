using Microsoft.EntityFrameworkCore;

namespace GraphQLDemo.Models
{
    public partial class GraphQLDemoContext : DbContext
    {
        public GraphQLDemoContext()
        {
        }

        public GraphQLDemoContext(DbContextOptions<GraphQLDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }

    }
}
