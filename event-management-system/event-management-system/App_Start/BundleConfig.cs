using System.Web;
using System.Web.Optimization;

namespace event_management_system
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/Hoverdrop").Include(
                      "~/Scripts/Hoverdrop.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/DropDown.css",
                      "~/Content/site.css",
                      "~/Content/ViewStyles.css"));

            bundles.Add(new StyleBundle("~/Content/Sportcss").Include(
                      "~/Content/SportsReviews.css"));

            bundles.Add(new StyleBundle("~/Content/Sport_softball").Include(
                      "~/Content/SportSoftball.css"));

            bundles.Add(new StyleBundle("~/Content/Hoverdrop").Include(
                      "~/Content/Hoverdrop.css"));

            bundles.Add(new StyleBundle("~/Content/Sport_Hockey").Include(
                      "~/Content/Sport_Hockey.css"));

            bundles.Add(new StyleBundle("~/Content/Sport_Tennis").Include(
                      "~/Content/Sport_Tennis.css"));

            bundles.Add(new StyleBundle("~/Content/Sport_Cricket").Include(
                      "~/Content/Sport_Cricket.css"));

            bundles.Add(new StyleBundle("~/Content/Sport_Baseball").Include(
                      "~/Content/Sport_Baseball.css"));
            
        }
    }
}
