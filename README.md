# Kentico Xperience Component Starter

[![Build status](https://ci.appveyor.com/api/projects/status/st73cvjh2vr7r0ck?svg=true)](https://ci.appveyor.com/project/kentico/ems-mvc-component-starter/branch/master)

This repository helps you to get started with the development of [MVC page builder](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=core_pagebuilder_root) components. It contains an ASP.NET Core application with a sample widget, inline editor, form component, and section. The application needs to be connected to an instance of the [Xperience](https://xperience.io/product) administration application to work properly.

## Component development best practices

To learn about best practices and development guidelines for [MVC page builder](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=core_pagebuilder_root) components, visit respective pages in the Xperience Documentation:
* [Widgets](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=core_pagebuilder_widgets)
* [Sections](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=core_pagebuilder_sections)
* [Form components](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=formbuilder_components_mvc)
* [Inline editors](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=core_pagebuilder_inlineeditors)
* [Personalization condition types](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=dev_personalization_conditiontype_mvc)


### Component front-end development

To provide a better front-end development experience for the components, a basic Webpack configuration with *npm*, *TypeScript*, and *less* pre-processor support has been pre-configured. The front-end source files of components are located in the `Assets` folder by default. You can configure this location in `wepback/constants.js` file, alongside with the component's entry file name.  By default, the name is `main.ts` or `main.less` for components that don't require custom javascript code, e.g. Sections.

To start with the component development, run the `npm run dev` command. Webpack then automatically searches for changes in the source files and transpiles them in the Sandbox site's `wwwroot` folder, where they're automatically detected by the [components system bundles](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=core_pagebuilder_widgets#DevelopingpagebuilderwidgetsinASP.NETCore-Addingscriptsandstylesforwidgets).

If you want to build component scripts for production use, run the `npm run build` command. This generates both minified and non-minified versions of the production scripts inside the components `Content` folder (e.g. `MyCompany.Components/Content`).

## Getting started

### Installing the Xperience administration interface

1. Download the [Xperience installer](https://xperience.io/get-started/trial), if you do not have one already.
1. To install the Xperience administration application without any site from the [command line](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=installation_cmd):
    * Run the installer and use the [`XperienceInstallationProfile.xml`](/XperienceInstallationProfile.xml) [XML configuration](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=cmd_install_xml).
        * Specify the location where Xperience is installed by defining the `TargetFolder` attribute of the `IIS` element. (warning: Do not use the location where your installer `.exe` file is located)
        * To modify the connection to a different database server, configure the `SQL` element in the [configuration XML file](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=cmd_install_xml).
        * To add a license to the Xperience instance, adjust the `Licenses` element in the [configuration XML file](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=cmd_install_xml).
         ```sh
         .\Xperience_13_0_trial.exe XperienceInstallationProfile.xml
         ```

    * If the installer notifies you that there are program files already installed in your system, run the following command to uninstall current Xperience program files and then rerun the previous installation command.

      ```sh
      .\Xperience_13_0_trial.exe /u
      ```

1. [Apply](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=upg_hotfix) the latest [hotfix](https://devnet.kentico.com/download/hotfixes).

1. Open the administration interface (already registered in IIS with `_Admin` suffix) in your preferred browser and [import the site export package](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=site_objects_importing) ([`SandboxSite.zip`](/SandboxSite.zip)). The package contains:
     * Site (with configured *Presentation URL* and routing mode set to the content tree-based)
     * Page type (with *Page builder* and *URL* features enabled)
         * A page based on this page type
     * *Web farm mode* set to *Automatic*


### Setting up the MVC application
1. Clone this repository (MVC application) to a different folder than the Xperience administration interface.

    ```sh
    git clone https://github.com/Kentico/ems-mvc-component-starter
    ```

1. Rename the [`appsettings.Development.template`](/SandboxSite/appsettings.Development.template) file to `appsettings.Development.json` and set both the connection string (`CMSConnectionString`) and the hash string salt (`CMSHashStringSalt`) to match the connection string and the hash string salt in the `web.config` application settings of the Xperience administration interface.

1. In the Visual Studio:
    * Open the [`MvcComponentStarter.sln`](/MvcComponentStarter.sln) solution.
    * Restore NuGet packages for all projects in the solution.
    * Build the solution.

1. Download and install the latest [NodeJS runtime](https://nodejs.org/en/).

1. Navigate to the root of this MVC project using console and install missing npm packages:
    ```sh
    npm install
    ```
1. Start a DEV server for serving transpiled JavaScript files:
    ```sh
    npm run dev
    ```

1. In the Visual Studio:
    * Run the SandboxSite application; Select the project and press the F5 key.

The page builder is now set up and ready to be used. To navigate to a page with the page builder:
   1. Open the administration interface in your preferred browser.
   1. Navigate to the *Pages* application.
   1. Select the page named `Home` in the content tree.

You can now see the [page builder interface](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=widgets_using_mvc) set up and ready to be used. You can [develop](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=page_builder_mvc) further components by following the links from the list at the top of the page.

![Starter showcase](/Starter.png)

![Analytics](https://kentico-ga-beacon.azurewebsites.net/api/UA-69014260-4/Kentico/ems-mvc-component-starter?pixel)
