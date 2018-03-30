using AutoMapper;
using Teplo.DataLayer.Entities;
using Teplo.DataLayer.Interfaces;
using Teplo.DataLayer.Repository;
using Teplo.BusinessLayer.Models;
using Teplo.BusinessLayer.Interfaces;
using System.Collections.ObjectModel;

namespace Teplo.BusinessLayer.Service
{
    public class SteamU1994Service : ITeploService<SteamU1994ViewModel>
    {
        IUnitOfWork database;
        public SteamU1994Service(string name)
        {
            database = new EntityUnitOfWork(name);
        }
        public SteamU1994ViewModel Get(int id)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<SteamU1994, SteamU1994ViewModel>();
            });
            var obj = Mapper.Map<SteamU1994ViewModel>(database.SteamU1994.Get(id));
            return obj;
        }

        public ObservableCollection<SteamU1994ViewModel> GetAll()
        {
            //Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<SteamU1994, SteamU1994ViewModel>();
            //});
            var objts = Mapper.Map<ObservableCollection<SteamU1994ViewModel>>(database.SteamU1994.GetAll());
            return objts;
        }
    }
}
