using PoolMaintenance.Models;

namespace PoolMaintenance
{
    public interface IMaintenanceRepository
    {
        public IEnumerable<Maintenance> GetAllMaintenances();
    }
}
