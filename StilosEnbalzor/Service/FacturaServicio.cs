using StilosEnbalzor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StilosEnbalzor.Service
{
    public class FacturaServicio : IFactura
    {
        public String CrearFactura(Comprobate comprobate)
        {
            return JsonSerializer.Serialize(comprobate);
        }

        public void MotrarFactura()
        {
            throw new NotImplementedException();
        }
    }
}
