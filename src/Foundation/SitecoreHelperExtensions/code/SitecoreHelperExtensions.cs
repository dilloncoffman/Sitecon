using Sitecore.Data;
using Sitecore.Mvc.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Foundation.SitecoreHelperExtensions
{
    public static class SitecoreHelperExtensions
    {
        public static HtmlString Field(this SitecoreHelper helper, ID fieldID)
        {
          return helper.Field(fieldID.ToString());
        }
    }
}
