# Kentico EMS Component Boilerplate

This is the boilerplate that could be used as a starter point todevelop widgets. It contains one sample widget, inline editor, form component, and section.

The [development environment](https://github.com/Kentico/ems-mvc-component-development-site) is loaded as a nuget package.

## :warning: Disclaimer

> This repo is still in development. It is about to be released with the [Kentico 12 Service pack is released](https://www.kentico.com/product/roadmap).

## Get started

1. **Download Kentico installation**
    * [`Kentico_12_0_trial.exe` Trial](https://www.kentico.com/download-demo/trial-version)
1. **Install Kentico** using [the command line](https://docs.kentico.com/K12SP/Installing+Kentico+from+the+command+line).
    * Use [Kentico installation profile](https://github.com/Simply007/ems-mvc-component-development-site/blob/master/KenticoInstallationProfile.xml) template and define `TargetFolder` attribute of th `IIS` tag (:warning: Do not use the same location as the one you have you exe file located)
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

1. Run the administration instance (already registered in IIS with `_Admin` suffix) **and import [the site export package](https://github.com/Simply007/ems-mvc-component-development-site/blob/master/DevelopmentSite.zip)** according to the ([documentation](https://docs.kentico.com/K12SP/Importing+a+site+or+objects))
    * This package contains
        * Site (With `Presentation URL`)
        * Page type (configured for page builder - url pattern `/` and use tab  checkbox)
        * Page by this page type
        * Automatic web farms

1. **Clone this repository** to the different folder than the Kentico administration is installed

    ```sh
    git clone https://github.com/Simply007/ems-mvc-component-boilerplate
    ```

1. Make a copy of [AppSettings.config.template](/ComponentBoilerplate/AppSettings.config.template) and rename it to `AppSettings.config` and insert the **hash string salt** from Kentico administration application web.config application settings.

1. Make a copy of [ConnectionStrings.config.template](/ComponentBoilerplate/ConnectionStrings.config.template) and rename it to `ConnectionStrings.config` and insert **the connection string**  from Kentico administration application web.config application settings.

1. Build the [ComponentBoilerplate.sln](/ComponentBoilerplate.sln).

1. Register the site in IIS (It is also possible to use IIS express)
    * use `<TargetFolder>/ComponentBoilerplate` as a `Physical path`
    * you could use the same Application pool as is set f administration application

1. Adjust **presentation URL** in the administration instance according to the registration from the previous step

1. Open the administration interface, go to Pages, select the `DevelopmentPage` and you could see the **page builder set up**.

![Boilerplate showcase](/Boilerplate.png)

![Analytics](https://kentico-ga-beacon.azurewebsites.net/api/UA-69014260-4/Kentico/ems-mvc-component-boilerplate?pixel)

