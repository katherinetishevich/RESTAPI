using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.StepDefinitions
{
    [Binding]
    public class IdUser123Steps
    {
        [Given(@"I requested a resource that does not exist")]
        public void GivenIRequestedAResourceThatDoesNotExist()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have (.*) answer")]
        public void GivenIHaveAnswer(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)ok  and array with user (.*)  on the screen")]
        public void ThenTheResultShouldBeOkAndArrayWithUserOnTheScreen(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
