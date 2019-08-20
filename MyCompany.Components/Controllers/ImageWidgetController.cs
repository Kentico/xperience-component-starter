using System.Web.Mvc;

using Kentico.PageBuilder.Web.Mvc;

using MyCompany.Components.Controllers;
using MyCompany.Components.Models;

[assembly: RegisterWidget("MyCompany.Widgets.Image", typeof(ImageWidgetController), "{$MyCompany.Widget.Image.Name$}", Description = "{$MyCompany.Widget.Image.Description$}", IconClass = "icon-w-image-gallery")]

namespace MyCompany.Components.Controllers
{
    /// <summary>
    /// Controller for the image widget.
    /// </summary>
    public class ImageWidgetController : WidgetController<ImageWidgetProperties>
    {
        public ActionResult Index()
        {
            var properties = GetProperties();
            var viewModel = new ImageWidgetViewModel
            {
                ImageUrl = properties.ImageUrl,
            };

            return PartialView("~/Views/Shared/MyCompany/Widgets/_ImageWidget.cshtml", viewModel);
        }
    }
}
