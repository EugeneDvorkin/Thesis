using System.Collections.Generic;
using System.Linq;
using Teplo.DataLayer.EFContext;
using Teplo.DataLayer.Entities;
using Teplo.DataLayer.Interfaces;

namespace Teplo.DataLayer.Repository
{
    public class SteamM1994Repository : IReposotory<SteamM1994>
    {
        TeploContext context;
        public SteamM1994Repository(TeploContext context)
        {
            this.context = context;
        }
        public SteamM1994 Get(int id)
        {
            return context.SteamM1994.Find(id);
        }

        public IEnumerable<SteamM1994> GetAll()
        {
            return context.SteamM1994.ToList();
        }
    }
}
