using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetWebAPIAuth.Data
{
    public class AppDbContext : IdentityDbContext 
    {
        public AppDbContext(DbContextOptions opt) : base(opt)
        {
        }
    }
}
