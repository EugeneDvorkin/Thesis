using AutoMapper;
using Teplo.BusinessLayer.Models;
using Teplo.BusinessLayer.Interfaces;
using Teplo.DataLayer.Entities;
using Teplo.DataLayer.Interfaces;
using Teplo.DataLayer.Repository;
using System.Collections.ObjectModel;

namespace Teplo.BusinessLayer.Service
{
    public class RoomU1994Service:ITeploService<RoomU1994ViewModel>
    {
        IUnitOfWork database;
        public RoomU1994Service(string name)
        {
            database = new EntityUnitOfWork(name);
        }
        public RoomU1994ViewModel Get(int id)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<RoomU1994, RoomU1994ViewModel>();
            });
            var obj = Mapper.Map<RoomU1994ViewModel>(database.RoomU1994.Get(id));
            return obj;
        }

        public ObservableCollection<RoomU1994ViewModel> GetAll()
        {
            //Mapper.Initialize(cfg =>
            //{
            //    cfg.CreateMap<RoomU1994, RoomU1994ViewModel>();
            //});
            var objts = Mapper.Map<ObservableCollection<RoomU1994ViewModel>>(database.RoomU1994.GetAll());
            return objts;
        }
    }
}
