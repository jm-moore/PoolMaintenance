using PoolMaintenance.Models;

namespace PoolMaintenance
{
    public interface IChemRepository
    {
        public IEnumerable<Chems> GetAllChems();
    }
}
