using System.Web;
using System.Web.Optimization;

namespace eMining
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Content/MDB Pro/js/tether.js",
                      "~/Content/MDB Pro/js/bootstrap.js",
                      "~/Content/MDB Pro/js/mdb.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/eMining.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/MDB Pro/css/bootstrap.css",
                      "~/Content/MDB Pro/css/mdb.css",
                      "~/Content/site.css"));
        }
    }
}
