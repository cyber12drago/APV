using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Apv
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();            
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Njk5Nzc4QDMxMzgyZTM0MmUzMFZYbmdabUFjYTFrWjFwd1NhaHlxaGVVbjRXN0dmSnVidm5SU05BRmxZNWc9");
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


        }

        //void Application_Start(object sender, EventArgs e)
        //{
        //    Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBPh8sVXJ0S0R+XE9HcFRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS3xTfkRrWX9ec3ZRQGJVVQ==");
        //    RouteConfig.RegisterRoutes(RouteTable.Routes);
        //    BundleConfig.RegisterBundles(BundleTable.Bundles);
        //}
    }
}
