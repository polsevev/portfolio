#pragma checksum "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeefdb9da54580de1d59ad17904ceff1debecd55"
// <auto-generated/>
#pragma warning disable 1591
namespace portfolio.server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\_Imports.razor"
using portfolio.server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\_Imports.razor"
using portfolio.server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : counterClass
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\Pages\Counter.razor"
 if (Repos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading....</em></p>\r\n    ");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\Pages\Counter.razor"
                       getGithub

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 11 "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\Pages\Counter.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.AddMarkupContent(6, @"<div class=""intro-container"">
        <div class=""portrait-img"">
            <img src=""https://scontent.fosl1-1.fna.fbcdn.net/v/t1.0-9/69673511_1099902950205918_4182302319481716736_o.jpg?_nc_cat=108&_nc_sid=09cbfe&_nc_oc=AQlp2jBaa8mY8UVrd6whV5VsS-BeI0p_7UaWsMv_n9BpqpCGQ349x14d8HjxdaDa4Qk&_nc_ht=scontent.fosl1-1.fna&oh=3ee054fe8abd7549ad63bce4b9cea31e&oe=5F108362"" asp-append-version=""true"" width=""200"" height=""200"">
        </div>

        <div class=""text-box"" id=""short-intro-box"">
            <h2>Who am i? </h2>
            <p id=""intro-text"">
                Hi, my name is Rolf Martin Glomsrud and i am studying computer security at
                the university of Bergen. I am currently in my 2nd year of a bachelors degree
                and i welcome you to my portfolio website.
            </p>
        </div>
    </div>
");
#nullable restore
#line 28 "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\Pages\Counter.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, @"<div class=""intro-container"">
    <div class=""portrait-img"">
        <img src=""https://scontent.fosl1-1.fna.fbcdn.net/v/t1.0-9/69673511_1099902950205918_4182302319481716736_o.jpg?_nc_cat=108&_nc_sid=09cbfe&_nc_oc=AQlp2jBaa8mY8UVrd6whV5VsS-BeI0p_7UaWsMv_n9BpqpCGQ349x14d8HjxdaDa4Qk&_nc_ht=scontent.fosl1-1.fna&oh=3ee054fe8abd7549ad63bce4b9cea31e&oe=5F108362"" asp-append-version=""true"" width=""200"" height=""200"">
    </div>

    <div class=""text-box"" id=""short-intro-box"">
        <h2>Who am i? </h2>
        <p id=""intro-text"">
            Hi, my name is Rolf Martin Glomsrud and i am studying computer security at
            the university of Bergen. I am currently in my 2nd year of a bachelors degree
            and i welcome you to my portfolio website.
        </p>
    </div>
</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Rolf\Desktop\Git\Portfolio\portfolio.server\portfolio.server\Pages\Counter.razor"
      
    IList<repos> Repos;


    private async Task getGithub()
    {

        Repos = await http.GetJsonAsync<List<repos>>("https://api.github.com/users/jludden/repos");
    }

    public class repos
    {
        public string Full_Name { get; set; }
        public string Description { get; set; }
        public string HTML_URL { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public string Language { get; set; }
        public bool Fork { get; set; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
