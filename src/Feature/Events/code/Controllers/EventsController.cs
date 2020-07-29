using Sitecon.Feature.Events.Models;
using Sitecon.Feature.Events.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Sitecore.Data.Items;
using Sitecore.Data.Fields;
using Sitecore.Mvc.Presentation;
using Sitecore.Diagnostics;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.Links;

namespace Sitecon.Feature.Events.Controllers
{
  public class EventsController : Controller
  {
    public ActionResult FeaturedSpeakers()
    {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      // Use Sitecore Context Item because the Homepage will inherit from the FeaturedSpeakers template
      var dataSourceId = Sitecore.Context.Item.ID.ToString();
      Assert.IsNotNullOrEmpty(dataSourceId, "dataSourceId is null or empty");
      var item = Sitecore.Context.Database.GetItem(dataSourceId);
      if (item == null)
      {
        return null;
      }

      FeaturedSpeakers featuredSpeakers = new FeaturedSpeakers();

      // Featured Speaker - DropTree Field
      ReferenceField featuredSpeakerField = item.Fields[Templates.FeaturedSpeaker.Fields.FeaturedSpeaker];
      // Get the FeaturedSpeaker Sitecore item
      Item featuredSpeakerItem = Sitecore.Context.Database.GetItem(featuredSpeakerField.TargetID);
      if (featuredSpeakerItem != null)
      {
        // Populate the FeaturedSpeaker model with values from the fields in the Speaker template in Sitecore
        Speaker featuredSpeaker = new Speaker();
        featuredSpeaker.SpeakerName = featuredSpeakerItem.Fields[Templates.Speaker.Fields.SpeakerName.ToString()].Value;
        featuredSpeaker.SpeakerTitle = featuredSpeakerItem.Fields[Templates.Speaker.Fields.SpeakerTitle.ToString()].Value;
        featuredSpeaker.SpeakerDescription = featuredSpeakerItem.Fields[Templates.Speaker.Fields.SpeakerDescription.ToString()].Value;
        LinkField featuredSpeakerTwitterLink = featuredSpeakerItem.Fields[Templates.Speaker.Fields.SpeakerTwitterUrl];
        featuredSpeaker.SpeakerTwitterUrl = featuredSpeakerTwitterLink.Url;
        LinkField featuredSpeakerLinkedInLink = featuredSpeakerItem.Fields[Templates.Speaker.Fields.SpeakerLinkedInUrl];
        featuredSpeaker.SpeakerLinkedInUrl = featuredSpeakerLinkedInLink.Url;
        LinkField featuredSpeakerWebsiteLink = featuredSpeakerItem.Fields[Templates.Speaker.Fields.SpeakerWebsiteUrl];
        featuredSpeaker.SpeakerWebsiteUrl = featuredSpeakerWebsiteLink.Url;
        featuredSpeakers.FeaturedSpeaker = featuredSpeaker;
        ImageField featuredSpeakerImage = featuredSpeakerItem.Fields[Templates.Speaker.Fields.SpeakerImage];
        featuredSpeaker.SpeakerImageUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(featuredSpeakerImage.MediaItem);
        featuredSpeaker.SpeakerImageAlt = featuredSpeakerImage.Alt;
      }

      // Featured Speakers List - TreeList Field
      // Use MultilistField type for the TreeList Field
      MultilistField featuredSpeakersListField = item.Fields[Templates.FeaturedSpeaker.Fields.FeaturedSpeakersList];
      // Create a list of Sitecore FeaturedSpeaker items
      Item[] featuredSpeakerItems = featuredSpeakersListField.GetItems();
      List<Speaker> featuredSpeakersList = new List<Speaker>();
      if (featuredSpeakerItems != null && featuredSpeakerItems.Count() > 0)
      {
        // Populate a list of Speakers by looping through each item selected in the TreeList Field and getting the field values from the Speaker template in Sitecore
        foreach (Item i in featuredSpeakerItems)
        {
          Speaker speaker = new Speaker();
          Item speakerItem = Sitecore.Context.Database.GetItem(i.ID);
          speaker.SpeakerName = speakerItem.Fields[Templates.Speaker.Fields.SpeakerName.ToString()].Value;
          speaker.SpeakerTitle = speakerItem.Fields[Templates.Speaker.Fields.SpeakerTitle.ToString()].Value;
          speaker.SpeakerDescription = speakerItem.Fields[Templates.Speaker.Fields.SpeakerDescription.ToString()].Value;
          LinkField speakerTwitterLink = speakerItem.Fields[Templates.Speaker.Fields.SpeakerTwitterUrl];
          speaker.SpeakerTwitterUrl = speakerTwitterLink.Url;
          LinkField speakerLinkedInLink = speakerItem.Fields[Templates.Speaker.Fields.SpeakerLinkedInUrl];
          speaker.SpeakerLinkedInUrl = speakerLinkedInLink.Url;
          LinkField speakerWebsiteLink = speakerItem.Fields[Templates.Speaker.Fields.SpeakerWebsiteUrl];
          speaker.SpeakerWebsiteUrl = speakerWebsiteLink.Url;
          ImageField speakerImage = speakerItem.Fields[Templates.Speaker.Fields.SpeakerImage];
          speaker.SpeakerImageUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(speakerImage.MediaItem);
          speaker.SpeakerImageAlt = speakerImage.Alt;

          featuredSpeakersList.Add(speaker);
        }
      }

      // Populate FeaturedSpeakers List
      featuredSpeakers.FeaturedSpeakersList = featuredSpeakersList;

      return View(featuredSpeakers);
    }

