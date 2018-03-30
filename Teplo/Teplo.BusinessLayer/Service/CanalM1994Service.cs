using AutoMapper;
using Teplo.BusinessLayer.Models;
using Teplo.BusinessLayer.Interfaces;
using Teplo.DataLayer.Entities;
using Teplo.DataLayer.Interfaces;
using Teplo.DataLayer.Repository;
using System.Collections.ObjectModel;

namespace Teplo.BusinessLayer.Service
{
    public class CanalM1994Service : ITeploService<CanalM1994ViewModel>
    {
        IUnitOfWork database;
        public CanalM1994Service(string name)
        {
            database = new EntityUnitOfWork(name);
        }
        public CanalM1994ViewModel Get(int id)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CanalM1994, CanalM1994ViewModel>();
            });
            var obj = Mapper.Map<CanalM1994ViewModel>(database.CanalM1944.Get(id));
            return obj;
        }

        public ObservableCollection<CanalM1994ViewModel> GetAll()
        {
            //Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<CanalM1994, CanalM1994ViewModel>();
            //});
            var objts = Mapper.Map<ObservableCollection<CanalM1994ViewModel>>(database.CanalM1944.GetAll());
            return objts;
        }
    }
}
