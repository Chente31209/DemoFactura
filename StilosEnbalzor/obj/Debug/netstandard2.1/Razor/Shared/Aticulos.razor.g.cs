#pragma checksum "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\Shared\Aticulos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "965dd88c32a36634b806da06a6506efc13025ec4"
// <auto-generated/>
#pragma warning disable 1591
namespace StilosEnbalzor.Shared
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
    public partial class Aticulos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "grid  grid-rows-3");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, @"<div style>

        <input type=""text"" class=""appearance-none rounded-none  w-1/2 px-3 py-2
                   border border-gray-300 placeholder-gray-500 text-gray-900
                   rounded-t-md focus:outline-none focus:ring-indigo-500
                   focus:border-indigo-500 focus:z-10 sm:text-sm"" placeholder=""Buscar Articulo Por (Nombre)"">

        <button class=""group relative w-100  px-3 py-2 justify-self-start  border border-transparent
                     text-sm font-medium rounded-md text-white bg-indigo-600 hover:bg-indigo-700
                     focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
            Buscar
        </button>
        <button class=""group relative w-100  px-3 py-2 justify-self-start border border-transparent
                      text-sm font-medium rounded-md text-white bg-indigo-600 hover:bg-indigo-700
                      focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
            Agregar
        </button>


    </div>

    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", true);
            __builder.AddAttribute(6, "class", " h-32 overflow-auto");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "min-w-full divide-y divide-gray-200");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, @"<thead>
                    <tr>
                        <th class=""px-6 py-3 text-left text-xs font-medium text-black uppercase tracking-wider bg-indigo-400"">
                            Articulo
                        </th>
                        <th class=""px-6 py-3 text-left text-xs font-medium text-black uppercase tracking-wider bg-indigo-300"">
                            Nombre
                        </th>
                        <th class=""px-6 py-3 text-left text-xs font-medium text-black uppercase tracking-wider bg-indigo-400"">
                            UM
                        </th>
                        <th class=""px-6 py-3 text-left text-xs font-medium text-black uppercase tracking-wider bg-indigo-300"">
                            Unidades
                        </th>
                        <th class=""px-6 py-3 text-left text-xs font-medium text-black uppercase tracking-wider bg-indigo-400"">
                            Precio
                        </th>
                        <th class=""px-6 py-3 text-left text-xs font-medium text-black uppercase tracking-wider bg-indigo-300"">
                            Decuento
                        </th>
                        <th class=""px-6 py-3 text-left text-xs font-medium text-black uppercase tracking-wider bg-indigo-400"">
                            Importe
                        </th>
                    </tr>
                </thead>


                ");
            __builder.OpenElement(14, "tbody");
            __builder.AddAttribute(15, "class", "bg-white divide-y divide-gray-200 ");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 56 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\Shared\Aticulos.razor"
                     foreach (var item in Articulos)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                        ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\r\n                            ");
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "class", "px-6 py-4 whitespace-nowrap ");
            __builder.AddContent(22, 
#nullable restore
#line 59 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\Shared\Aticulos.razor"
                                                                      item.articulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "class", "px-6 py-4 whitespace-nowrap ");
            __builder.AddContent(26, 
#nullable restore
#line 60 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\Shared\Aticulos.razor"
                                                                      item.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "class", "px-6 py-4 whitespace-nowrap ");
            __builder.AddContent(30, 
#nullable restore
#line 61 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\Shared\Aticulos.razor"
                                                                      item.Um

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "class", "px-6 py-4 whitespace-nowrap ");
            __builder.AddContent(34, 
#nullable restore
#line 62 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\Shared\Aticulos.razor"
                                                                      item.Unidades

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.OpenElement(36, "td");
            __builder.AddAttribute(37, "class", "px-6 py-4 whitespace-nowrap ");
            __builder.AddContent(38, 
#nullable restore
#line 63 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\Shared\Aticulos.razor"
                                                                      item.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                            ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "class", "px-6 py-4 whitespace-nowrap ");
            __builder.AddContent(42, 
#nullable restore
#line 64 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\Shared\Aticulos.razor"
                                                                      item.Decuento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                            ");
            __builder.OpenElement(44, "td");
            __builder.AddAttribute(45, "class", "px-6 py-4 whitespace-nowrap ");
            __builder.AddContent(46, 
#nullable restore
#line 65 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\Shared\Aticulos.razor"
                                                                      item.Importe

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 68 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\Shared\Aticulos.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "D:\User\Vicente\Proyectos\Web Proyets\Sample gulm\StilosEnbalzor\StilosEnbalzor\Shared\Aticulos.razor"
 
    [Parameter]
    public List<Articulo> Articulos { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
