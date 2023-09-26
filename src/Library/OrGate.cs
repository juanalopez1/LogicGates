
namespace Library;
public class OrGate : LogicGate
{
    public OrGate(string gateName) : base(gateName)
    {
        this.GateName = gateName;
    }
    public override bool ValidateInputs()
    {
        return (this.Inputs.Count >= 2) ? true : false;
    }
    public override int ExitCalculator()
    {
        if (ValidateInputs() == true)
        {
            int finalExit = 0;

            foreach (int input in this.Inputs)
            {
                finalExit += input;
            }

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
            throw new Exception("Numero de entradas invalido");
        }

    }
}

