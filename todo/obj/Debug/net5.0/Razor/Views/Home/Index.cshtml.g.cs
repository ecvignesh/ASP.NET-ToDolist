#pragma checksum "D:\project\c-sharp-todo\Todo\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "250d763c988a91e28736466bc9f857ee0bcfb020c34419c3d0e84a1d514715d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\project\c-sharp-todo\Todo\Views\_ViewImports.cshtml"
using Todo

#nullable disable
    ;
#nullable restore
#line 2 "D:\project\c-sharp-todo\Todo\Views\_ViewImports.cshtml"
using Todo.Models

#nullable disable
    ;
#nullable restore
#line 3 "D:\project\c-sharp-todo\Todo\Views\_ViewImports.cshtml"
using Todo.Models.ViewModels

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"250d763c988a91e28736466bc9f857ee0bcfb020c34419c3d0e84a1d514715d6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a3922e2cef7ab1db79a808938cd6b73115fee5172967a30a0fb1000f33220360", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row justify-content-center"">
    <div class=""col-xl-6 col-lg-8 col-md-8 col-sm-10"">
        <table class=""table"">
            <thead>
                <tr class=""table-primary"">
                    <th scope=""col"">Id</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 14 "D:\project\c-sharp-todo\Todo\Views\Home\Index.cshtml"
                 foreach (var t in Model.TodoList)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <tr>\r\n                        <th class=\"todos-column\" scope=\"row\">");
            Write(
#nullable restore
#line 17 "D:\project\c-sharp-todo\Todo\Views\Home\Index.cshtml"
                                                              t.Id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                        <td class=\"todos-column\">");
            Write(
#nullable restore
#line 18 "D:\project\c-sharp-todo\Todo\Views\Home\Index.cshtml"
                                                  t.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td class=\"buttons-column\">\r\n                            <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\"");
            BeginWriteAttribute("onClick", " onClick=\"", 791, "\"", 818, 3);
            WriteAttributeValue("", 801, "deleteTodo(", 801, 11, true);
            WriteAttributeValue("", 812, 
#nullable restore
#line 20 "D:\project\c-sharp-todo\Todo\Views\Home\Index.cshtml"
                                                                                                            t.Id

#line default
#line hidden
#nullable disable
            , 812, 5, false);
            WriteAttributeValue("", 817, ")", 817, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <input type=\"submit\" class=\"btn btn-primary\" value=\"Update\"");
            BeginWriteAttribute("onClick", " onClick=\"", 911, "\"", 940, 3);
            WriteAttributeValue("", 921, "populateForm(", 921, 13, true);
            WriteAttributeValue("", 934, 
#nullable restore
#line 21 "D:\project\c-sharp-todo\Todo\Views\Home\Index.cshtml"
                                                                                                               t.Id

#line default
#line hidden
#nullable disable
            , 934, 5, false);
            WriteAttributeValue("", 939, ")", 939, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 25 "D:\project\c-sharp-todo\Todo\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
