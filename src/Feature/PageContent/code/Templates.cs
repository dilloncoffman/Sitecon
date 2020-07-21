using Sitecore.Data;

namespace Sitecon.Feature.PageContent
{
  public static class Templates
  {
    public static class BodyCopy
    {
      public static class Fields
      {
        public static readonly ID BodyCopy = new ID("{3CD357B9-95BF-4F3B-8E4F-FE717732F9A1}");
      }
    }
    public static class TwoImage
    {
      public static class Fields
      {
        public static readonly ID Image1 = new ID("{DF162CB7-9DF1-455D-A6D5-FE9A05CB933C}");
        public static readonly ID Image2 = new ID("{1333AB98-25E5-4C16-B15B-C0CB992642B1}");
      }
    }
    public static class TitleAndText
    {
      public static class Fields
      {
        public static readonly ID ComponentTitle = new ID("{D3F7EF3D-D9A4-44E8-8CB2-577CC978FBBE}");
        public static readonly ID ComponentText = new ID("{B13BA8DA-0E20-4D39-BB39-D51EEA1E921B}");
      }
    }
  }
}