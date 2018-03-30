using System.Data.Entity;
using Teplo.DataLayer.Entities;

namespace Teplo.DataLayer.EFContext
{
    public class TeploContext : DbContext
    {
        public TeploContext()
        { }
        public TeploContext(string name) : base(name)
        {
            Database.SetInitializer(new TeploInitializer());
        }
        public DbSet<SteamU1994> SteamU1994 { get; set; }
        public DbSet<SteamM1994> SteamM1994 { get; set; }
        public DbSet<CanalU1994> CanalU1994 { get; set; }
        public DbSet<RoomU1994> RoomU1994 { get; set; }
        public DbSet<CanalM1994> CanalM1994 { get; set; }
    }
}
