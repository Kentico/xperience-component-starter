using System.Linq;
using System.Web.Mvc;

using CMS.DocumentEngine;

using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;

namespace Kentico.AspNet.Mvc.SandboxSite
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TreeNode page = DocumentHelper
                .GetDocuments()
                .Path("/Home")
                .OnCurrentSite()
                .TopN(1)
                .FirstOrDefault();

            if (page == null)
            {
                return HttpNotFound();
            }

            HttpContext
                .Kentico()
                .PageBuilder()
                .Initialize(page.DocumentID);

            return View();
        }
    }
}