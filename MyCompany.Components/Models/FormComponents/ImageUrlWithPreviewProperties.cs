using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;

namespace MyCompany.Components.Models
{
    /// <summary>
    /// Properties of the Image URL with preview form component.
    /// </summary>
    public class ImageUrlWithPreviewProperties : FormComponentProperties<string>
    {
        [DefaultValueEditingComponent(ImageUrlWithPreviewComponent.IDENTIFIER)]
        public override string DefaultValue { get; set; }


        public ImageUrlWithPreviewProperties()
           : base(FieldDataType.Text, 500)
        {
        }
    }
}
