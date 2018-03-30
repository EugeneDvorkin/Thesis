using System;
using Teplo.DataLayer.Entities;

namespace Teplo.DataLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable    
    {
        IReposotory<SteamU1994> SteamU1994 { get; }
        IReposotory<SteamM1994> SteamM1994 { get; }    
        IReposotory<CanalM1994> CanalM1944 { get; }
        IReposotory<CanalU1994> CanalU1994 { get; }
        IReposotory<RoomU1994> RoomU1994 { get; }
    }
}
