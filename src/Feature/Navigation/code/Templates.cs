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
  }
}