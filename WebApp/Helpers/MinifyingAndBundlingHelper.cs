using System.Reflection;
using System.Web.Mvc;

namespace WebApp.Helpers
{
	public static class MinifyingAndBundlingHelper
	{
		public static bool IsDebug(this HtmlHelper helper)
		{
#if DEBUG
			return true;
#else
			return false;
#endif
		}

		public static string GetAssemblyVersion(this HtmlHelper helper)
		{
			return Assembly.GetExecutingAssembly().GetName().Version.ToString();
		}
	}
}