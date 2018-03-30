using System.Collections.Generic;
using System.Linq;
using Teplo.DataLayer.EFContext;
using Teplo.DataLayer.Entities;
using Teplo.DataLayer.Interfaces;

namespace Teplo.DataLayer.Repository
{
    public class RoomU1994Repository : IReposotory<RoomU1994>
    {
        TeploContext context;
        public RoomU1994Repository(TeploContext context)
        {
            this.context = context;
        }
        public RoomU1994 Get(int id)
        {
            return context.RoomU1994.Find(id);
        }

        public IEnumerable<RoomU1994> GetAll()
        {
            return context.RoomU1994.ToList();
        }
    }
}
