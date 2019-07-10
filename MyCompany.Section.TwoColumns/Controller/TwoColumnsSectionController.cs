using System.Web.Mvc;

using Kentico.PageBuilder.Web.Mvc;
using MyCompany.Section.TwoColumns.Controllers;

[assembly: RegisterSection("MyCompany.Section.TwoColumns", typeof(TwoColumnsSectionController), "{$MyCompany.Section.TwoColumns.Name$}", Description = "{$MyCompany.Section.TwoColumns.Description$}", IconClass = "icon-l-cols-2")]

namespace MyCompany.Section.TwoColumns.Controllers
{
    public class TwoColumnsSectionController : SectionController
    {
        // GET: TwoColumnsSection
        public ActionResult Index()
        {
            return PartialView("~/Views/Shared/Kentico/Sections/_TwoColumnsSection.cshtml");
        }
    }
}


