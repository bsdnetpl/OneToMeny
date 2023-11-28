using Microsoft.EntityFrameworkCore;
using OneToMeny.Model;

namespace OneToMeny.DBSConnect
{
    public class ConnectToMssql : DbContext
    {
        public ConnectToMssql(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Users> UsersDB { get; set; }
        public DbSet<Role> RolesDB{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>(ep => 
            {
                ep.HasMany(w => w.roles)
                .WithOne(w => w.Users)
                .HasForeignKey(w => w.UserId)
                .OnDelete(DeleteBehavior.ClientCascade);
            });
               
                
                
        }
    }
}
