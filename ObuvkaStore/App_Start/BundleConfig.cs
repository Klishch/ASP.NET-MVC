using System.Web;
using System.Web.Optimization;

namespace ObuvkaStore
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/Scripts/jquery.min.js",
                         "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-{version}.js",
                        "~/Scripts/easing.js",
                         "~/Scripts/megamenu.js",
                         "~/Scripts/move-top.js",
                         "~/Scripts/owl.carousel.js",
                         "~/Scripts/simpleCart.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/style.css",
                      "~/Content/bootstrap.css",
                      "~/Content/etalage.css",
                      "~/Content/megamenu.css",
                      "~/Content/owl.carousel.css"));


            BundleTable.EnableOptimizations = true;
        }
    }
}
