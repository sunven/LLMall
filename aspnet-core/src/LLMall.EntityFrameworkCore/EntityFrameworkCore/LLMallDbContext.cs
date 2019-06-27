using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LLMall.Authorization.Roles;
using LLMall.Authorization.Users;
using LLMall.MultiTenancy;
using LLMall.Mall;

namespace LLMall.EntityFrameworkCore
{
    public class LLMallDbContext : AbpZeroDbContext<Tenant, Role, User, LLMallDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LLMallDbContext(DbContextOptions<LLMallDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>().HasMany(c => c.CategoryList).WithOne();
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Banner> Banner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Category> Category { get; set; }
    }
}
