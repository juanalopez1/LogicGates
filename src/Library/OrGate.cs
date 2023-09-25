
namespace Library;
public class OrGate : LogicGate
{
    public OrGate(string gateName) : base(gateName)
    {
        this.GateName = gateName;
    }
    public override bool ValidateInputs()
    {
        return (this.Inputs.Count + this.InputGate.Count >= 2) ? true : false;
    }
    public override int ExitCalculator()
    {
        if (ValidateInputs() == true)
        {
            if (this.InputGate.Count > 0)
            {
                int finalExit = 0;

                foreach (int input in this.Inputs)
                {
                    finalExit += input;
                }

                foreach (LogicGate gate in this.InputGate)
                {
                    finalExit += gate.ExitCalculator();
                }

                return finalExit;
            }
            else
            {
                int finalExit = 0;

                foreach (int input in this.Inputs)
                {
                    finalExit += input;
                }

                return finalExit;
            }

        }
        else
        {
            throw new Exception("numero de entradas invalido");
        }

    }

}