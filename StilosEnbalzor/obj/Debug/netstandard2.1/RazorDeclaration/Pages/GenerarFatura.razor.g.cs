#pragma checksum "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\Pages\GenerarFatura.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e376500fd76af72b6077a47db1c64d8a5f43acaf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace StilosEnbalzor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\_Imports.razor"
using StilosEnbalzor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\_Imports.razor"
using StilosEnbalzor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\_Imports.razor"
using StilosEnbalzor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\_Imports.razor"
using StilosEnbalzor.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GenerarFatura")]
    public partial class GenerarFatura : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\Pages\GenerarFatura.razor"
 
    Comprobate ComprobateS { get; set; }
    String Mostrar;

    void crear()
    {
        Mostrar = ServicioFactura.CrearFactura(ComprobateS);
    }

    public Comprobate GetComprobate()
    {
        return new Comprobate()
        {
            Folio = "1234"
        };
    }

    public List<string> moneda = new List<string>
{
        "Peso Mexino",
        "Dolar US",
        "Peso Colombiano",
        "Euro",
        "Dolar Canadiense "
    };

    protected override void OnInitialized()
    {
        ComprobateS = GetComprobate();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFactura ServicioFactura { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDatos<Articulo> service { get; set; }
    }
}
#pragma warning restore 1591
