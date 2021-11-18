using OpenQA.Selenium.Appium;
using SND_Mobile_Automator.Drivers;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SND_Mobile_Automator.Hooks
{
    [Binding]
   public  class Hook
    {

        private readonly ScenarioContext _scenarioContext;

        public Hook(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }


        [BeforeScenario]
        public void Initialize()
        {
            AppiumDriver appiumDriver = new AppiumDriver();
            appiumDriver.InitializeAppium();
        }

    }
}
