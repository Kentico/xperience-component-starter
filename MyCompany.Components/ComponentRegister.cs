using Kentico.PageBuilder.Web.Mvc;

using MyCompany.Components.Models;

[assembly: RegisterWidget("MyCompany.Widgets.Image", "{$MyCompany.Widget.Image.Name$}", typeof(ImageWidgetProperties), "~/Components/Widgets/ImageWidget/_ImageWidget.cshtml", Description = "{$MyCompany.Widget.Image.Description$}", IconClass = "icon-w-image-gallery")]

[assembly: RegisterSection("MyCompany.Section.TwoColumns", "Two columns", customViewName: "~/Components/Sections/_TwoColumnsSection.cshtml", Description = "{$MyCompany.Section.TwoColumns.Description$}", IconClass = "icon-l-cols-2")]