    public ActionResult EventSchedule()
    {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourceId = Sitecore.Context.Item.ID.ToString();
      Assert.IsNotNullOrEmpty(dataSourceId, "dataSourceId is null or empty");
      var item = Sitecore.Context.Database.GetItem(dataSourceId);
      if (item == null)
      {
        return null;
      }

      EventSchedule eventSchedule = new EventSchedule();

      // Background Image
      ImageField eventScheduleBackgroundImageField = item.Fields[Templates.EventSchedule.Fields.EventScheduleBackground];
      eventSchedule.EventScheduleBgImgUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(eventScheduleBackgroundImageField.MediaItem);

      EventHelpers helpers = new EventHelpers();

      // Multilist
      MultilistField day1EventsListField = item.Fields[Templates.EventSchedule.Fields.EventScheduleDay1Events];
      eventSchedule.EventScheduleDay1Events = helpers.PopulateEventList(day1EventsListField);

      // Date Field
      DateField day2DateField = item.Fields[Templates.EventSchedule.Fields.EventScheduleDay2Date];
      DateTime day2DateTime = day2DateField.DateTime;
      eventSchedule.EventScheduleDay2Date = day2DateTime.ToString("MMMM dd");

      // Multilist
      MultilistField day2EventsListField = item.Fields[Templates.EventSchedule.Fields.EventScheduleDay2Events];
      eventSchedule.EventScheduleDay2Events = helpers.PopulateEventList(day2EventsListField);

      return View(eventSchedule);
    }

    public ActionResult ThisMonthsEvents()

    {
      var searchList = new EventsSearch();

      var eventID = RenderingContext.CurrentOrNull.Rendering.DataSource; // Gets the id value of the datasource item 

      if (eventID != null)

      {

        var eventItem = Sitecore.Context.Database.GetItem(eventID); // Gets the datasource item using the GUID/path 

        if (eventItem != null)

        {

          // Creating a search using ContentSearch API 
          var index = ContentSearchManager.GetIndex("sitecore_master_index");

          using (var context = index.CreateSearchContext())

          {

            var mySearch = context.GetQueryable<SearchResultItem>()

                .Where(x => x["Event Name"].Contains("Search")).ToList().Select(item => item.GetItem()).ToList();

            searchList.ListOfEventItems = mySearch.Select(item => new EventItem

            {

              Item = item,

              Url = LinkManager.GetItemUrl(item),

            }).ToList();

          }
        }
      }

      return View(searchList);

    }
  }
}