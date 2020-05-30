using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1
{
    [Binding]
    public class ListusersSteps
    {
        [Given(@"I have prepored  get request")]
        public void GivenIHavePreporedGetRequest()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have an array with registered user data")]
        public void GivenIHaveAnArrayWithRegisteredUserData()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press send button")]
        public void WhenIPressSendButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) ok on the screen")]
        public void ThenTheResultShouldBeOkOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
