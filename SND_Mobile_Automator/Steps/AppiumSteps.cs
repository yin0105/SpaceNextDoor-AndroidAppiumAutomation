using System.Threading;
using TechTalk.SpecFlow;

namespace SND_Mobile_Automator.Steps
{
    [Binding]
    public sealed class AppiumSteps
    {

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
           Thread.Sleep(2323);
            
        }

        [Given(@"test")]
        public void GivenTest()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"test")]
        public void WhenTest()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"test")]
        public void ThenTest()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
