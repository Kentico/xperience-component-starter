using Kentico.Forms.Web.Mvc;

using MyCompany.Components;

[assembly: RegisterFormComponent(ImageUrlWithPreviewFormComponent.IDENTIFIER, typeof(ImageUrlWithPreviewFormComponent), "{$MyCompany.FormComponent.ImageUrlWithPreview.Name$}", IsAvailableInFormBuilderEditor = false, ViewName = "~/MyCompanyComponents/FormComponents/ImageUrlWithPreview/_ImageUrlWithPreview.cshtml")]

namespace MyCompany.Components
{
    /// <summary>
    /// Image URL with preview form component.
    /// </summary>
    public class ImageUrlWithPreviewFormComponent : FormComponent<ImageUrlWithPreviewProperties, string>
    {
        /// <summary>
        /// Represents the <see cref="ImageUrlWithPreviewFormComponent"/> identifier.
        /// </summary>
        public const string IDENTIFIER = "MyCompany.FormComponent.ImageUrlWithPreview";


        /// <summary>
        /// Placeholder image data URI.
        /// </summary>
        public string PlaceholderImageUri => "data:image/png;base64,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";
        

        /// <summary>
        /// Represents the input value in the resulting HTML.
        /// </summary>
        [BindableProperty]
        public string Url { get; set; }


        /// <summary>
        /// Gets the value of the form component.
        /// </summary>
        public override string GetValue()
        {
            return Url;
        }


        /// <summary>
        /// Sets the value of the form component.
        /// </summary>
        public override void SetValue(string value)
        {
            Url = value;
        }
    }
}
