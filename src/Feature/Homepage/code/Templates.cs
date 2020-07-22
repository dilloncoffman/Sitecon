using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;
using Sitecore.Shell.Framework.Pipelines;

namespace Sitecon.Feature.Homepage
{
  public static class Templates
  {
    public static class HomepageTwoColumnCta
    {
      public static class Fields
      {
        public static readonly ID Column1Title = new ID("{8D9FEAB9-9117-4962-8C25-98A2FD48ED65}");
        public static readonly ID Column1Text = new ID("{0D51F045-87BF-446E-AE79-92BBA78BB716}");
        public static readonly ID Column1Link = new ID("{F4070FBB-946B-4F39-B619-CFA229C1EA00}");
        public static readonly ID Column1Image = new ID("{E28CE886-F404-4DF2-BC54-0D6139780ECA}");
        public static readonly ID Column2Title = new ID("{9B5825C6-A64E-4D5E-A8A1-0848132A7BE3}");
        public static readonly ID Column2Text = new ID("{E01079FA-8638-43FF-BB9E-4218E69C9312}");
        public static readonly ID Column2Link = new ID("{3B2BDE34-3667-4232-8428-979FB0F74006}");
        public static readonly ID Column2Image = new ID("{BD61F54D-F875-43BE-B3C7-50644762FAD2}");
      }
    }
  }
}