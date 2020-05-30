using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1.StepDefinitions
{
    [Binding]
    public class UserJohnSteps
    {
        [Given(@"I have invalid request")]
        public void GivenIHaveInvalidRequest()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have answer (.*) ok")]
        public void GivenIHaveAnswerOk(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be list all users with first_name contains john on the screen")]
        public void ThenTheResultShouldBeListAllUsersWithFirst_NameContainsJohnOnTheScreen()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
