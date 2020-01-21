using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IAPT.EK.API.Identity
{
    public class MyIdentitySetupDbContext : IdentityDbContext
    {
        public MyIdentitySetupDbContext(DbContextOptions<MyIdentitySetupDbContext> options) : base (options)
        {
        }
    }
}
