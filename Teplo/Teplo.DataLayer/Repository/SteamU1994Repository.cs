using System.Collections.Generic;
using System.Linq;
using Teplo.DataLayer.Interfaces;
using Teplo.DataLayer.Entities;
using Teplo.DataLayer.EFContext;

namespace Teplo.DataLayer.Repository
{
    public class SteamU1994Repository : IReposotory<SteamU1994>
    {
        TeploContext context;
        public SteamU1994Repository(TeploContext context)
        {
            this.context = context;
        }
        public SteamU1994 Get(int id)
        {
            return context.SteamU1994.Find(id);
        }

        public IEnumerable<SteamU1994> GetAll()
        {
            return context.SteamU1994.ToList();
        }
    }
}
