#pragma checksum "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1eb6b3f72c517a64aab4580b8ac2155c91d4e05"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AdultList")]
    public partial class AdultList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
 if (adults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 13 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
}
else if (!adults.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p>\r\n        <em>No Adult items exist. Please add some </em>\r\n    </p>\r\n");
#nullable restore
#line 19 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "thead");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, "<th>ID</th>\r\n            ");
            __builder.AddMarkupContent(14, "<th>First name</th>\r\n            ");
            __builder.AddMarkupContent(15, "<th>Last name</th>\r\n            ");
            __builder.AddMarkupContent(16, "<th>Hair color</th>\r\n            ");
            __builder.AddMarkupContent(17, "<th>Eye color</th>\r\n            ");
            __builder.AddMarkupContent(18, "<th>Age</th>\r\n            ");
            __builder.AddMarkupContent(19, "<th>Weight</th>\r\n            ");
            __builder.AddMarkupContent(20, "<th>Height</th>\r\n            ");
            __builder.AddMarkupContent(21, "<th>Sex</th>\r\n            ");
            __builder.AddMarkupContent(22, "<th>Job</th>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(23);
            __builder.AddAttribute(24, "Policy", "MustBeAdmin");
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.AddMarkupContent(27, "<th>Remove</th>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "tbody");
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 42 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
         foreach (var item in adults)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "            ");
            __builder.OpenElement(34, "tr");
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 45 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 46 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 47 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 48 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 49 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 50 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 51 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 52 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 53 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 54 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
                     item.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(66);
            __builder.AddAttribute(67, "Policy", "MustBeAdmin");
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(69, "\r\n                   ");
                __builder2.OpenElement(70, "td");
                __builder2.AddMarkupContent(71, "\r\n                       ");
                __builder2.OpenElement(72, "button");
                __builder2.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
                                           () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(74, "\r\n                           <i class=\"oi oi-trash\"></i>\r\n                       ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                   ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(77, "\r\n                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 64 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 67 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\elena\RiderProjects\Assignment1\Assignment1\Pages\AdultList.razor"
       
    private IList<Adult> adults;
    
    protected override async Task OnInitializedAsync()
    {
        adults = AdultsService.GetAdults();
    }
    
    private void RemoveAdult(int Id)
    {
        Adult adultToRemove = adults.First(a => a.Id == Id);
        AdultsService.RemoveAdult(Id);
        adults.Remove(adultToRemove);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsService AdultsService { get; set; }
    }
}
#pragma warning restore 1591
