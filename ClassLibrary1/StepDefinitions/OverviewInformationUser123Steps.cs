using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.StepDefinitions
{
    [Binding]
    public class OverviewInformationUser123Steps
    {
        [Given(@"I have empty request body field")]
        public void GivenIHaveEmptyRequestBodyField()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have empty server response")]
        public void GivenIHaveEmptyServerResponse()
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
