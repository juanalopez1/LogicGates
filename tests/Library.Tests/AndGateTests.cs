namespace Library.Tests;

public class AndGateTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(0, 0)]
    public void CorrectExitCalculator1(int input1, int input2)
    {
        AndGate myTestGate = new AndGate("And");
        myTestGate.AddNewIntInput(myTestGate.GateName, input1);
        myTestGate.AddNewIntInput(myTestGate.GateName, input2);

        int myResult = myTestGate.ExitCalculator();
        int expectedResult = 0;

        Assert.That(myResult, Is.EqualTo(expectedResult));

    }

    [TestCase(0, 1)]
    public void CorrectExitCalculator2(int input1, int input2)
    {
        AndGate myTestGate = new AndGate("And");
        myTestGate.AddNewIntInput(myTestGate.GateName, input1);
        myTestGate.AddNewIntInput(myTestGate.GateName, input2);

        int myResult = myTestGate.ExitCalculator();
        int expectedResult = 0;

        Assert.That(myResult, Is.EqualTo(expectedResult));

    }

    [TestCase(1, 0)]
    public void CorrectExitCalculator3(int input1, int input2)
    {
        AndGate myTestGate = new AndGate("And");
        myTestGate.AddNewIntInput(myTestGate.GateName, input1);
        myTestGate.AddNewIntInput(myTestGate.GateName, input2);

        int myResult = myTestGate.ExitCalculator();
        int expectedResult = 0;

        Assert.That(myResult, Is.EqualTo(expectedResult));

    }

    [TestCase(1, 1)]
    public void CorrectExitCalculator4(int input1, int input2)
    {
        AndGate myTestGate = new AndGate("And");
        myTestGate.AddNewIntInput(myTestGate.GateName, input1);
        myTestGate.AddNewIntInput(myTestGate.GateName, input2);

        int myResult = myTestGate.ExitCalculator();
        int expectedResult = 1;

        Assert.That(myResult, Is.EqualTo(expectedResult));

    }

}