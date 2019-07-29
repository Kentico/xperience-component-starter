# Kentico EMS Component Starter
[![Build status](https://ci.appveyor.com/api/projects/status/st73cvjh2vr7r0ck?svg=true)](https://ci.appveyor.com/project/kentico/ems-mvc-component-starter/branch/master)

This repository helps you to get started with the development of [MVC page builder](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=page_builder_mvc) components. It contains an MVC application with a sample widget, inline editor, form component, and section. The MVC application needs to be connected to an instance of the [Kentico](https://www.kentico.com/product/overview) administration application to work properly.

## Component development best practices
To learn about best practices and development guidelines for [MVC page builder](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=page_builder_mvc) components, visit respective pages in the Kentico Documentation:
* [Widgets](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=widgets_developing_mvc)
* [Sections](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=page_builder_sections_mvc)
* [Form components](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=formbuilder_components_mvc)
* [Inline editors](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=widgets_inline_editors_mvc)
* [Personalization condition types](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=dev_personalization_conditiontype_mvc)

## Getting started

### Installing the Kentico administration interface
1. Download the [Kentico installer](https://www.kentico.com/download-demo/trial-version), if you do not have one already.
1. To install the Kentico administration application without any site from the [command line](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=installation_cmd):
    * Run the installer and use the [`KenticoInstallationProfile.xml`](/KenticoInstallationProfile.xml) [XML configuration](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=cmd_install_xml).
        * Specify the location where Kentico is installed by defining the `TargetFolder` attribute of the `IIS` element. (:warning: Do not use the location where your installer `.exe` file is located)
        * To modify the connection to a different database server, configure the `SQL` element in the [configuration XML file](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=cmd_install_xml).
        * To add a license to the Kentico instance, adjust the `Licenses` element in the [configuration XML file](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=cmd_install_xml).
         ```sh
         .\Kentico_12_0_trial.exe KenticoInstallationProfile.xml
         ```

    * If the installer notifies you that there are program files already installed in your system, run the following command to uninstall current Kentico program files and then rerun the previous installation command.

      ```sh
      .\Kentico_12_0_trial.exe /u
      ```

1. [Apply](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=upg_hotfix) the latest [hotfix](https://devnet.kentico.com/download/hotfixes).

1. Open the administration interface (already registered in IIS with `_Admin` suffix) in your preferred browser and [import the site export package](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=site_objects_importing) ([`SandboxSite.zip`](/SandboxSite.zip)). The package contains:
     * Site (with configured *Presentation URL*)
     * Page type (configured with the [url pattern](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=content_pages_url) `/` and the *Use page tab* setting enabled)
         * A page based on this page type
     * *Web farm mode* set to *Automatic*

### Setting up the MVC application
1. Clone this repository (MVC application) to a different folder than the Kentico administration interface.

    ```sh
    git clone https://github.com/Kentico/ems-mvc-component-starter
    ```

1. Rename the [`AppSettings.config.template`](/SandboxSite/AppSettings.config.template) file to `AppSettings.config` and set the hash string salt (`CMSHashStringSalt`) to match the hash string salt in the `web.config` application settings of the Kentico administration interface.

1. Rename the [`ConnectionStrings.config.template`](/SandboxSite/ConnectionStrings.config.template) file to `ConnectionStrings.config` and set the connection string (`CMSConnectionString`) to match the connection string in the `web.config` application settings of the Kentico administration interface.

1. Open the MVC application solution in Visual Studio and build the [`MvcComponentStarter.sln`](/MvcComponentStarter.sln) solution.

1. Download and install the latest [NodeJS runtime](https://nodejs.org/en/).

1. Navigate to the root of this MVC project using console and install missing npm packages:
    ```sh
    npm install
    ```
1. Start a DEV server for serving transpiled JavaScript files:
    ```sh
    npm run dev
    ```

1. Visual Studio
    * Restore NuGet packages for all the projects in the solution.
    * Run the SandboxSite project by selecting the project and pressing the F5 key.
        * Note: If you receive an error from the Roslyn compiler, to fix the error reopen the Visual Studio. This error occurs when the solution is compiled before its NuGet packages are restored.

The page builder is now set up and ready to be used. To navigate to a page with the page builder:
   1. Open the administration interface in your preferred browser.
   1. Navigate to the *Pages* application.
   1. Select the page named `Home` in the content tree.

You can now see the [page builder interface](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=widgets_using_mvc) set up and ready to be used. You can [develop](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=page_builder_mvc) further components by following the links from the list at the top of the page.

![Starter showcase](/Starter.png)

![Analytics](https://kentico-ga-beacon.azurewebsites.net/api/UA-69014260-4/Kentico/ems-mvc-component-starter?pixel)
