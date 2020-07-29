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
    public static class Event
    {
      public static class Fields
      {
        public static readonly ID EventName = new ID("{5C1E5C62-69CE-4340-AF5A-B8EF946BB26D}");
        public static readonly ID EventDate = new ID("{62EC08BB-215E-4563-B3C3-752D74D68A76}");
        public static readonly ID IsFeaturedEvent = new ID("{8FD19546-5085-49AD-A4B1-F131B7330428}");
        public static readonly ID EventSpeakers = new ID("{C4F0E3A0-817F-4B5E-A06F-07CEBA8ED70C}");
      }
    }

    public static class EventSchedule
    {
      public static class Fields
      {
        public static readonly ID EventScheduleBackground = new ID("{98503159-1CBA-4AA4-AE46-5E59FFAF8253}");
        public static readonly ID EventScheduleTitle = new ID("{26C4031C-BD74-4412-8D3E-1E6C4BFE105C}");
        public static readonly ID EventScheduleDay1Title = new ID("{C662C903-B710-41A6-8C19-24FC66E1A920}");
        public static readonly ID EventScheduleDay1Date = new ID("{B9E7ADE2-FC67-435D-950F-E16069659051}");
        public static readonly ID EventScheduleDay1Location = new ID("{FA8ACD7F-D0A1-4407-99ED-D62C4BC05DDD}");
        public static readonly ID EventScheduleDay1Events = new ID("{7A32E15A-37D6-44C9-B2C9-BF28132A3E7E}");
        public static readonly ID EventScheduleDay2Title = new ID("{263485DA-F34D-432A-98E7-567B14352ED5}");
        public static readonly ID EventScheduleDay2Date = new ID("{66AE03DE-CEAB-44D8-AAEC-D1A1633A8D09}");
        public static readonly ID EventScheduleDay2Location = new ID("{5584C835-8CDD-4224-8ADB-BB1602BC694D}");
        public static readonly ID EventScheduleDay2Events = new ID("{96A4621E-6A80-48FD-A74A-5B353052A8F4}");
      }
    }
  }
}