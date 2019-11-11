using System.Web.Mvc;

using Kentico.PageBuilder.Web.Mvc;
using MyCompany.Components.Controllers;

[assembly: RegisterSection("MyCompany.Section.TwoColumns", typeof(MyCompanyTwoColumnsSectionController), "{$MyCompany.Section.TwoColumns.Name$}", Description = "{$MyCompany.Section.TwoColumns.Description$}", IconClass = "icon-l-cols-2")]

namespace MyCompany.Components.Controllers
{
    /// <summary>
    /// Controller for the two-column section.
    /// </summary>
    public class MyCompanyTwoColumnsSectionController : SectionController
    {
        public ActionResult Index()
        {
            return PartialView("~/Views/Shared/MyCompany/Sections/_TwoColumnsSection.cshtml");
        }
    }
}
