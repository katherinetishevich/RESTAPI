using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.StepDefinitions
{
    [Binding]
    public class IdUser123UpdateSteps
    {
        [Given(@"I have requested a resource that does not exist")]
        public void GivenIHaveRequestedAResourceThatDoesNotExist()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have (.*) answer")]
        public void GivenIHaveAnswer(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)ok and update array with user (.*) on the screen")]
        public void ThenTheResultShouldBeOkAndUpdateArrayWithUserOnTheScreen(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
