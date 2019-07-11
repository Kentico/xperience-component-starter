using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace MyCompany.Components.Models
{
    /// <summary>
    /// Image widget properties.
    /// </summary>
    public class ImageWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// Image URL.
        /// </summary>
        [EditingComponent(ImageUrlWithPreviewComponent.IDENTIFIER, Label = "{$MyCompany.Widget.Image.Label$}", Order = 1)]
        public string ImageUrl { get; set; }
    }
}