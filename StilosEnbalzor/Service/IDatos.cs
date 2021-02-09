using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StilosEnbalzor.Service
{
    public interface IDatos<T>
    {
        void Add();
        
        List<T> GetList();

    }
}
