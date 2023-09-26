using System.Collections;
using System.Dynamic;

namespace Library;
public abstract class LogicGate
{
    public string GateName { get; set; }
    public List<int> Inputs { get; }
    public LogicGate(string gateName)
    {
        this.GateName = gateName;
        this.Inputs = new List<int>();
    }
    public void AddNewIntInput(string myInput, int value)
    {
        if (value == 1 || value == 0)
        {
            this.Inputs.Add(value);
        }
        else
        {
            throw new Exception("Ingrese un valor valido");
        }
    }
    public abstract int ExitCalculator();
    public abstract bool ValidateInputs();


}