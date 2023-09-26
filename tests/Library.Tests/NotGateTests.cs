namespace Library.Tests;

public class NotGateTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(0)]
    public void CorrectExitCalculator1(int input1)
    {
        NotGate myTestGate = new NotGate("Not");
        myTestGate.AddNewIntInput(myTestGate.GateName, input1);

        int myResult = myTestGate.ExitCalculator();
        int expectedResult = 1;

        Assert.That(myResult, Is.EqualTo(expectedResult));

    }

    [TestCase(1)]
    public void CorrectExitCalculator4(int input1)
    {
        NotGate myTestGate = new NotGate("Not");
        myTestGate.AddNewIntInput(myTestGate.GateName, input1);

        int myResult = myTestGate.ExitCalculator();
        int expectedResult = 0;

        Assert.That(myResult, Is.EqualTo(expectedResult));


    }

}