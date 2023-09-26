using System.Collections;
using System.Dynamic;

namespace Library;
public class GarageGate : LogicGate
{
    public int ButtonAStatus { get; set; }
    public int ButtonBStatus { get; set; }
    public int ButtonCStatus { get; set; }
    public GarageGate(string gateName, int buttonAStatus, int buttonBStatus, int buttonCStatus) : base(gateName)
    {
        this.GateName = gateName;
        this.ButtonAStatus = buttonAStatus;
        this.ButtonBStatus = buttonBStatus;
        this.ButtonCStatus = buttonCStatus;
    }

    public override bool ValidateInputs()
    {
        return (this.Inputs.Count > 0) ? true : false;
    }

    public override int ExitCalculator()
    {
        if (this.ButtonCStatus == 1 && this.ButtonAStatus == 0 && this.ButtonBStatus == 0)
        {
            LogicGate notA = new NotGate("Not-A");
            notA.AddNewIntInput("A", this.ButtonAStatus);
            LogicGate notB = new NotGate("Not-B");
            notB.AddNewIntInput("B", this.ButtonAStatus);

            LogicGate and1 = new AndGate("And-1");
            and1.AddNewIntInput("A", this.ButtonAStatus);
            and1.AddNewIntInput("B", this.ButtonAStatus);

            LogicGate and2 = new AndGate("And-2");
            and2.AddNewIntInput(notA.GateName, notA.ExitCalculator());
            and2.AddNewIntInput(notB.GateName, notB.ExitCalculator());

            LogicGate or = new OrGate("Or");
            or.AddNewIntInput(and1.GateName, and1.ExitCalculator());
            or.AddNewIntInput(and2.GateName, and2.ExitCalculator());

            LogicGate finalAnd = new AndGate("Final And");
            finalAnd.AddNewIntInput("C", this.ButtonCStatus);
            finalAnd.AddNewIntInput(or.GateName, or.ExitCalculator());

            int finalExit = finalAnd.ExitCalculator();
            if (finalExit > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        else if (this.ButtonAStatus == 1 && this.ButtonBStatus == 1 && this.ButtonCStatus == 1)
        {
            LogicGate notA = new NotGate("Not-A");
            notA.AddNewIntInput("A", this.ButtonAStatus);
            LogicGate notB = new NotGate("Not-B");
            notB.AddNewIntInput("B", this.ButtonBStatus);

            LogicGate and1 = new AndGate("And-1");
            and1.AddNewIntInput("A", this.ButtonAStatus);
            and1.AddNewIntInput("B", this.ButtonBStatus);

            LogicGate and2 = new AndGate("And-2");
            and2.AddNewIntInput(notA.GateName, notA.ExitCalculator());
            and2.AddNewIntInput(notB.GateName, notB.ExitCalculator());

            LogicGate or = new OrGate("Or");
            or.AddNewIntInput(and1.GateName, and1.ExitCalculator());
            or.AddNewIntInput(and2.GateName, and2.ExitCalculator());

            LogicGate finalAnd = new AndGate("Final And");
            finalAnd.AddNewIntInput("C", this.ButtonCStatus);
            finalAnd.AddNewIntInput(or.GateName, or.ExitCalculator());

            int finalExit = finalAnd.ExitCalculator();
            if (finalExit > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        else
        {
            return 0;
        }
    }

}