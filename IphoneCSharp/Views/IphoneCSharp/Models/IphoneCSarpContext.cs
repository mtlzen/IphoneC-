using System;
using Microsoft.EntityFrameworkCore;

namespace IphoneCSharp.Models


{
    public class IphoneCSarpContext : DbContext
    {
        public IphoneCSarpContext(DbContextOptions<IphoneCSarpContext> options)
            : base(options)
        {
        }
        public DbSet<IphoneCSharp.Models.IphoneModel> IphoneModel { get; set; }

    }
}
