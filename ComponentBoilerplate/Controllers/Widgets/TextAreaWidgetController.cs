using System.Web.Mvc;

using Kentico.ComponentBoilerplate.Controllers.Widgets;
using Kentico.PageBuilder.Web.Mvc;

[assembly: RegisterWidget("OndrejChrastina.Widgets.TextAreaWidget", typeof(TextAreaWidgetController), "Text Area Widget", Description = "Displays a text deined in the text area.", IconClass = "icon-l-header-text")]


namespace Kentico.ComponentBoilerplate.Controllers.Widgets
{
    public class TextAreaWidgetController : WidgetController
    {
        // GET: TextAreaWidget
        public ActionResult Index()
        {
            return PartialView("Widgets/_TextAreaWidget");
        }
    }
}