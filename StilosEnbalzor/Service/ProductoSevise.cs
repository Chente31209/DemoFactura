using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StilosEnbalzor.Models;

namespace StilosEnbalzor.Service
{
    public class ProductoSevise : IDatos<Articulo>
    {
        List<Articulo> articulos = new List<Articulo>
    {
        new Articulo{articulo ="Jabon",Nombre="Zoote",Precio="21",Decuento="1%",Um="Piesa",Unidades="13",Importe="237"},
        new Articulo{articulo ="Jabon",Nombre="Zoote",Precio="21",Decuento="1%",Um="Piesa",Unidades="13",Importe="237"},
        new Articulo{articulo ="Jabon",Nombre="Zoote",Precio="21",Decuento="1%",Um="Piesa",Unidades="13",Importe="237"},
        new Articulo{articulo ="Jabon",Nombre="Zoote",Precio="21",Decuento="1%",Um="Piesa",Unidades="13",Importe="237"},
        new Articulo{articulo ="Jabon",Nombre="Zoote",Precio="21",Decuento="1%",Um="Piesa",Unidades="13",Importe="237"},
        new Articulo{articulo ="Jabon",Nombre="Zoote",Precio="21",Decuento="1%",Um="Piesa",Unidades="13",Importe="237"},
        new Articulo{articulo ="Jabon",Nombre="Zoote",Precio="21",Decuento="1%",Um="Piesa",Unidades="13",Importe="237"},
    };
        public void Add()
        {
            throw new NotImplementedException();
        }

        public List<Articulo> GetList()
        {
            return this.articulos;
        }
    }
}
