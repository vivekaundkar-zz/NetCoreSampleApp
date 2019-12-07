using Microsoft.EntityFrameworkCore;
using NetCoreSampleApp.Models;

namespace NetCoreSampleApp.Data
{
    /**
     * Application Database Context
     */
    public class AppDbContext : DbContext
    {
        /**
         * Data Sets
         */
        public DbSet<Task> Tasks { get; set; }

        /**
         * AppDbContext constructor.
         * @param options Context options
         */
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    }
}
