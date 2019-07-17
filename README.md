# Kentico EMS Component Starter
[![Build status](https://ci.appveyor.com/api/projects/status/st73cvjh2vr7r0ck?svg=true)](https://ci.appveyor.com/project/kentico/ems-mvc-component-starter/branch/master)

This repository helps you to get started with development of [MVC page builder](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=page_builder_mvc) components. It contains a MVC application with sample widget, inline editor, form component, and section.

## Component development best practices
To learn about best practices and development of [MVC page builder](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=page_builder_mvc) components, visit respective page in the Kentico Documentation:
* [Widgets](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=widgets_developing_mvc)
* [Sections](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=page_builder_sections_mvc)
* [Form components](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=formbuilder_components_mvc)
* [Inline editors](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=widgets_inline_editors_mvc)
* [Personalization condition types](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=dev_personalization_conditiontype_mvc)

## Getting started

1. Download a [Kentico installer](https://www.kentico.com/download-demo/trial-version), if you do not have one already.
1. To install Kentico administration interface without any site from the [command line](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=installation_cmd):
    * Run the installer and use the [`KenticoInstallationProfile.xml`](/KenticoInstallationProfile.xml) [XML configuration](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=cmd_install_xml).
        * Specify the location where Kentico is installed by defining the `TargetFolder` attribute of the `IIS` tag. (:warning: Do not use the location where your intaller `.exe` file is located)
        * To modify the connection to a different database server, configure the `SQL` tag in the [configuration XML file](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=cmd_install_xml).
        * To add a license to the Kentico instance, adjust the `Licenses` tag in the [configuration XML file](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=cmd_install_xml).
         ```sh
         .\Kentico_12_0_trial.exe KenticoInstallationProfile.xml
         ```

    * If you get an error about already installed program files, run the following command to uninstall current Kentico program files and then run the previous command again.

      ```sh
      .\Kentico_12_0_trial.exe /u
      ```

1. Apply the latest [hotfix](https://devnet.kentico.com/download/hotfixes).

1. Open the administration interface (already registered in IIS with `_Admin` suffix) in your preferred browser and [import the site export package](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=site_objects_importing) ([`SandboxSite.zip`](/SandboxSite.zip)). The package contains:
     * Site (with configured *Presentation URL*)
     * Page type (configured with url pattern `/` and enabled *Use page tab* setting)
         * Page of this page type
     * *Web farm mode* set to *Automatic*

1. Clone this repository (MVC application) to a different folder than the Kentico administration interface

    ```sh
    git clone https://github.com/Kentico/ems-mvc-component-starter
    ```

1. Rename the [`AppSettings.config.template`](/SandboxSite/AppSettings.config.template) file to `AppSettings.config` and set the hash string salt (`CMSHashStringSalt`) to match the hash string salt in the `web.config` application settings of the Kentico administration interface.

1. Rename the [`ConnectionStrings.config.template`](/SandboxSite/ConnectionStrings.config.template) file to `ConnectionStrings.config` and set the connection string (`CMSConnectionString`) to match the connection string in the `web.config` application settings of the Kentico administration interface.

1. Open the MVC application solution in Visual Studio and build the [`MVCComponentStarter.sln`](/MVCComponentStarter.sln) solution.

1. Download and install the latest [NodeJS runtime](https://nodejs.org/en/).

1. Navigate to root of this MVC project using console and install missing npm packages:
    ```sh
    npm install
    ```
1. Start a DEV server for serving transpiled JavaScript files:
    ```sh
    npm run dev
    ```

1. In Visual Studio, press the F5 key to start the MVC application using IIS express.

1. Open the administration interface in your preferred browser.
      1. Navigate to the *Pages* application.
      1. Select page named `Home` in the content tree.

You can now see the [page builder interface](https://kentico.com/CMSPages/DocLinkMapper.ashx?version=latest&link=page_builder_mvc) set up and ready to be used.

![Starter showcase](/Starter.png)

![Analytics](https://kentico-ga-beacon.azurewebsites.net/api/UA-69014260-4/Kentico/ems-mvc-component-boilerplate?pixel)
