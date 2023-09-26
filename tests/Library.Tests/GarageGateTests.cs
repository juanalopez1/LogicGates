namespace Library.Tests;

public class GarageGateTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(1, 1, 1)]
    public void CorrectValueButtons(int buttonAStatus, int buttonBStatus, int buttonCStatus)
    {
        LogicGate notA = new NotGate("Not-A");
        notA.AddNewIntInput("A", buttonAStatus);
        LogicGate notB = new NotGate("Not-B");
        notB.AddNewIntInput("B", buttonBStatus);

        LogicGate and1 = new AndGate("And-1");
        and1.AddNewIntInput("A", buttonAStatus);
        and1.AddNewIntInput("B", buttonBStatus);

        LogicGate and2 = new AndGate("And-2");
        and2.AddNewIntInput(notA.GateName, notA.ExitCalculator());
        and2.AddNewIntInput(notB.GateName, notB.ExitCalculator());

        LogicGate or = new OrGate("Or");
        or.AddNewIntInput(and1.GateName, and1.ExitCalculator());
        or.AddNewIntInput(and2.GateName, and2.ExitCalculator());

        LogicGate finalAnd = new AndGate("Final And");
        finalAnd.AddNewIntInput("C", buttonCStatus);
        finalAnd.AddNewIntInput(or.GateName, or.ExitCalculator());

        int myResult = finalAnd.ExitCalculator();
        if (myResult > 0)
        {
            myResult = 1;
        }
        else
        {
            myResult = 0;
        }

        int expectedResult = 1;

        Assert.That(myResult, Is.EqualTo(expectedResult));
    }

    [TestCase(1, 1, 0)]
    public void IncorrectValueButtons(int buttonAStatus, int buttonBStatus, int buttonCStatus)
    {
        LogicGate notA = new NotGate("Not-A");
        notA.AddNewIntInput("A", buttonAStatus);

        LogicGate notB = new NotGate("Not-B");
        notB.AddNewIntInput("B", buttonBStatus);

        LogicGate and1 = new AndGate("And-1");
        and1.AddNewIntInput("A", buttonAStatus);
        and1.AddNewIntInput("B", buttonBStatus);

        LogicGate and2 = new AndGate("And-2");
        and2.AddNewIntInput(notA.GateName, notA.ExitCalculator());
        and2.AddNewIntInput(notB.GateName, notB.ExitCalculator());

        LogicGate or = new OrGate("Or");
        or.AddNewIntInput(and1.GateName, and1.ExitCalculator());
        or.AddNewIntInput(and2.GateName, and2.ExitCalculator());

        LogicGate finalAnd = new AndGate("Final And");
        finalAnd.AddNewIntInput("C", buttonCStatus);
        finalAnd.AddNewIntInput(or.GateName, or.ExitCalculator());

        int myResult = finalAnd.ExitCalculator();
        if (myResult > 0)
        {
            myResult = 1;
        }
        else
        {
            myResult = 0;
        }

        int expectedResult = 0;

        Assert.That(myResult, Is.EqualTo(expectedResult));
    }


}