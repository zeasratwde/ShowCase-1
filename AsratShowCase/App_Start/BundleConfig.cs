using System.Web;
using System.Web.Optimization;

namespace AsratShowCase
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
           bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css", "~/Content/zocial.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/Angular").Include(
            "~/Scripts/angular.js","~/Scripts/angular-resource.js"));


            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                      "~/Scripts/App/appScript.js"));


            bundles.Add(new ScriptBundle("~/bundles/AngularApp").Include(
            "~/Scripts/App/Controllers/stateListControllers.js",
                      "~/Scripts/App/Controllers/stateData.js", "~/Scripts/App/Filters/customFilters.js"));

        }
    }
}
