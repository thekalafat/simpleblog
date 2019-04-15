using System.Web.Optimization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlogg.AppStart
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/admin.css")
                );

            bundles.Add(new StyleBundle("~/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/style.css")
                );
        }
    }
}