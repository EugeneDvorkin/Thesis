using System.Collections.Generic;
using System.Linq;
using Teplo.DataLayer.EFContext;
using Teplo.DataLayer.Entities;
using Teplo.DataLayer.Interfaces;

namespace Teplo.DataLayer.Repository
{
    public class CanalU1994Repository : IReposotory<CanalU1994>
    {
        TeploContext context;
        public CanalU1994Repository(TeploContext context)
        {
            this.context = context;
        }
        public CanalU1994 Get(int id)
        {
            return context.CanalU1994.Find(id);
        }

        public IEnumerable<CanalU1994> GetAll()
        {
            return context.CanalU1994.ToList();
        }
    }
}
