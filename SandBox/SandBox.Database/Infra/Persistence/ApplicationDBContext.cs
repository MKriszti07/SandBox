using Microsoft.EntityFrameworkCore;
using SandBox.Database.Entities;
using SandBox.Database.Interfaces.Base;

namespace SandBox.Database.Infra.Persistence
{
    public class ApplicationDBContext : DbContext, IApplicationDBContext
    {
        #region Ctor
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        #endregion

        #region DbSet
        public DbSet<AppSetting> AppSettings { get; set; }
        #endregion

        #region Methods
        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
        #endregion
    }
}
