using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewTraining.Helpers
{
    public static class MyHelper
    {
        //public static IHtmlString Mailto(String address, String linktext)
        public static IHtmlString Mailto(this HtmlHelper helper, String address, String linktext)
        {
            var builder = new TagBuilder("a");
            builder.MergeAttribute("href", HttpUtility.HtmlAttributeEncode(String.Format("mailto:{0}", address)));
            builder.SetInnerText(HttpUtility.HtmlAttributeEncode(linktext));
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.Normal));
            //return MvcHtmlString.Create(
            //    String.Format("<a href=\"mailto:{0}\">{1}</a>",
            //    HttpUtility.HtmlAttributeEncode(address),
            //    HttpUtility.HtmlAttributeEncode(linktext)));
        }
        public static IHtmlString Image(this HtmlHelper helper, String src, String alt)
        {
            return MvcHtmlString.Create(String.Format("<img src=\"{0}\" alt=\"{1}\" />",
                HttpUtility.HtmlAttributeEncode(UrlHelper.GenerateContentUrl(src, helper.ViewContext.HttpContext)),
                HttpUtility.HtmlAttributeEncode(alt)));
        }
    }
}