using System.Web.Http;
using WebActivatorEx;
using NRP.KlientMvc;
using Swashbuckle.MVC.Handler;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
[assembly: PreApplicationStartMethod(typeof(SwaggerMVCConfig), "Register")]
namespace NRP.KlientMvc
{
    public class SwaggerMVCConfig
    {
		public static void Register()
        {
			DynamicModuleUtility.RegisterModule(typeof(SwashbuckleMVCModule));
		}
	}
}