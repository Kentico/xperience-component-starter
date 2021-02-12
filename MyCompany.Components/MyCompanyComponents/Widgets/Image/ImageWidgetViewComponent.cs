using Kentico.PageBuilder.Web.Mvc;

using Microsoft.AspNetCore.Mvc;
using MyCompany.Components;

[assembly: RegisterWidget(ImageWidgetViewComponent.IDENTIFIER, typeof(ImageWidgetViewComponent), "{$Widget.Image.Name$}", typeof(ImageWidgetProperties), Description = "{$Widget.Image.Description$}", IconClass = "icon-w-image-gallery")]

namespace MyCompany.Components
{
    /// <summary>
    /// Image widget view component.
    /// </summary>
    public class ImageWidgetViewComponent : ViewComponent
    {
        /// <summary>
        /// Identifier.
        /// </summary>
        public const string IDENTIFIER = "MyCompany.Widgets.Image";


        /// <summary>
        /// Invoke.
        /// </summary>
        /// <param name="componentViewModel">Component view model.</param>
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