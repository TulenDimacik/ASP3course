#pragma checksum "D:\C#\РПМ\Asppract\RPM_3_Course\RPM_3_Course\Views\Home\PostsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c291956472be6ef6bc32aa831f73de88631c49e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PostsView), @"mvc.1.0.view", @"/Views/Home/PostsView.cshtml")]
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
#line 1 "D:\C#\РПМ\Asppract\RPM_3_Course\RPM_3_Course\Views\_ViewImports.cshtml"
using RPM_3_Course;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\РПМ\Asppract\RPM_3_Course\RPM_3_Course\Views\_ViewImports.cshtml"
using RPM_3_Course.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c291956472be6ef6bc32aa831f73de88631c49e5", @"/Views/Home/PostsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65c99c9b5d36bc3c58c81e532b9ccb2a0448a5de", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PostsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RPM_3_Course.Models.PostViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OtherUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#\РПМ\Asppract\RPM_3_Course\RPM_3_Course\Views\Home\PostsView.cshtml"
   ViewData["Title"] = "Лента"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div style=\"margin: 0 75% 0 15%; width: 10%;\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c291956472be6ef6bc32aa831f73de88631c49e54595", async() => {
                WriteLiteral("Назад");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\n</div>\n");
#nullable restore
#line 7 "D:\C#\РПМ\Asppract\RPM_3_Course\RPM_3_Course\Views\Home\PostsView.cshtml"
 foreach (var item in Model.posts)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"margin: 0 70% 0 10%; width: 20%;\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c291956472be6ef6bc32aa831f73de88631c49e56120", async() => {
                WriteLiteral("Пользователь №");
#nullable restore
#line 11 "D:\C#\РПМ\Asppract\RPM_3_Course\RPM_3_Course\Views\Home\PostsView.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "D:\C#\РПМ\Asppract\RPM_3_Course\RPM_3_Course\Views\Home\PostsView.cshtml"
                                                      WriteLiteral(item.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n   <p style=\"color:white\"> ");
#nullable restore
#line 12 "D:\C#\РПМ\Asppract\RPM_3_Course\RPM_3_Course\Views\Home\PostsView.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n");
            WriteLiteral("                <div style=\"margin: 0 45% 0 45%; width: 10%;color: aquamarine;\">\n                    <p> ");
#nullable restore
#line 16 "D:\C#\РПМ\Asppract\RPM_3_Course\RPM_3_Course\Views\Home\PostsView.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n                <div style=\" margin: 0 25% 0 25%; width: 50%;\">                                                     \n                    <img align=\"middle\" width=\"490\" height=\"400\"");
            BeginWriteAttribute("src", " src=\"", 867, "\"", 909, 1);
#nullable restore
#line 19 "D:\C#\РПМ\Asppract\RPM_3_Course\RPM_3_Course\Views\Home\PostsView.cshtml"
WriteAttributeValue("", 873, Url.Content(item.Pictureepost.Path), 873, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                </div>\n                <div style=\" margin: 0 25% 0 25%; width: 50%; color:lightskyblue\">\n                <p> ");
#nullable restore
#line 22 "D:\C#\РПМ\Asppract\RPM_3_Course\RPM_3_Course\Views\Home\PostsView.cshtml"
               Write(Html.DisplayFor(modelItem => item.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n");
#nullable restore
#line 24 "D:\C#\РПМ\Asppract\RPM_3_Course\RPM_3_Course\Views\Home\PostsView.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    body {
        background: #222D32;
        font-family: 'Roboto', sans-serif;
    }

    .login-box {
        margin-top: 75px;
        height: auto;
        background: #1A2226;
        text-align: center;
        box-shadow: 0 3px 6px rgba(0, 0, 0, 0.16), 0 3px 6px rgba(0, 0, 0, 0.23);
    }

    .login-key {
        height: 100px;
        font-size: 80px;
        line-height: 100px;
        background: -webkit-linear-gradient(#27EF9F, #0DB8DE);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
    }

    .login-title {
        margin-top: 15px;
        text-align: center;
        font-size: 30px;
        letter-spacing: 2px;
        margin-top: 15px;
        font-weight: bold;
        color: #ECF0F5;
    }

    .login-form {
        margin-top: 25px;
        text-align: left;
    }

    input[type=text] {
        background-color: #1A2226;
        border: none;
        border-bottom: 2px solid #0DB8DE;
        border-top: 0px;
        border-radius: 0px;
   ");
            WriteLiteral(@"     font-weight: bold;
        outline: 0;
        margin-bottom: 20px;
        padding-left: 0px;
        color: #ECF0F5;
    }

    input[type=password] {
        background-color: #1A2226;
        border: none;
        border-bottom: 2px solid #0DB8DE;
        border-top: 0px;
        border-radius: 0px;
        font-weight: bold;
        outline: 0;
        padding-left: 0px;
        margin-bottom: 20px;
        color: #ECF0F5;
    }

    .form-group {
        margin-bottom: 40px;
        outline: 0px;
    }

    .form-control:focus {
        border-color: inherit;
        -webkit-box-shadow: none;
        box-shadow: none;
        border-bottom: 2px solid #0DB8DE;
        outline: 0;
        background-color: #1A2226;
        color: #ECF0F5;
    }

    input:focus {
        outline: none;
        box-shadow: 0 0 0;
    }

    label {
        margin-bottom: 0px;
    }

    .form-control-label {
        font-size: 10px;
        color: #6C6C6C;
        font-weight: bold;
        letter-spacing: 1px;
    }
");
            WriteLiteral(@"
    .btn-outline-primary {
        border-color: #0DB8DE;
        color: #0DB8DE;
        border-radius: 0px;
        font-weight: bold;
        letter-spacing: 1px;
        box-shadow: 0 1px 3px rgba(0, 0, 0, 0.12), 0 1px 2px rgba(0, 0, 0, 0.24);
    }

        .btn-outline-primary:hover {
            background-color: #0DB8DE;
            right: 0px;
        }

    .login-btm {
        float: right;
    }

    .login-button {
        padding-right: 0px;
        text-align: right;
        margin-bottom: 25px;
    }

    .login-text {
        text-align: left;
        padding-left: 0px;
        color: #A2A4A4;
    }

    .loginbttm {
        padding: 0px;
    }

    .table {
        color: blueviolet;
        border: solid 2px #ECF0F5;
        outline: solid 1px #ECF0F5;
    }

    .tr {
        border: solid 1px #ECF0F5;
        outline: solid 1px #ECF0F5;
    }

    .td {
        border: solid 1px #ECF0F5;
        outline: solid 1px #ECF0F5;
    }
</style>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RPM_3_Course.Models.PostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
