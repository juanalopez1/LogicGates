namespace Library.Tests;

public class LogicGateTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectAddInt()
    {
        AndGate myTestGate = new AndGate("And");
        int myIntInput = 1;
        int mySecondInput = 0;
        myTestGate.AddNewIntInput(myTestGate.GateName, myIntInput);
        myTestGate.AddNewIntInput(myTestGate.GateName, mySecondInput);

        int myResult = myTestGate.Inputs.Count();
        int expectedResult = 2;

        Assert.That(myResult, Is.EqualTo(expectedResult));

    }

    [Test]
    public void IncorrectAddInt()
    {
        AndGate myTestGate = new AndGate("And");
        int myIntInput = 2;
        int mySecondInput = 4;

        Assert.Catch<Exception>(() => myTestGate.AddNewIntInput(myTestGate.GateName, myIntInput));
        Assert.Catch<Exception>(() => myTestGate.AddNewIntInput(myTestGate.GateName, mySecondInput));

    }


}