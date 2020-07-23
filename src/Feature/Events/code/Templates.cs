using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.Events
{
  public static class Templates
  {
    public static class Speaker
    {
      public static class Fields
      {
        public static readonly ID SpeakerName = new ID("{321DD3E3-3F17-49D7-952A-8C2237CC18F6}");
        public static readonly ID SpeakerTitle = new ID("{9415A5C1-AD59-4711-9733-99073DE43E3E}");
        public static readonly ID SpeakerImage = new ID("{B4142B70-93F1-4B9B-B8A4-457D9EBAEA2D}");
        public static readonly ID SpeakerDescription = new ID("{CC389397-3E8C-4360-A2D9-312376DEA66A}");
        public static readonly ID SpeakerTwitterUrl = new ID("{297BEE27-3F5B-4BFA-AD8E-8306C24B0126}");
        public static readonly ID SpeakerLinkedInUrl = new ID("{32D5F31E-6945-41E8-8E53-5CF08C04DA0C}");
        public static readonly ID SpeakerWebsiteUrl = new ID("{373BFD53-AEE1-49A5-B6E8-D9DAA3528B25}");
      }
    }

    public static class FeaturedSpeaker
    {
      public static class Fields
      {
        public static readonly ID FeaturedSpeakersTitle = new ID("{5BBFB14A-8D85-4FFA-A865-B871C50D32D5}");
        public static readonly ID FeaturedSpeakersText = new ID("{0A31ECF5-0307-4DE8-A3BC-01F6361900A0}");
        public static readonly ID FeaturedSpeaker = new ID("{2C97F380-555A-4F2B-A86F-41D484FD48C0}");
        public static readonly ID FeaturedSpeakersList = new ID("{7158AA0A-6018-467E-8D63-E51BEE47A9F2}");
      }
    }
  }
}