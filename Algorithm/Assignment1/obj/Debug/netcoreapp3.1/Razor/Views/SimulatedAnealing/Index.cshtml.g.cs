#pragma checksum "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a8fa6f3b643fee7f4e72269a5b1556b67d161fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SimulatedAnealing_Index), @"mvc.1.0.view", @"/Views/SimulatedAnealing/Index.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\_ViewImports.cshtml"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\_ViewImports.cshtml"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a8fa6f3b643fee7f4e72269a5b1556b67d161fd", @"/Views/SimulatedAnealing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f0efab5ddbb0a5c18cf004c4d9e07516f4dd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_SimulatedAnealing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment1.ViewModel.SimulatedAnealingVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "dim", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenerateRandomState", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("T0ID"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("coolingFactorID"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var k = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .container{
        width: 100%;
        margin: 20px;
    }
    .chess-board{
        width: 550px;
        height: 550px;
        text-align: center;
        border: 5px solid black;
        float: left;
        margin-bottom: 20px;
    }
    .white {
            width: ");
#nullable restore
#line 20 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
               Write(540/Model.dimension+"px");

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            height:");
#nullable restore
#line 21 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
               Write(540/Model.dimension+"px");

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            background-color: white;\r\n            text-align: center;\r\n            vertical-align: middle;\r\n            float: left;\r\n            font-size: 60px;\r\n            display: table-cell;\r\n    }\r\n    .black{\r\n        width: ");
#nullable restore
#line 30 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
           Write(540/Model.dimension+"px");

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        height: ");
#nullable restore
#line 31 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
            Write(540/Model.dimension+"px");

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        background-color: #808080;
        text-align: center;
        vertical-align: middle;
        float: left;
        font-size: 60px;
        display: table-cell;
    }
    #NbSteps {
        margin-top: 5px;
        margin-bottom: 5px;
        width: 50px;
    }
</style>
<h3>Simulated anealing algorithm</h3>

<div id=""container"" class=""container"">
    <div class=""chess-board"">
");
#nullable restore
#line 49 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
         for (int i = 0; i < Model.dimension; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < Model.dimension; j++)
                {
                    if (j % 2 == 0)
                    {
                        if (Model.array[k] == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"white\">&#9813;</div>\r\n");
#nullable restore
#line 60 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"white\"></div>\r\n");
#nullable restore
#line 65 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
                        }
                    }
                    else
                    {
                        if (Model.array[k] == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"black\">&#9813;</div>\r\n");
#nullable restore
#line 72 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"black\"></div>\r\n");
#nullable restore
#line 77 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"

                        }
                    }
                    k++;
                }

            }
            else
            {
                for (int j = 0; j < Model.dimension; j++)
                {
                    if (j % 2 == 0)
                    {
                        if (Model.array[k] == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"black\">&#9813;</div>\r\n");
#nullable restore
#line 93 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"black\"></div>\r\n");
#nullable restore
#line 98 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
                        }
                    }
                    else
                    {
                        if (Model.array[k] == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"white\">&#9813;</div>\r\n");
#nullable restore
#line 105 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"white\"></div>\r\n");
#nullable restore
#line 110 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"

                        }
                    }
                    k++;
                }
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    <div style=\"display:inline-block; float:right\" id=\"Options\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a8fa6f3b643fee7f4e72269a5b1556b67d161fd11264", async() => {
                WriteLiteral("\r\n            <p>Select dimension: ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a8fa6f3b643fee7f4e72269a5b1556b67d161fd11556", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 122 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.dimension);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 122 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.dimensions;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a8fa6f3b643fee7f4e72269a5b1556b67d161fd13799", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 123 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.heuristic);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 123 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
                                        WriteLiteral(Model.heuristic);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a8fa6f3b643fee7f4e72269a5b1556b67d161fd16360", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 124 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.coolingFactor);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a8fa6f3b643fee7f4e72269a5b1556b67d161fd18211", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 125 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.T0);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <p><span>Heuristic: ");
#nullable restore
#line 126 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
                           Write(Model.heuristic);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n            <p><span>Counter: ");
#nullable restore
#line 127 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
                         Write(Model.counter);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n            <input type=\"submit\" value=\"Generate random state\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <br />\r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    Starting temperature\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a8fa6f3b643fee7f4e72269a5b1556b67d161fd22121", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 137 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.T0);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Cooling factor\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a8fa6f3b643fee7f4e72269a5b1556b67d161fd23850", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 145 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.coolingFactor);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <br />\r\n        <a onclick=\"SimulatedAnealing()\" class=\"btn btn-info\">Execute algorithm</a>\r\n    </div>\r\n</div>\r\n<script>\r\n    function SimulatedAnealing() {\r\n        var dim=");
#nullable restore
#line 155 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
           Write(Model.dimension);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        var Array = \"");
#nullable restore
#line 156 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
                 Write(Model.array == null ? string.Empty : string.Join("", Model.array));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 158 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
             Write(Url.Action("SimulatedAnealingAlgorithm", "SimulatedAnealing"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            method: \'POST\',\r\n            data: {\r\n                stringArray: Array,\r\n                dim:");
#nullable restore
#line 162 "C:\Users\admin\Desktop\FERI\AI\Assignment1\Assignment1\Assignment1\Views\SimulatedAnealing\Index.cshtml"
               Write(Model.dimension);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                T0: $(\"#T0ID\").val(),\r\n                coolingFactor:$(\"#coolingFactorID\").val()\r\n            },\r\n            success: function (data) {\r\n                $(\"#container\").html(data);\r\n            }\r\n        });\r\n    }\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment1.ViewModel.SimulatedAnealingVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
