﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.0.0.0")]
    public static class ListHelper
    {
#line hidden
#line hidden
public static System.Web.WebPages.HelperResult WriteList(this HtmlHelper helper, IEnumerable<string> list) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 1 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Helpers\ListHelper.cshtml"
                                                                     

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    <ul>\r\n");



#line 3 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Helpers\ListHelper.cshtml"
     foreach(var item in list) {

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "        <li>");



#line 4 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Helpers\ListHelper.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, item);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "</li>\r\n");



#line 5 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Helpers\ListHelper.cshtml"
    }

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    </ul>    \r\n");



#line 7 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Helpers\ListHelper.cshtml"

#line default
#line hidden

});

}


    }
}
#pragma warning restore 1591
