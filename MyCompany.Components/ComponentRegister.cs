using Kentico.PageBuilder.Web.Mvc;

using MyCompany.Components.Models;

[assembly: RegisterWidget("MyCompany.Widgets.Image", "{$Widget.Image.Name$}", typeof(ImageWidgetProperties), "~/Components/Widgets/ImageWidget/_ImageWidget.cshtml", Description = "{$Widget.Image.Description$}", IconClass = "icon-w-image-gallery")]

[assembly: RegisterSection("MyCompany.Section.TwoColumns", "{$Section.TwoColumns.Name$}", customViewName: "~/Components/Sections/_TwoColumnsSection.cshtml", Description = "{$Section.TwoColumns.Description$}", IconClass = "icon-l-cols-2")]
