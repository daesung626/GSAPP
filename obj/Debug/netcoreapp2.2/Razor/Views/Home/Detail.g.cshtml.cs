#pragma checksum "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e89e76c0db1cee6ec9ff14c01edcba0df09aad3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/_ViewImports.cshtml"
using GSAPP;

#line default
#line hidden
#line 2 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/_ViewImports.cshtml"
using GSAPP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e89e76c0db1cee6ec9ff14c01edcba0df09aad3", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6807f5d6857cfcc6ec5dc4e04d708a3319deaa2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Queries.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("request-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("standout-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompleteReq", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("orange"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HelperDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Dashboard", async() => {
                BeginContext(32, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(37, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e89e76c0db1cee6ec9ff14c01edcba0df09aad37969", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(87, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(92, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e89e76c0db1cee6ec9ff14c01edcba0df09aad39279", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(140, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(143, 373, true);
            WriteLiteral(@"

<script src=""https://api.mapbox.com/mapbox-gl-js/v1.9.0/mapbox-gl.js""></script>
<link href=""https://api.mapbox.com/mapbox-gl-js/v1.9.0/mapbox-gl.css"" rel=""stylesheet"" />

<header id=""Details-header"">
    <div class=""wrapper nav"">
        <div class=""logo"" data-aos=""fade-down"">
            <h1>Details</h1>
        </div>
        <div class=""nav-links"">
            <ul>
");
            EndContext();
            BeginContext(641, 41, true);
            WriteLiteral("                <li>\n                    ");
            EndContext();
            BeginContext(682, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e89e76c0db1cee6ec9ff14c01edcba0df09aad311235", async() => {
                BeginContext(768, 9, true);
                WriteLiteral("Dashboard");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(781, 192, true);
            WriteLiteral("\n                </li>\n            </ul>\n        </div>\n    </div>\n</header>\n\n<section id=\"detail-main\" class=\"wrapper\">\n    <div class=\"leftCol\">\n        <div class=\"person-info-container\">\n\n");
            EndContext();
            BeginContext(1102, 90, true);
            WriteLiteral("            <div class=\"person-info-text\">\n            <p><span class=\"bold\">Name: </span>");
            EndContext();
            BeginContext(1193, 15, false);
#line 38 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                          Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1208, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1210, 14, false);
#line 38 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                                           Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1224, 55, true);
            WriteLiteral("</p>\n            <p><span class=\"bold\">Email: </span><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1279, "\"", 1305, 2);
            WriteAttributeValue("", 1286, "mailto:", 1286, 7, true);
#line 39 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
WriteAttributeValue("", 1293, Model.Email, 1293, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1306, 16, true);
            WriteLiteral(" class=\"orange\">");
            EndContext();
            BeginContext(1323, 11, false);
#line 39 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                                                                        Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1334, 59, true);
            WriteLiteral("</a></p>\n            <p><span class=\"bold\">Phone: </span><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1393, "\"", 1422, 2);
            WriteAttributeValue("", 1400, "tel:", 1400, 4, true);
#line 40 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
WriteAttributeValue("", 1404, Model.PhoneNumber, 1404, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1423, 16, true);
            WriteLiteral(" class=\"orange\">");
            EndContext();
            BeginContext(1440, 17, false);
#line 40 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                                                                           Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1457, 60, true);
            WriteLiteral("</a></p>\n            <p><span class=\"bold\">Venmo ID: </span>");
            EndContext();
            BeginContext(1518, 13, false);
#line 41 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                              Write(Model.VenmoId);

#line default
#line hidden
            EndContext();
            BeginContext(1531, 55, true);
            WriteLiteral("</p>\n            <p><span class=\"bold\">Zipcode: </span>");
            EndContext();
            BeginContext(1587, 13, false);
#line 42 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                             Write(Model.ZipCode);

#line default
#line hidden
            EndContext();
            BeginContext(1600, 335, true);
            WriteLiteral(@"</p>
            </div>

        </div>
        <div id=""map""></div>
    </div>

    <div id=""detail-content"" class=""rightCol"">

        <div class=""request-container"">
            <div class=""backToTop"">
                <h4>Open Requests</h4>
                <a href=""#Details-header"" class=""toTop"">Back to top</a>
            </div>
");
            EndContext();
#line 56 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
             foreach (var req in @Model.RequestsCreated)
            {
                

#line default
#line hidden
#line 58 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                 if (@req.IsCompleted == false)
                {

#line default
#line hidden
            BeginContext(2072, 91, true);
            WriteLiteral("                    <div>\n                        <p><span class=\"bold\">Needed by: </span> ");
            EndContext();
            BeginContext(2164, 43, false);
#line 61 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                                            Write(req.Urgency.ToString("MM/dd/yyyy hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(2207, 66, true);
            WriteLiteral("</p>\n                        <p><span class=\"bold\">Items: </span> ");
            EndContext();
            BeginContext(2274, 9, false);
#line 62 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                                        Write(req.Items);

#line default
#line hidden
            EndContext();
            BeginContext(2283, 65, true);
            WriteLiteral("</p>\n                        <p><span class=\"bold\">Notes: </span>");
            EndContext();
            BeginContext(2349, 9, false);
#line 63 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                                       Write(req.Notes);

#line default
#line hidden
            EndContext();
            BeginContext(2358, 58, true);
            WriteLiteral("</p>\n                    </div>\n                    <div>\n");
            EndContext();
#line 66 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                         if(req.Creator.UserId != @ViewBag.UserId)
                        {

#line default
#line hidden
            BeginContext(2509, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2533, 224, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e89e76c0db1cee6ec9ff14c01edcba0df09aad319296", async() => {
                BeginContext(2633, 117, true);
                WriteLiteral("\n                            <input type=\"submit\" class=\"accept-btn\" value=\"Accept Request\">\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-reqId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                                            WriteLiteral(req.RequestId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["reqId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-reqId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["reqId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2757, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 71 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                        }
                        else if (req.Creator.UserId == @ViewBag.UserId)
                        {

#line default
#line hidden
            BeginContext(2882, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(2910, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e89e76c0db1cee6ec9ff14c01edcba0df09aad322777", async() => {
                BeginContext(2989, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-requestId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                                                               WriteLiteral(req.RequestId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["requestId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-requestId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["requestId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2999, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 75 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                        }

#line default
#line hidden
            BeginContext(3026, 27, true);
            WriteLiteral("                    </div>\n");
            EndContext();
#line 77 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                }

#line default
#line hidden
#line 77 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(3085, 229, true);
            WriteLiteral("        </div>\n\n        <div class=\"completed-container\">\n            <div class=\"backToTop\">\n                <h4>Completed Requests</h4>\n                <a href=\"#Details-header\" class=\"toTop\">Back to top</a>\n            </div>\n");
            EndContext();
#line 86 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
             foreach (var creq in @Model.RequestsCreated)
            {
                

#line default
#line hidden
#line 88 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                 if (creq.IsCompleted ==true)
                {

#line default
#line hidden
            BeginContext(3450, 115, true);
            WriteLiteral("                    <div class=\"completed-panel\">\n                        <p><span class=\"bold\">Needed by: </span> ");
            EndContext();
            BeginContext(3566, 44, false);
#line 91 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                                            Write(creq.Urgency.ToString("MM/dd/yyyy hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(3610, 66, true);
            WriteLiteral("</p>\n                        <p><span class=\"bold\">Items: </span> ");
            EndContext();
            BeginContext(3677, 10, false);
#line 92 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                                        Write(creq.Items);

#line default
#line hidden
            EndContext();
            BeginContext(3687, 65, true);
            WriteLiteral("</p>\n                        <p><span class=\"bold\">Notes: </span>");
            EndContext();
            BeginContext(3753, 10, false);
#line 93 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                                       Write(creq.Notes);

#line default
#line hidden
            EndContext();
            BeginContext(3763, 160, true);
            WriteLiteral("</p>\n                        <p>\n                            <span class=\"bold\">\n                                Completed by: \n                                ");
            EndContext();
            BeginContext(3923, 156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e89e76c0db1cee6ec9ff14c01edcba0df09aad328128", async() => {
                BeginContext(4016, 29, false);
#line 97 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                                                                                                       Write(ViewBag.CompletedBy.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(4045, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(4047, 28, false);
#line 97 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                                                                                                                                      Write(ViewBag.CompletedBy.LastName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-UserId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                                                                                   WriteLiteral(ViewBag.CompletedBy.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4079, 93, true);
            WriteLiteral("\n                            </span>\n                        </p>\n                    </div>\n");
            EndContext();
#line 101 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                }

#line default
#line hidden
#line 101 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(4204, 135, true);
            WriteLiteral("        </div>\n\n    </div>\n</section>\n\n<script src=\"https://unpkg.com/es6-promise@4.2.4/dist/es6-promise.auto.min.js\"></script>\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4339, "\"", 4404, 3);
            WriteAttributeValue("", 4345, "https://unpkg.com/", 4345, 18, true);
            WriteAttributeValue("", 4363, "@", 4363, 1, true);
            WriteAttributeValue("", 4365, "mapbox/mapbox-sdk/umd/mapbox-sdk.min.js", 4365, 39, true);
            EndWriteAttribute();
            BeginContext(4405, 295, true);
            WriteLiteral(@"></script>
<script>
    mapboxgl.accessToken = 'pk.eyJ1IjoiZGFlc3VuZ2Nob2k2MjYiLCJhIjoiY2s4a3RjMDkwMDVpbjNpbnd5ZDdoamk5cCJ9.yx1ofJFjnAGsdngQi9EsuA';
    var mapboxClient = mapboxSdk({ accessToken: mapboxgl.accessToken });
    mapboxClient.geocoding
        .forwardGeocode({
            query: '");
            EndContext();
            BeginContext(4701, 13, false);
#line 115 "/Users/rolandolopantzi/Documents/GitHub/gsappfinal/Views/Home/Detail.cshtml"
               Write(Model.ZipCode);

#line default
#line hidden
            EndContext();
            BeginContext(4714, 778, true);
            WriteLiteral(@"',
            autocomplete: false,
            limit: 1
        })
        .send()
        .then(function (response) {
            if (
                response &&
                response.body &&
                response.body.features &&
                response.body.features.length
            ) {
                var feature = response.body.features[0];

                var map = new mapboxgl.Map({
                    container: 'map',
                    style: 'mapbox://styles/mapbox/streets-v11',
                    center: feature.center,
                    zoom: 15
                });
                new mapboxgl.Marker().setLngLat(feature.center).addTo(map);
                map.addControl(new mapboxgl.NavigationControl());
            }
        });
</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
