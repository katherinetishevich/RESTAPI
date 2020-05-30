using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.StepDefinitions
{
    [Binding]
    public class _5ThPageResultsSteps
    {
        [Given(@"I have an array with user data on (.*)th page")]
        public void GivenIHaveAnArrayWithUserDataOnThPage(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)ok on the screen")]
        public void ThenTheResultShouldBeOkOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
