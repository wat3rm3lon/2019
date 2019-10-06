using Microsoft.EntityFrameworkCore;
using FaceBookApi.Entities;

namespace FaceBookApi.Helpers
{
    public class FBDataContext : DbContext
    {
        public FBDataContext(DbContextOptions<FBDataContext> options) : base(options) { }

        public DbSet<FBUser> Users { get; set; }
    }
}