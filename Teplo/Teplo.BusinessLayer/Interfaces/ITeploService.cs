using System.Collections.ObjectModel;

namespace Teplo.BusinessLayer.Interfaces
{
    public interface ITeploService<T>
    {
        ObservableCollection<T> GetAll();
        T Get(int id);
    }
}
