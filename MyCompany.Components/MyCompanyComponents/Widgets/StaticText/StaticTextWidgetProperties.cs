using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace MyCompany.Components
{
    /// <summary>
    /// Static text widget properties.
    /// </summary>
    public class StaticTextWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// Text property.
        /// </summary>
        [EditingComponent(TextAreaComponent.IDENTIFIER, Label = "{$Widget.StaticText.Label$}")]
        public string Text { get; set; }
    }
}
