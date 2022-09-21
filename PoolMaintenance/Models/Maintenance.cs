namespace PoolMaintenance.Models
{
    public class Maintenance
    {
        public bool Vacuumed { get; set; }
        public bool Brushed { get; set; }
        public bool Skimmed { get; set; }
        public bool Backwashed { get; set; }
        public bool AddedWater { get; set; }
        public string PoolName { get; set; }
        public int PoolID { get; set; }
    }
}
