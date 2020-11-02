using Kentico.PageBuilder.Web.Mvc;

using MyCompany.Components;

[assembly: RegisterWidget("MyCompany.Widget.StaticText", "{$Widget.StaticText.Name$}", typeof(StaticTextWidgetProperties), customViewName: "~/Components/Widgets/StaticTextWidget/_StaticTextWidget.cshtml", Description = "{$Widget.StaticText.Description$}", IconClass = "icon-w-static-text")]

[assembly: RegisterSection("MyCompany.Section.TwoColumns", "{$Section.TwoColumns.Name$}", customViewName: "~/Components/Sections/_TwoColumnsSection.cshtml", Description = "{$Section.TwoColumns.Description$}", IconClass = "icon-l-cols-2")]
