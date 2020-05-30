using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.StepDefinitions
{
    [Binding]
    public class СreateaNewUserSteps
    {
        [Given(@"I have  prepored  post request")]
        public void GivenIHavePreporedPostRequest()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have a problem with data validation")]
        public void GivenIHaveAProblemWithDataValidation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be add new user on the screen")]
        public void ThenTheResultShouldBeAddNewUserOnTheScreen()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
