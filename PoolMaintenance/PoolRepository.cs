using Dapper;
using PoolMaintenance.Models;
using System.Collections.Generic;
using System.Data;

namespace PoolMaintenance
{
    public class PoolRepository : IPoolRepository
    {
        private readonly IDbConnection _conn;

        public PoolRepository(IDbConnection conn)
        {
            _conn = conn;
        } 
        public IEnumerable<Pools> GetAllPools()
        {
            return _conn.Query<Pools>("SELECT * FROM pools;");
        }
    }
}
