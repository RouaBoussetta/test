using System.Web;
using System.Web.Optimization;

namespace Challengee
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/template/front/jquery").Include(
                    "~/assets/js/vendor/modernizr-3.5.0.min.js",
                    "~/assets/js/vendor/jquery-1.12.4.min.js",
"~/assets/js/popper.min.js",
"~/assets/js/bootstrap.min.js",
"~/assets/js/jquery.slicknav.min.js",
"~/assets/js/owl.carousel.min.js",
"~/assets/js/slick.min.js",
"~/assets/js/wow.min.js",
"~/assets/js/animated.headline.js",
"~/assets/js/jquery.magnific-popup.js",
"~/assets/js/jquery.nice-select.min.js",
"~/assets/js/jquery.sticky.js",
"~/assets/js/contact.js",
"~/assets/js/jquery.form.js",
"~/assets/js/jquery.validate.min.js",
"~/assets/js/mail-script.js",
"~/assets/js/jquery.ajaxchimp.min.js",
"~/assets/js/plugins.js",
"~/assets/js/main.js"


                    ));

            bundles.Add(new StyleBundle("~/Content/front/css").Include(


                "~/assets/css/animate.min.css",
"~/assets/css/bootstrap.min.css",
"~/assets/css/flaticon.css",
"~/assets/css/fontawesome-all.min.css",
"~/assets/css/magnific-popup.css",
"~/assets/css/main.css",
"~/assets/css/nice-select.css",


                     "~/assets/css/owl.carousel.min.css",
                     "~/assets/css/responsive.css",
                     "~/assets/css/slick.css",

                     "~/assets/css/slicknav.css",
                     "~/assets/css/style.css",
"~/assets/css/style.map",

"~/assets/css/themify-icons.css"
                  ));
        }
    }
}
