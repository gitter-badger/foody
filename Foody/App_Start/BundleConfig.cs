﻿using System.Web;
using System.Web.Optimization;

namespace Foody
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/underscore").Include("~/Scripts/underscore.js"));
            bundles.Add(new ScriptBundle("~/bundles/underscore-awesomer").Include("~/Scripts/underscore-awesomer.js"));
            bundles.Add(new ScriptBundle("~/bundles/orderCtr").Include("~/Scripts/Controller/orderCtr.js"));
            bundles.Add(new ScriptBundle("~/bundles/menuCtr").Include("~/Scripts/Controller/menuCtr.js"));
            bundles.Add(new ScriptBundle("~/bundles/appInit").Include("~/Scripts/Controller/appInit.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include("~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.validate-vsdoc.js"));

            bundles.Add(new ScriptBundle("~/bundles/uikit").Include(
            "~/Scripts/uikit.js"));
                      
            bundles.Add(new ScriptBundle("~/bundles/microsoftajax").Include(
                    "~/Scripts/MicrosoftAjax.debug.js"
                    ));
            bundles.Add(new ScriptBundle("~/bundles/microsoftmvcajax").Include(
                    "~/Scripts/MicrosoftMvcAjax.debug.js"
                    ));
            bundles.Add(new ScriptBundle("~/bundles/microsoftmvcvalidation").Include(
                    "~/Scripts/MicrosoftMvcValidation.debug.js"
                    ));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
               "~/Content/bootstrap.css",
               "~/Content/bootstrap-theme.css",
               "~/Content/uikit.css", 
               "~/Content/site.css",
               "~/Content/menu.css",
               "~/Content/font-awesome.css"
               ));
        }
    }
}