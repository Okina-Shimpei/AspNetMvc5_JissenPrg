using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewTraining.Helpers
{
    public static class MyHelper
    {
        public static IHtmlString Mailto(String address, String linktext)
        {
            return MvcHtmlString.Create(
                String.Format("<a href=\"mailto:{0}\">{1}</a>",
                HttpUtility.HtmlAttributeEncode(address),
                HttpUtility.HtmlAttributeEncode(linktext)));
        }
    }
}