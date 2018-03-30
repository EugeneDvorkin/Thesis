using AutoMapper;
using Teplo.BusinessLayer.Models;
using Teplo.BusinessLayer.Interfaces;
using Teplo.DataLayer.Entities;
using Teplo.DataLayer.Interfaces;
using Teplo.DataLayer.Repository;
using System.Collections.ObjectModel;

namespace Teplo.BusinessLayer.Service
{
    public class SteamM1994Service : ITeploService<SteamM1994ViewModel>
    {
        IUnitOfWork database;
        public SteamM1994Service(string name)
        {
            database = new EntityUnitOfWork(name);
        }
        public SteamM1994ViewModel Get(int id)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<SteamM1994, SteamM1994ViewModel>();
            });
            var obj = Mapper.Map<SteamM1994ViewModel>(database.SteamM1994.Get(id));
            return obj;
        }

        public ObservableCollection<SteamM1994ViewModel> GetAll()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<SteamM1994, SteamM1994ViewModel>();
            });
            var objts = Mapper.Map<ObservableCollection<SteamM1994ViewModel>>(database.SteamM1994.GetAll());
            return objts;
        }
    }
}
