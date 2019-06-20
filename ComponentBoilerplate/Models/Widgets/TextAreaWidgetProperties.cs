using Kentico.ComponentBoilerplate.Models.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace Kentico.ComponentBoilerplate.Models.Widgets
{
    public class TextAreaWidgetProperties : IWidgetProperties
    {
        [EditingComponent(LongTextCharacterCountFormComponent.IDENTIFIER, Order = 0, Label = "Content")]
        public string Content { get; set; }
    }
}