using Microsoft.EntityFrameworkCore;
using SandBox.Database.Entities;

namespace SandBox.Database.Interfaces.Base
{
    public interface IApplicationDBContext
    {
        DbSet<AppSetting> AppSettings { get; set; }
        Task<int> SaveChangesAsync();
    }
}
