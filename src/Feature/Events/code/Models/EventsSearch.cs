using Sitecore.ContentSearch;
using System.Collections.Generic;
using System.Linq;

namespace Sitecon.Feature.Events.Models
{
  public class EventsSearch : Sitecore.Mvc.Presentation.RenderingModel
  {
    public SitecoreIndexableItem ParentItem { get; set; }
    public IEnumerable<EventItem> ListOfEventItems { get; set; } =
    Enumerable.Empty<EventItem>();
  }
}