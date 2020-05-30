using BoDi;
using ClassLibrary1.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ClassLibrary1
{
    [Binding]
    public sealed class Hooks1
    {
        private readonly IObjectContainer objectContainer;
        public Hooks1(IObjectContainer container)
        {
            objectContainer = container;
        }
        


        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            var client = userJohn();
            objectContainer.RegisterFactoryAs<UserJohn>(client);



            //TODO: implement logic that has to run before executing each scenario
        }

        private object userJohn()
        {
            throw new NotImplementedException();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
