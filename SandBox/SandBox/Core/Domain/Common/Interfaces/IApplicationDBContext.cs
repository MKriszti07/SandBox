using Microsoft.EntityFrameworkCore;
using SandBox.Core.Domain.Master;

namespace SandBox.Core.Domain.Common.Interfaces
{
    public interface IApplicationDBContext
    {
        DbSet<AppSetting> AppSettings { get; set; }
        Task<int> SaveChangesAsync();
    }
}
