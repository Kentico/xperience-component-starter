using System.Web.Mvc;

using Kentico.ComponentBoilerplate.Controllers.Sections;
using Kentico.PageBuilder.Web.Mvc;

[assembly: RegisterSection("Kentico.ComponentBoilerplate.Controllers.Sections.TwoColumnsSectionController",
    typeof(TwoColumnsSectionController),
    "Two columns section",
    Description = "Two columns defined by 50% width.",
    IconClass = "icon-l-cols-2")]

namespace Kentico.ComponentBoilerplate.Controllers.Sections
{
    public class TwoColumnsSectionController : Controller
    {
        // GET: TwoColumns
        public ActionResult Index()
        {
            return PartialView("Sections/_TwoColumnsSection");
        }
    }
}