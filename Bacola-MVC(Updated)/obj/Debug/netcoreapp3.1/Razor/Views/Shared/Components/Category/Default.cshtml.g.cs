#pragma checksum "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola-Create,Services\Bacola-MVC(Updated)\Views\Shared\Components\Category\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca6a995db9e85f79479d6f449db1921045fe889f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Category_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Category/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola-Create,Services\Bacola-MVC(Updated)\Views\_ViewImports.cshtml"
using Bacola_MVC_Updated_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola-Create,Services\Bacola-MVC(Updated)\Views\_ViewImports.cshtml"
using Bacola_MVC_Updated_.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola-Create,Services\Bacola-MVC(Updated)\Views\_ViewImports.cshtml"
using Bacola_MVC_Updated_.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca6a995db9e85f79479d6f449db1921045fe889f", @"/Views/Shared/Components/Category/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1298365c1eacdb00b69ccaa240d5fe90460039ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Category_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"dropdown-menu mt-5\">\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola-Create,Services\Bacola-MVC(Updated)\Views\Shared\Components\Category\Default.cshtml"
     foreach (var category in Model.Categories)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><a");
            BeginWriteAttribute("href", " href=\"", 118, "\"", 125, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola-Create,Services\Bacola-MVC(Updated)\Views\Shared\Components\Category\Default.cshtml"
                  Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fas fa-angle-right\"></i></a> </li>\r\n");
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Bacola-Create,Services\Bacola-MVC(Updated)\Views\Shared\Components\Category\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
