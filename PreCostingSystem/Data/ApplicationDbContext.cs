using Microsoft.EntityFrameworkCore;
using PRC_PreCosting_MVC.Models;
using PreCostingSystem.Models;

namespace PRC_PreCosting_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}