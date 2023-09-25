using System.Collections;
using System.Dynamic;

namespace Library;
public abstract class LogicGate
{
    public string GateName { get; set; }
    public List<int> Inputs { get; }
    public List<LogicGate> InputGate { get; }
    public LogicGate(string gateName)
    {
        this.GateName = gateName;
        this.Inputs = new List<int>();
        this.InputGate = new List<LogicGate>();
    }
    public void AddNewIntInput(string myInput, int value)
    {
        this.Inputs.Add(value);
    }

    public void AddNewGateInput(string myInput, LogicGate gate)
    {
        this.InputGate.Add(gate);
    }
    public abstract int ExitCalculator();
    public abstract bool ValidateInputs();


}