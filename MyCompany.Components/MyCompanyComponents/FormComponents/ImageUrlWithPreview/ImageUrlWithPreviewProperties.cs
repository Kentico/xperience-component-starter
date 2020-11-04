using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;

namespace MyCompany.Components
{
    /// <summary>
    /// Properties of the Image URL with preview form component.
    /// </summary>
    public class ImageUrlWithPreviewProperties : FormComponentProperties<string>
    {
        [DefaultValueEditingComponent(ImageUrlWithPreviewFormComponent.IDENTIFIER)]
        public override string DefaultValue { get; set; }


        public ImageUrlWithPreviewProperties()
           : base(FieldDataType.Text, 500)
        {
        }
    }
}
