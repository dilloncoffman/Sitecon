using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.Navigation
{
  public static class Templates
  {
    public static class Header
    {
      public static class Fields
      {
        public static readonly ID Logo = new ID("{7F8E9279-3207-491E-BA5C-A461267FE350}");
        public static readonly ID HomeLink = new ID("{2B86E9BD-74C3-4610-A58F-7C28A2BC2B5D}");
        public static readonly ID EventsRoot = new ID("{7945370C-B369-45A1-9E3F-1FE6A72C3B27}");
        public static readonly ID ScheduleLink = new ID("{BD81569D-57DC-4FC9-ACB1-C9761532DC3A}");
      }
    }
    public static class Footer
    {
      public static class Fields
      {
        public static readonly ID FooterTextLeft = new ID("{6AF14A2B-130A-4080-801D-D36C30BA6892}");
        public static readonly ID FooterLinkLeft = new ID("{70E3B6C6-29B3-4E7C-BF0E-730700847DED}");
        public static readonly ID FooterLinkTextLeft = new ID("{B6B55E04-46FB-4FD2-8095-AF727751A194}");
        public static readonly ID FooterTextRight = new ID("{C2787DC9-81DC-43B2-BD61-0FE0DCF9A807}");
        public static readonly ID FooterLinkRight = new ID("{DC28853A-0FAB-4DA3-85D7-0629B78E769D}");
        public static readonly ID FooterLinkTextRight = new ID("{6C25ED67-CF78-46E1-8121-B530E0D3E141}");
      }
    }
  }
}