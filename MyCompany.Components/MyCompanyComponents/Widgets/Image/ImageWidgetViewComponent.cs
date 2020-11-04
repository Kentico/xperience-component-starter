using Kentico.PageBuilder.Web.Mvc;

using Microsoft.AspNetCore.Mvc;
using MyCompany.Components;

[assembly: RegisterWidget(ImageWidgetViewComponent.IDENTIFIER, typeof(ImageWidgetViewComponent), "{$Widget.Image.Name$}", typeof(ImageWidgetProperties), Description = "{$Widget.Image.Description$}", IconClass = "icon-w-image-gallery")]

namespace MyCompany.Components
{
    public class ImageWidgetViewComponent : ViewComponent
    {
        public const string IDENTIFIER = "MyCompany.Widgets.Image";

        public IViewComponentResult Invoke(ComponentViewModel<ImageWidgetProperties> componentViewModel)
        {
            var viewModel = new ImageWidgetViewModel
            {
                ImageUrl = componentViewModel.Properties.ImageUrl,
            };

            return View("~/MyCompanyComponents/Widgets/Image/_ImageWidget.cshtml", viewModel);
        }
    }
}