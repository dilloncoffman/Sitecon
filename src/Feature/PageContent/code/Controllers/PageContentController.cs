using Sitecon.Feature.PageContent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecon.Feature.PageContent.Controllers
{
  public class PageContentController : Controller
  {
    // GET: Default
    public ActionResult ListWithIcons()
    {
      // Ensure current Context item is not null
      if (Sitecore.Context.Item == null)
      {
        return new EmptyResult();
      }
      // Get value of multi-line text string
      var item = Sitecore.Context.Item;
      var multiLineTextString = item.Fields[Templates.ListWithIcons.Fields.ListText].Value;
      // Iterate through to get each individual line of text
      ListWithIconsItems listWithIconsItems = new ListWithIconsItems
      {
        ListItems = new List<string>()
      };
      // Check to see if multi-line text string is null or empty
      if (string.IsNullOrEmpty(multiLineTextString))
      {
        return new EmptyResult();
      }
      // Split the multi-line text field
      string[] seperator = new string[] { "\r\n" };
      string[] lines = multiLineTextString.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
      // Iterate through the lines
      foreach (string listItem in lines)
      {
        if (!string.IsNullOrEmpty(listItem))
        {
          listWithIconsItems.ListItems.Add(listItem);
        }
      }
      // Get the value for the list icon
      listWithIconsItems.ListIcon = item.Fields[Templates.ListWithIcons.Fields.ListIcon].Value;
      // Return the view with the newly populated model
      return View(listWithIconsItems);
    }
  }
}