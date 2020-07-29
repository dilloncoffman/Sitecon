using Sitecore.Data.Items;

namespace Sitecon.Feature.Events.Models
{
  public class EventItem : Sitecore.Mvc.Presentation.RenderingModel
  {
    public Item Item { get; set; }
    public string Url { get; set; }
  }
}