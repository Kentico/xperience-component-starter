using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace MyCompany.Components
{
    /// <summary>
    /// Image widget properties.
    /// </summary>
    public class ImageWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// Image URL.
        /// </summary>
        [EditingComponent(ImageUrlWithPreviewFormComponent.IDENTIFIER, Label = "{$Widget.Image.Label$}", Order = 1)]
        public string ImageUrl { get; set; }
    }
}