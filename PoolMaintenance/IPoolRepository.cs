using PoolMaintenance.Models;

namespace PoolMaintenance
{
    public interface IPoolRepository
    {
        public IEnumerable<Pools> GetAllPools();

  
    }
}
