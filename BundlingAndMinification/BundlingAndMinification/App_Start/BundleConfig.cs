using System.Web;
using System.Web.Optimization;

namespace BundlingAndMinification
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Add your own custom bundles.
            // This code creates a new bundle named "~/Scripts/App/MyScripts".
            // The name of the bundle should include the right path to the unbundled files so 
            // that any relative paths will be resolved correctly. By using the bundle name ~/Scripts/App 
            // the right relative path is preserved (the MyScripts part of the name is made up).

            bundles.Add(new ScriptBundle("~/Scripts/App/MyScripts") // MyScripts is a made-up name...its acts as a placeholder.
                .Include("~/Scripts/App/ScriptA.js")
                .Include("~/Scripts/App/ScriptB.js")
                );
            
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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
