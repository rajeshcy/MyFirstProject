using SpecFlowTests.SUT;
using FluentAssertions;
namespace SpecFlowTests.StepDefinitions

{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Calculator _calculator = new Calculator();
        private int _result;
        private readonly ScenarioContext _scenarioContext;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When(@"we find difference of the two numbers")]
        public void WhenWeFindDifferenceOfTheTwoNumbers()
        {
            _result = _calculator.Subtract();
        }

        [When(@"the two numbers are multiplied")]
        public void thetwonumbersaremultiplied()
        {
            _result = _calculator.Multiply();
        }

        [When(@"the division is done")]
        public void thedivisionisdone()
        {
            _result = _calculator.Divide();
        }

        [When(@"Divided By Zero")]
        public void DividedByZero()
        {
            _result = _calculator.DividedByZero();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            _result.Should().Be(result);
        }
    }
}