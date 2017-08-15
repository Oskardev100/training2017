using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyProducts.AdminSite
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString Image(
            this HtmlHelper htmlHelper,
              string src,
              string altText,
              object htmlAttributes = null)
        {
            return HtmlExtensionsImage.Image(htmlHelper, src, altText, string.Empty, string.Empty, htmlAttributes);
        }
    }
}