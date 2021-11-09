using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.interfaces
{
    public interface IService<T>
    {
        List<T> GetAll();
    }
}
