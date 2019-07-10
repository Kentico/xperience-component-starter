using System.Web.Mvc;

using Kentico.PageBuilder.Web.Mvc;

using MyCompany.Widget.Image.Controllers;
using MyCompany.Widget.Image.Models;

[assembly: RegisterWidget("MyCompany.Widgets.Image", typeof(ImageWidgetController), "{$MyCompany.Widget.Image.Name$}", Description = "{$MyCompany.Widget.Image.Description$}", IconClass = "icon-w-image-gallery")]

namespace MyCompany.Widget.Image.Controllers
{
    /// <summary>
    /// Controller for image widgets.
    /// </summary>
    public class ImageWidgetController : WidgetController<ImageWidgetProperties>
    {
        // GET: ImageWidget
        public ActionResult Index()
        {
            var properties = GetProperties();
            var viewModel = new ImageWidgetViewModel
            {
                ImageUrl = properties.ImageUrl,
            };

            return View("~/Views/Shared/Kentico/Widgets/_ImageWidget.cshtml", viewModel);
        }
    }
}