using Kentico.ComponentBoilerplate.Models.FormComponents;
using Kentico.Forms.Web.Mvc;

[assembly: RegisterFormComponent(LongTextCharacterCountFormComponent.IDENTIFIER, typeof(LongTextCharacterCountFormComponent), "Text Area characters count", Description = "Text area counting characters", IconClass = "icon-l-text", ViewName = "FormComponents/_LongTextCharacterCountFormComponent")]


namespace Kentico.ComponentBoilerplate.Models.FormComponents
{
    public class LongTextCharacterCountFormComponent : FormComponent<LongTextCharacterCountFormComponentProperties, string>
    {
        public const string IDENTIFIER = "Kentico.ComponentBoilerplate.TextAreaCharacterCount";

        [BindableProperty]
        public string Value { get; set; }

        public override string GetValue()
        {
            return Value;
        }

        public override void SetValue(string value)
        {
            Value = value;
        }
    }
}