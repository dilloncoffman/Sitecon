using Sitecon.Feature.Navigation.Models;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Data.Templates;
using Sitecore.Mvc.Presentation;
using Sitecore.Shell.Framework.Commands.Carousel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Web;
using System.Web.Mvc;

namespace Sitecon.Feature.Navigation.Controllers
{
  public class NavigationController : Controller
  {
    // GET: Default
    public ActionResult Header()
    {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
      if (string.IsNullOrEmpty(dataSourceId))
      {
        return null;
      }
      var item = Sitecore.Context.Database.GetItem(dataSourceId);
      if (item == null)
      {
        return null;
      }

      Header header = new Header();

      // Image Field
      ImageField logo = item.Fields[Templates.Header.Fields.Logo];
      if (logo != null && logo.MediaItem != null)
      {
        MediaItem image = new MediaItem(logo.MediaItem);
        header.ImageUrl = Sitecore.StringUtil.EnsurePrefix('/', Sitecore.Resources.Media.MediaManager.GetMediaUrl(image));
        header.ImageAlt = image.Alt;
      }

      // Home Link - Droplink Field
      ReferenceField homeLink = item.Fields[Templates.Header.Fields.HomeLink];
      header.HomeLinkUrl = homeLink != null
        ? Sitecore.Links.LinkManager.GetItemUrl(homeLink.TargetItem)
        : string.Empty;

      // Event Links - DropTree Field with Child Items
      ReferenceField eventsRoot = item.Fields[Templates.Header.Fields.EventsRoot];
      header.Events = new List<NavigationItem>();
      foreach (Item i in eventsRoot.TargetItem.Children)
      {
        var navigationItem = new NavigationItem();
        navigationItem.Item = i;
        navigationItem.ItemUrl = i != null
          ? Sitecore.Links.LinkManager.GetItemUrl(i)
          : string.Empty;

        header.Events.Add(navigationItem);
      }

      // Schedule Link - General Link with Anchor Tag
      LinkField scheduleLink = item.Fields[Templates.Header.Fields.ScheduleLink];
      header.ScheduleLinkUrl = scheduleLink != null
        ? string.Format("{0}#{1}", Sitecore.Links.LinkManager.GetItemUrl(scheduleLink.TargetItem), scheduleLink.Anchor)
        : string.Empty;

      return View(header);
    }
  }
}