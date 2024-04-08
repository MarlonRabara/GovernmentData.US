using System;
using BoDi;
using GovernmentData.US.Services;
using GovernmentData.US.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Reqnroll;

namespace GovernmentData.US.BDD.Tests.StepDefinitions
{
    [Binding]
    public class DisasterStepDefinitions
    {
        private readonly IObjectContainer objectContainer;

        public DisasterStepDefinitions(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddAllGovermentServices();
            var serviceProvider = services.BuildServiceProvider();
            objectContainer.RegisterInstanceAs<IDisasterService>(serviceProvider.GetService<IDisasterService>());
        }

        [Given("the property is located at (.*), (.*), (.*) (.*)")]
        public void GivenThePropertyIsLocatedAt(string streetAddress, string city, string state, int zip)
        {
            var disasterService  = this.objectContainer.Resolve<IDisasterService>();
            disasterService.GetDisasters(DateTime.Now, DateTime.Now, state);
        }

        [Given("the property is being analyzed between the dates (.*) and (.*)")]
        public void GivenThePropertyIsBeingAnalyzedBetweenTheDates(DateTime fromDate, DateTime toDate)
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
