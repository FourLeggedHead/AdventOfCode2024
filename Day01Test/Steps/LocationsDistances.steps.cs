using Reqnroll;

namespace LocationDistancesTest.Steps
{
    [Binding]
    public class LocationsDistancesSteps
    {
        [Given("the first list of location IDs is:")]
        public void GivenTheFirstListOfLocationIDsIs(DataTable dataTable)
        {
            throw new NotImplementedException("The method 'GivenTheFirstListOfLocationIDsIs' is not implemented.");
        }

        [Given("the second list of location IDs is:")]
        public void GivenTheSecondListOfLocationIDsIs(DataTable dataTable)
        {
            throw new NotImplementedException("The method 'GivenTheSecondListOfLocationIDsIs' is not implemented.");
        }

        [Given("the {int}st smallest location ID in the first list is {int}")]
        [Given("the {int}nd smallest location ID in the first list is {int}")]
        [Given("the {int}rd smallest location ID in the first list is {int}")]
        [Given("the {int}th smallest location ID in the first list is {int}")]
        public void GivenTheSmallestLocationIdInTheFirstListIs(int position, int expectedId)
        {
            throw new NotImplementedException("The method 'GivenTheSmallestLocationIdInTheFirstListIs' is not implemented.");
        }

        [Given("the {int}st smallest location ID in the second list is {int}")]
        [Given("the {int}nd smallest location ID in the second list is {int}")]
        [Given("the {int}rd smallest location ID in the second list is {int}")]
        [Given("the {int}th smallest location ID in the second list is {int}")]
        public void GivenTheSmallestLocationIdInTheSecondListIs(int position, int expectedId)
        {
            throw new NotImplementedException("The method 'GivenTheSmallestLocationIdInTheSecondListIs' is not implemented.");
        }

        [When("I calculate the distance between the two location IDs")]
        public void WhenICalculateTheDistanceBetweenTheTwoLocationIDs()
        {
            throw new NotImplementedException("The method 'WhenICalculateTheDistanceBetweenTheTwoLocationIDs' is not implemented.");
        }

        [When("I calculate the total distance between the two lists")]
        public void WhenICalculateTheTotalDistanceBetweenTheTwoLists()
        {
            throw new NotImplementedException("The method 'WhenICalculateTheTotalDistanceBetweenTheTwoLists' is not implemented.");
        }

        [Then("the distance should be {int}")]
        public void ThenTheDistanceShouldBe(int expectedDistance)
        {
            throw new NotImplementedException("The method 'ThenTheDistanceShouldBe' is not implemented.");
        }

        [Then("the total distance should be {int}")]
        public void ThenTheTotalDistanceShouldBe(int expectedTotalDistance)
        {
            throw new NotImplementedException("The method 'ThenTheTotalDistanceShouldBe' is not implemented.");
        }
    }
}