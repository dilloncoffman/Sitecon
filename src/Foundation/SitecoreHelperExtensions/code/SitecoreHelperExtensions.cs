using Sitecore.Data;
using Sitecore.Mvc.Helpers;
using System.Web;
using Sitecore.Data.Items;

namespace Sitecon.Foundation.SitecoreHelperExtensions
{
    public static class SitecoreHelperExtensions
    {
        public static HtmlString Field(this SitecoreHelper helper, ID fieldID)
        {
          return helper.Field(fieldID.ToString());
        }
        
        
        public static HtmlString Field(this SitecoreHelper helper, ID fieldID, object parameters)
        {
          return helper.Field(fieldID.ToString(), parameters);
        }

        //public static string GetFieldValue(this Item item, string fieldName)
        //{
        //  return (item[fieldName] != null) ? item[fieldName] : string.Empty;
        //}
  }
}
