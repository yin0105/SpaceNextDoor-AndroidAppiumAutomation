using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SND_Mobile_Automator.Drivers
{
    class AppiumDriver
    {
        public AndroidDriver<AppiumWebElement> driver { get; set; }  //sdasd

        public AndroidDriver<AppiumWebElement> InitializeAppium()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "10.0");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 2");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, @"C:\Dummy\app-staging-debug.apk");
            return new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"), driverOptions);
        }

    }
}
