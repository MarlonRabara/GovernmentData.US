using System;
using Reqnroll;

namespace GovernmentData.US.BDD.Tests.StepDefinitions
{
    [Binding]
    public class DisasterStepDefinitions
    {
        [Given("the property is located at (.*), (.*), (.*) (.*)")]
        public void GivenThePropertyIsLocatedAt(string streetAddress, string city, string state, int zip)
        {
            throw new PendingStepException();
        }

        [When("the property is verified for disaster inclusion")]
        public void WhenThePropertyIsVerifiedForDisasterInclusion()
        {
            throw new PendingStepException();
        }

        [Then("the property is included in the disaster data")]
        public void ThenThePropertyIsIncludedInTheDisasterData()
        {
            throw new PendingStepException();
        }
    }
}
