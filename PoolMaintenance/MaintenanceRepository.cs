using Dapper;
using PoolMaintenance.Models;
using System.Data;

namespace PoolMaintenance
{
    public class MaintenanceRepository : IMaintenanceRepository
    {
        private readonly IDbConnection _conn;

        public MaintenanceRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Maintenance> GetAllMaintenances()
        {
            return _conn.Query<Maintenance>("SELECT * FROM maintenance;");
        }
    }
}
