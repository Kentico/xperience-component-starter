using System.Web.Mvc;

using Kentico.ComponentBoilerplate.Controllers.Widgets;
using Kentico.ComponentBoilerplate.Models.Widgets;
using Kentico.PageBuilder.Web.Mvc;

[assembly: RegisterWidget("Kentico.ComponentBoilerplate.Controllers.Widgets.TextAreaWidget", 
    typeof(TextAreaWidgetController), 
    "Text Area Widget",
    Description = "Displays a text deined in the text area.",
    IconClass = "icon-l-header-text")]


namespace Kentico.ComponentBoilerplate.Controllers.Widgets
{
    public class TextAreaWidgetController : WidgetController<TextAreaWidgetProperties>
    {
        // GET: TextAreaWidget
        public ActionResult Index()
        {
            var properies = GetProperties();
            return PartialView("Widgets/_TextAreaWidget", properies.Content);
        }
    }
}