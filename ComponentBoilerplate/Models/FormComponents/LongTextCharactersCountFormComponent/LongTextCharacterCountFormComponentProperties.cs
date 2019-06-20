using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;

namespace Kentico.ComponentBoilerplate.Models.FormComponents
{
    public class LongTextCharacterCountFormComponentProperties : FormComponentProperties<string>
    {
        public LongTextCharacterCountFormComponentProperties()
            : base(FieldDataType.LongText) { }

        [DefaultValueEditingComponent(LongTextCharacterCountFormComponent.IDENTIFIER)]
        public override string DefaultValue { get; set; }
    }
}