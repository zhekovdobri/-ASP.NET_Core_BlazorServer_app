#pragma checksum "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\Vacancies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "313d4a736bbed0287d97706b5239cdd6b2508eb2"
// <auto-generated/>
#pragma warning disable 1591
namespace AddIdentity.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using AddIdentity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using AddIdentity.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using AddIdentity.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\Vacancies.razor"
using AddIdentity.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vacancies")]
    public partial class Vacancies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center font-weight-bold py-5\">Vacant Positions</h3>\r\n<hr class=\"my-5\">\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row m-3");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-4");
            __builder.AddAttribute(7, "style", "width: 20rem;");
            __builder.OpenComponent<AddIdentity.Pages.JobCard>(8);
            __builder.AddAttribute(9, "Image", "/images/image7.jpg");
            __builder.AddAttribute(10, "Title", "Rørlegger");
            __builder.AddAttribute(11, "Place", "Ålesund");
            __builder.AddAttribute(12, "Count", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\Vacancies.razor"
                       4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "Deadline", "Soon!");
            __builder.AddAttribute(14, "Link", "https://jobzone.no/en/vacancies/67416");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-sm-4");
            __builder.OpenComponent<AddIdentity.Pages.JobCard>(18);
            __builder.AddAttribute(19, "Image", "/images/image8.jpg");
            __builder.AddAttribute(20, "Title", "Kantineassistent");
            __builder.AddAttribute(21, "Place", "Oslo");
            __builder.AddAttribute(22, "Count", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\Vacancies.razor"
                       1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "Deadline", "Soon!");
            __builder.AddAttribute(24, "Link", "https://jobzone.no/en/vacancies/67945");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-sm-4");
            __builder.OpenComponent<AddIdentity.Pages.JobCard>(28);
            __builder.AddAttribute(29, "Image", "/images/image9.jpg");
            __builder.AddAttribute(30, "Title", "Produksjonsmedarbeider");
            __builder.AddAttribute(31, "Place", "Mosjøen");
            __builder.AddAttribute(32, "Count", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 35 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\Vacancies.razor"
                       1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "Deadline", "29.04.22");
            __builder.AddAttribute(34, "Link", "https://jobzone.no/en/vacancies/67946");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "row m-3");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-sm-4");
            __builder.AddAttribute(40, "style", "width: 20rem;");
            __builder.OpenComponent<AddIdentity.Pages.JobCard>(41);
            __builder.AddAttribute(42, "Image", "/images/image10.jpg");
            __builder.AddAttribute(43, "Title", "Regnskapsmedarbeider");
            __builder.AddAttribute(44, "Place", "Straume");
            __builder.AddAttribute(45, "Count", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 49 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\Vacancies.razor"
                       1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "Deadline", "SOON!");
            __builder.AddAttribute(47, "Link", "https://jobzone.no/en/vacancies/67947");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-sm-4");
            __builder.OpenComponent<AddIdentity.Pages.JobCard>(51);
            __builder.AddAttribute(52, "Image", "/images/image11.jpg");
            __builder.AddAttribute(53, "Title", "Vi søker dyktige tømrere");
            __builder.AddAttribute(54, "Place", "Trondheim");
            __builder.AddAttribute(55, "Count", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 59 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\Vacancies.razor"
                       2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "Deadline", "27.04.22");
            __builder.AddAttribute(57, "Link", "https://jobzone.no/en/vacancies/67948");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-sm-4");
            __builder.OpenComponent<AddIdentity.Pages.JobCard>(61);
            __builder.AddAttribute(62, "Image", "/images/image6.jpg");
            __builder.AddAttribute(63, "Title", "Cost Controller - prosjekt");
            __builder.AddAttribute(64, "Place", "Lyngdal");
            __builder.AddAttribute(65, "Count", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 69 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\Vacancies.razor"
                       1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "Deadline", "Soon!");
            __builder.AddAttribute(67, "Link", "https://jobzone.no/en/vacancies/67940");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n<hr class=\"my-5\">\r\n\r\n");
            __builder.AddMarkupContent(69, "<div class=\"col text-center pt-2 mb-5\"><a href=\"https://jobzone.no/en/vacancies/\" class=\"btn btn-outline-danger btn-lg \r\n    font-weight-bold\">View more Vacancies</a></div>\r\n\r\n\r\n");
            __builder.OpenComponent<AddIdentity.Pages.Footer>(70);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
