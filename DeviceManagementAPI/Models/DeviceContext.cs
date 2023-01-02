using Microsoft.EntityFrameworkCore;

namespace DeviceManagementAPI.Models
{
    public class DeviceContext :DbContext
    {
        public DeviceContext(DbContextOptions<DeviceContext> options)
        : base(options)
        {
        }
        public DbSet<Device> Devices { get; set; } = null!;

    }
}
