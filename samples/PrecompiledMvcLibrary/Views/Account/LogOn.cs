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

namespace PrecompiledMvcLibrary.Views.Account
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/LogOn.cshtml")]
    public class LogOn : System.Web.Mvc.WebViewPage<MvcSample.Models.LogOnModel>
    {
        public LogOn()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n");


            
            #line 3 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
  
    ViewBag.Title = "Log On";


            
            #line default
            #line hidden
WriteLiteral("\r\n<h2>Log On</h2>\r\n<p>\r\n    Please enter your username and password. ");


            
            #line 9 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
                                        Write(Html.ActionLink("Register", "Register"));

            
            #line default
            #line hidden
WriteLiteral(" if you don\'t have an account.\r\n</p>\r\n\r\n<script src=\"");


            
            #line 12 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
        Write(Url.Content("~/Scripts/jquery.validate.min.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n<script src=\"");


            
            #line 13 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
        Write(Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n\r\n");


            
            #line 15 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
Write(Html.ValidationSummary(true, "Login was unsuccessful. Please correct the errors and try again."));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");


            
            #line 17 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
 using (Html.BeginForm()) {

            
            #line default
            #line hidden
WriteLiteral("    <div>\r\n        <fieldset>\r\n            <legend>Account Information</legend>\r\n" +
"\r\n            <div class=\"editor-label\">\r\n                ");


            
            #line 23 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
           Write(Html.LabelFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");


            
            #line 26 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
           Write(Html.TextBoxFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                ");


            
            #line 27 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
           Write(Html.ValidationMessageFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"editor-label\">\r\n                ");


            
            #line 31 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
           Write(Html.LabelFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");


            
            #line 34 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
           Write(Html.PasswordFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n                ");


            
            #line 35 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
           Write(Html.ValidationMessageFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"editor-label\">\r\n                ");


            
            #line 39 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
           Write(Html.CheckBoxFor(m => m.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\r\n                ");


            
            #line 40 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
           Write(Html.LabelFor(m => m.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n            <p>\r\n                <input type=\"submit\" val" +
"ue=\"Log On\" />\r\n            </p>\r\n        </fieldset>\r\n    </div>\r\n");


            
            #line 48 "D:\forks\razorsinglefilegenerator\samples\PrecompiledMvcLibrary\Views\Account\LogOn.cshtml"
}

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
