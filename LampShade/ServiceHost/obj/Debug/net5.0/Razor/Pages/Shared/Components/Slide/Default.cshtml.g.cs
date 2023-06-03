#pragma checksum "G:\LampShade_Project\code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2368d4bc8f52f43fa668a5377ff2d31d85c9103"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Slide.Pages_Shared_Components_Slide_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Slide/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Slide
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
#line 1 "G:\LampShade_Project\code\LampShade\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2368d4bc8f52f43fa668a5377ff2d31d85c9103", @"/Pages/Shared/Components/Slide/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49bdd27e8b016acb3c031a38b8da4d14315ca499", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Shared_Components_Slide_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_LampshadeQuery.Contracts.Slide.SlideQueryModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!--====================  hero slider area  ====================-->

<div class=""hero-slider-area section-space"">
    <div class=""container wide"">
        <div class=""row"">
            <div class=""col-lg-12"">

                <!--=======  hero slider wrapper  =======-->

                <div class=""hero-slider-wrapper"">
                    <div class=""ht-slick-slider"" data-slick-setting='{
                    ""slidesToShow"": 1,
                    ""slidesToScroll"": 1,
                    ""arrows"": true,
                    ""dots"": true,
                    ""autoplay"": true,
                    ""autoplaySpeed"": 5000,
                    ""speed"": 1000,
                    ""fade"": true,
                    ""infinite"": true,
                    ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                    ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                }' data-slick-responsive='[
                    {""breakp");
            WriteLiteral(@"oint"":1501, ""settings"": {""slidesToShow"": 1} },
                    {""breakpoint"":1199, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                    {""breakpoint"":991, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                    {""breakpoint"":767, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                    {""breakpoint"":575, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                    {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                ]'>

                        <!--=======  single slider item  =======-->
");
#nullable restore
#line 35 "G:\LampShade_Project\code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                         foreach (var slide in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-slider-item\">\r\n                                <div class=\"hero-slider-item-wrapper\">\r\n                                    <div class=\"container\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 2010, "\"", 2030, 1);
#nullable restore
#line 40 "G:\LampShade_Project\code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 2016, slide.Picture, 2016, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2031, "\"", 2054, 1);
#nullable restore
#line 40 "G:\LampShade_Project\code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 2037, slide.PictureAlt, 2037, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2055, "\"", 2082, 1);
#nullable restore
#line 40 "G:\LampShade_Project\code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 2063, slide.PictureTitle, 2063, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

                                        <div class=""row"">
                                            <div class=""col-lg-12"">
                                                <div class=""hero-slider-content hero-slider-content--left-space"">
                                                    <p class=""slider-title slider-title--big-light"">");
#nullable restore
#line 45 "G:\LampShade_Project\code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                                                               Write(slide.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <p class=\"slider-title slider-title--big-bold\">");
#nullable restore
#line 46 "G:\LampShade_Project\code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                                                              Write(slide.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <p class=\"slider-title slider-title--small\">");
#nullable restore
#line 47 "G:\LampShade_Project\code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                                                           Write(slide.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <a class=\"hero-slider-button\"");
            BeginWriteAttribute("href", " href=\"", 2762, "\"", 2780, 1);
#nullable restore
#line 48 "G:\LampShade_Project\code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 2769, slide.Link, 2769, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        ");
#nullable restore
#line 49 "G:\LampShade_Project\code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                   Write(slide.BtnText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        <i class=""ion-ios-plus-empty""></i>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 58 "G:\LampShade_Project\code\LampShade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        <!--=======  End of single slider item  =======-->

                    </div>
                </div>

                <!--=======  End of hero slider wrapper  =======-->
            </div>
        </div>
    </div>
</div>

<!--====================  End of hero slider area  ====================-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_LampshadeQuery.Contracts.Slide.SlideQueryModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591