# Kentico EMS Component Starter
[![Build status](https://ci.appveyor.com/api/projects/status/st73cvjh2vr7r0ck?svg=true)](https://ci.appveyor.com/project/kentico/ems-mvc-component-starter)

This a starter point to develop MVC Page Builder Components. It contains one sample widget, inline editor, form component, and section.

## :warning: Disclaimer

> This repo is still in development. It is about to be released after the [Kentico 12 Service pack is released](https://www.kentico.com/product/roadmap). 

Currently it is possible to start the development, but the repository structure might change.
See the list of the [issues that need to be solved before release](https://github.com/Kentico/ems-mvc-component-boilerplate/labels/before-release).

## :warning: Repository moved to another location
> All git clone, git fetch, or git pushoperations targeting the previous location will continue to function as if made on the new location. However, to reduce confusion, we strongly recommend updating any existing local clones to point to the new repository URL. You can do this by using git remote on the command line:

```sh
$ git remote set-url origin https://github.com/Kentico/ems-mvc-component-starter.git
```
## Get started

1. **Download Kentico installation**
    * [`Kentico_12_0_trial.exe` Trial](https://www.kentico.com/download-demo/trial-version)
1. **Install Kentico** using [the command line](https://docs.kentico.com/K12SP/Installing+Kentico+from+the+command+line).
    * Use [Kentico installation profile](/KenticoInstallationProfile.xml) template and define `TargetFolder` attribute of th `IIS` tag (:warning: Do not use the same location as the one you have you exe file located)
        * This will install Kentico Administration interface without any site
        * If you wish to adjust the connection to the different database server, [adjust the `SQL` tag in the configuration](https://docs.kentico.com/K12SP/installation/installing-kentico-from-the-command-line/command-line-installation-xml-configuration)
        * If you wish to add your license to the instance, [adjust the `Licenses` tag in the configuration XML]((https://docs.kentico.com/K12SP/installation/installing-kentico-from-the-command-line/command-line-installation-xml-configuration))

      ```sh
      .\Kentico_12_0_trial.exe KenticoInstallationProfile.xml
      ```

      > If you get an error about already installed program files run command for uninstalling the current program files and then run the previous command again

      ```sh
      .\Kentico_12_0_trial.exe /u
      ```

1. **Apply the latest [hotfix](https://devnet.kentico.com/download/hotfixes)** (or at least 12.0.29)

1. Run the administration instance (already registered in IIS with `_Admin` suffix) **and import [the site export package](/DevelopmentSite.zip)** according to the ([documentation](https://docs.kentico.com/K12SP/Importing+a+site+or+objects))
    * This package contains
        * Site (With `Presentation URL`)
        * Page type (configured for page builder - url pattern `/` and use tab  checkbox)
        * Page by this page type
        * Automatic web farms

1. **Clone this repository** to the different folder than the Kentico administration is installed

    ```sh
    git clone https://github.com/Kentico/ems-mvc-component-boilerplate
    ```
1. Build the [ComponentBoilerplate.sln](/ComponentBoilerplate.sln).

1. Set the **hash string salt** (`CMSHashStringSalt`) in the [web.config](/ComponentBoilerplate/web.config) file from Kentico administration application web.config application settings.

1. Set the **the connection string** (`CMSConnectionString`) in the [web.config](/ComponentBoilerplate/web.config) file from Kentico administration application `web.config` connection strings.

1. Build the [ComponentBoilerplate.sln](/ComponentBoilerplate.sln).

1. Run command to reinstall packages (see [the issue](https://github.com/Kentico/ems-mvc-component-boilerplate/issues/1)) in Package Manager Console for the Visual Studio and confirm rewriting all the content 

    ```sh
   Update-Package -reinstall
    ```

1. Register the site in IIS (It is also possible to use IIS express)
    * use `<TargetFolder>/ComponentBoilerplate` as a `Physical path`
    * you could use the same Application pool as is set f administration application

1. Adjust **presentation URL** in the administration instance according to the registration from the previous step

1. Open the administration interface, go to Pages, select the `DevelopmentPage` and you could see the **page builder set up**.

![Boilerplate showcase](/Starter.png)

![Analytics](https://kentico-ga-beacon.azurewebsites.net/api/UA-69014260-4/Kentico/ems-mvc-component-boilerplate?pixel)

