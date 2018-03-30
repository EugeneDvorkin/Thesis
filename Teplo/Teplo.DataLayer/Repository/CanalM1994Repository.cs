using System.Collections.Generic;
using System.Linq;
using Teplo.DataLayer.EFContext;
using Teplo.DataLayer.Entities;
using Teplo.DataLayer.Interfaces;

namespace Teplo.DataLayer.Repository
{
    public class CanalM1994Repository : IReposotory<CanalM1994>
    {
        TeploContext context;
        public CanalM1994Repository(TeploContext context)
        {
            this.context = context;
        }
        public CanalM1994 Get(int id)
        {
            return context.CanalM1994.Find(id);
        }

        public IEnumerable<CanalM1994> GetAll()
        {
            return context.CanalM1994.ToList();
        }
    }
}
