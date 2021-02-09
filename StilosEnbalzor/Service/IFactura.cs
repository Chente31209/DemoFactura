using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StilosEnbalzor.Models;


namespace StilosEnbalzor.Service
{
    interface IFactura
    {
        String  CrearFactura(Comprobate comprobate);
        void MotrarFactura();

    }
}
