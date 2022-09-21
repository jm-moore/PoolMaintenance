using Dapper;
using PoolMaintenance.Models;
using System.Data;

namespace PoolMaintenance
{
    public class ChemRepository : IChemRepository
    {
        private readonly IDbConnection _conn;
        public ChemRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Chems> GetAllChems()
        {
            return _conn.Query<Chems>("SELECT * FROM chems;");
        }
    }
}
