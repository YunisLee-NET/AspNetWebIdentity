using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebIdentity.Entities;

namespace WebIdentity.Context
{
    public class YPContext:IdentityDbContext<AppUser,AppRole,int>
    {
        public YPContext(DbContextOptions<YPContext> options):base(options)
        {

        }
    }
}
