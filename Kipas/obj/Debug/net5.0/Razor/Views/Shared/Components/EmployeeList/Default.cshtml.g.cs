#pragma checksum "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Components\EmployeeList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17d394ab78d48d3388aa9aebd4334feb9024c911"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_EmployeeList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/EmployeeList/Default.cshtml")]
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
#line 1 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\_ViewImports.cshtml"
using Kipas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Components\EmployeeList\Default.cshtml"
using Kipas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d394ab78d48d3388aa9aebd4334feb9024c911", @"/Views/Shared/Components/EmployeeList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a8a97133eef3ad4640a029fed10dd00354e1409", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_EmployeeList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Components\EmployeeList\Default.cshtml"
         foreach (var n in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 12 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Components\EmployeeList\Default.cshtml"
               Write(n.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 13 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Components\EmployeeList\Default.cshtml"
               Write(n.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 14 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Components\EmployeeList\Default.cshtml"
               Write(n.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 15 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Components\EmployeeList\Default.cshtml"
                Write(Convert.ToDateTime(n.BirthDate).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Components\EmployeeList\Default.cshtml"
               Write(n.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 17 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Components\EmployeeList\Default.cshtml"
                Write(Convert.ToDateTime(n.HireDate).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 19 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Components\EmployeeList\Default.cshtml"
               Write(n.State.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("class", " class=\"", 641, "\"", 649, 0);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" data-toggle=\"modal\" data-target=\"#modal-Guncelle\" title=\"G??ncelle\"\r\n                       data-button=\"edit\" data-Id=\"");
#nullable restore
#line 22 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Components\EmployeeList\Default.cshtml"
                                              Write(n.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> Edit</a>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Components\EmployeeList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<script>\r\n     $(document).ready(x => {\r\n\r\n\r\n            let _json = JSON.parse(JSON.stringify(");
#nullable restore
#line 33 "C:\Users\nur09\source\repos\Kipas\Kipas\Views\Shared\Components\EmployeeList\Default.cshtml"
                                             Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"));
            console.log(_json);
        if (list == null) {
            list = _json;
        }
        else {
            for (let i = 0; i < _json.length; i++) {
                list.push(_json[i]);
            }
        }




        //edit buton
        $(""[data-button='edit']"").unbind('click');
        $(""[data-button='edit']"").click(function () {
            let _id = $(this).data(""id"");

            let obj = list.find(x => x.id == _id);


            $(""input[id='G_Id']"").val(_id);
            $(""input[id='G_FirstName']"").val(obj.firstName);
            $(""input[id='G_LastName']"").val(obj.lastName);
            $(""input[id='G_Title']"").val(obj.title);
            let t = new Date(obj.birthDate);
            let t2 = new Date(obj.hireDate);
            $(""input[id='G_BirthDate']"").val(formatDate(t, ""-"") );
           
         
            $(""input[id='G_Position']"").val(obj.position);
            $(""input[id='G_HireDate']"").val(formatDate(t2, ""-"") );
            $(");
            WriteLiteral(@"""#G_Notes"").val(obj.notes);
            $(""#G_StateId"").val(obj.stateId);
     
            $(""#G_Address"").val(obj.address);


        });

      
   });
    function formatDate(date, operator) {
        var d = new Date(date),
            month = '' + (d.getMonth() + 1),
            day = '' + d.getDate(),
            year = d.getFullYear(),
            hours = d.getHours(),
            minutes = d.getMinutes();
        if (month.length < 2)
            month = '0' + month;
        if (day.length < 2)
            day = '0' + day;
        if (hours.length < 2)
            hours = '0' + hours;
        if (minutes.length < 2)
            minutes = '0' + minutes;
        return [year, month, day].join(operator);
    }

</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
