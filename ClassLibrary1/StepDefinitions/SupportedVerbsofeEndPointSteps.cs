using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.StepDefinitions
{
    [Binding]
    public class SupportedVerbsofeEndPointSteps
    {
        [Given(@"I have prepored  optoins request")]
        public void GivenIHavePreporedOptoinsRequest()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have answer (.*)ok")]
        public void GivenIHaveAnswerOk(int p0)
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
