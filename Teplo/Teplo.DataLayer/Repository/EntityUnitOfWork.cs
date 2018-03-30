using System;
using Teplo.DataLayer.EFContext;
using Teplo.DataLayer.Entities;
using Teplo.DataLayer.Interfaces;

namespace Teplo.DataLayer.Repository
{
    public class EntityUnitOfWork : IUnitOfWork
    {
        TeploContext context;
        SteamM1994Repository steamM1994Repositiry;
        SteamU1994Repository steamU1994Repository;
        CanalM1994Repository canalM1994Repository;
        CanalU1994Repository canalU1994Repository;
        RoomU1994Repository roomU1994Repository;
        public EntityUnitOfWork(string name)
        {
            context = new TeploContext(name);
        }
        public IReposotory<SteamU1994> SteamU1994
        {
            get
            {
               if(steamU1994Repository==null)
               {
                    steamU1994Repository = new SteamU1994Repository(context);
               }
               return steamU1994Repository;
            }
        }

        public IReposotory<SteamM1994> SteamM1994
        {
            get
            {
                if (steamM1994Repositiry == null)
                {
                    steamM1994Repositiry = new SteamM1994Repository(context);
                }
                return steamM1994Repositiry;
            }
        }

        public IReposotory<CanalM1994> CanalM1944
        {
            get
            {
                if (canalM1994Repository == null)
                {
                    canalM1994Repository = new CanalM1994Repository(context);
                }
                return canalM1994Repository;
            }
        }

        public IReposotory<CanalU1994> CanalU1994
        {
            get
            {
                if (canalU1994Repository == null)
                {
                    canalU1994Repository = new CanalU1994Repository(context);
                }
                return canalU1994Repository;
            }
        }

        public IReposotory<RoomU1994> RoomU1994
        {
            get
            {
                if (roomU1994Repository == null)
                {
                    roomU1994Repository = new RoomU1994Repository(context);
                }
                return roomU1994Repository;
            }
        }      
        
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
