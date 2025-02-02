#pragma checksum "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\Pages\About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f892e3481e949ef52e2bcf69f2b3f876c7e2c87"
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
#line 12 "C:\Users\Dobri\Downloads\AddIdentity\AddIdentity\_Imports.razor"
using AddIdentity.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/about")]
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "section");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "container-fluid");
                __builder2.AddMarkupContent(5, "<div class=\"text-center text-light mb-md-3 py-4\" style=\"background: rgb(0, 0, 255, 0.3)\"><h3 class=\"card-title\">About Dobri Zhekov</h3></div>\r\n        ");
                __builder2.AddMarkupContent(6, "<div class=\"row bg-light.bg-gradient\"><div class=\"col-lg-3 mb-4\"><img class=\"card-img-top\" src=\"/images/passpic.png\" alt=\"Card image cap\"></div>\r\n\r\n            <div class=\"col-lg-3 mb-4\"><p>\r\n                    Dobri Zhekov nicknamed “Insider78″ was born in 1978. One and only son of a \r\n                    working, middle-class family, Zhekov was quickly ” brought up to speed ” through \r\n                    life’s challanges and misfortunes. He earned his bachelor’s degree in Marketing \r\n                    and Management from the International University College Albena in 2006. Then he \r\n                    took his second bachelor’s degree in Business Management from D. A. Tsenov Academy \r\n                    of Economics Svishtov. In 2021 he earned his third higher education as a Full Stack \r\n                    Web Developer from Software Academy Net It.\r\n                </p>\r\n                <a href=\"https://www.linkedin.com/in/dobri-zhekov-838bb51b/\" class=\"card-link text-danger\"><i class=\"fab fa-linkedin\"></i> Linkedin\r\n                </a>\r\n                <a href=\"https://github.com/zhekovdobri\" class=\"card-link text-danger\"><i class=\"fa-brands fa-github\"></i> GitHub\r\n                </a></div>\r\n\r\n            <div class=\"col-lg-6\" style=\"background-color: rgba(0, 0, 0, 0.05);\"><h4 class=\"my-2\">Education</h4>\r\n            \r\n\r\n            <div class=\"row\"><div class=\"col-lg-4\"><div class=\"card\"><img class=\"card-img-top\" src=\"/images/svishtov.jpg\" alt=\"Card image cap\">\r\n                        <div class=\"card-body\"><p class=\"card-text\">D. А. Tsenov Academy of Economics is a leading economics and \r\n                            business higher education institution in Svishtov, Bulgaria with more than 83 \r\n                            years of history, 145 000 alumni and a well-established reputation in education, \r\n                            science and project management.</p>\r\n                            <a href=\"https://www-uni--svishtov-bg.translate.goog/en/about-university/profile-0/the-history-of-the-academy-of-economics?_x_tr_sl=bg&_x_tr_tl=en&_x_tr_hl=no&_x_tr_pto=nui,sc\" class=\"card-link text-danger\">Learn more</a></div></div></div>\r\n\r\n            <div class=\"col-lg-4\"><div class=\"card\"><img class=\"card-img-top\" src=\"/images/albena.jpg\" alt=\"Card image cap\">\r\n                        <div class=\"card-body\"><p class=\"card-text\">University College Albena - VUM was founded as Bulgarian-Dutch Institute \r\n                            of Management. VUM was the first private higher school to teach its subjects entirely in \r\n                            English language and to offer joint degrees. The first higher school in Bulgaria \r\n                            to apply BBL methods. \r\n                            </p>\r\n                            <a href=\"https://vum.bg/history/\" class=\"card-link text-danger\">Learn more</a></div></div></div>\r\n\r\n            <div class=\"col-lg-4\"><div class=\"card\"><img class=\"card-img-top\" src=\"/images/netit.jpg\" alt=\"Card image cap\">\r\n                        <div class=\"card-body\"><p class=\"card-text\">Net It is a private educational company established in 2014 with funding from \r\n                            the European Employment Agency. Net It has four academies: Marketing, Design, Software and \r\n                            Accounting. It is an \"Incubator\" for freelancers, as well as a licensed career center,</p>\r\n                            <a href=\"http://netit.bg/\" class=\"card-link text-danger\">Learn more</a></div></div></div></div></div></div>\r\n       \r\n\r\n    ");
                __builder2.OpenComponent<AddIdentity.Pages.Footer>(7);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(8, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<AddIdentity.Pages.StartCarousel>(9);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
