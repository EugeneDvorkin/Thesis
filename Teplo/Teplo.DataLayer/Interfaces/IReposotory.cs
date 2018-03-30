using System.Collections.Generic;

namespace Teplo.DataLayer.Interfaces
{
    public interface IReposotory<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}
