using AutoMapper;
using Teplo.BusinessLayer.Models;
using Teplo.BusinessLayer.Interfaces;
using Teplo.DataLayer.Entities;
using Teplo.DataLayer.Interfaces;
using Teplo.DataLayer.Repository;
using System.Collections.ObjectModel;

namespace Teplo.BusinessLayer.Service
{
    public class CanalU1994Service : ITeploService<CanalU1994ViewModel>
    {
        IUnitOfWork database;
        public CanalU1994Service(string name)
        {
            database = new EntityUnitOfWork(name);
        }
        public CanalU1994ViewModel Get(int id)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CanalU1994, CanalU1994ViewModel>();
            });
            var obj = Mapper.Map<CanalU1994ViewModel>(database.CanalU1994.Get(id));
            return obj;
        }

        public ObservableCollection<CanalU1994ViewModel> GetAll()
        {
            //Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<CanalU1994, CanalU1994ViewModel>();
            //});
            var objts = Mapper.Map<ObservableCollection<CanalU1994ViewModel>>(database.CanalU1994.GetAll());
            return objts;
        }
    }
}
