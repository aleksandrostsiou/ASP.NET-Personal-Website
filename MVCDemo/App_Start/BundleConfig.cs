using System.Web;
using System.Web.Optimization;

namespace MVCDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            bundles.Add(new StyleBundle("~/template/css").Include(
                      "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/vendor/fontawesome-free/css/all.min.css",
                      "~/Content/css/grayscale.min.css"));


            bundles.Add(new ScriptBundle("~/template/js").Include(
                       "~/Scripts/js/jquery/jquery.min.js",
                       "~/Scripts/js/bootstrap.bundle.min.js",
                       "~/Scripts/js/jquery-easing/jquery.easing.min.js",
                       "~/Scripts/js/grayscale.min.js"));
        }
    }
}
