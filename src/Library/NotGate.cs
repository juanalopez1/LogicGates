namespace Library;
public class NotGate : LogicGate
{
    public NotGate(string gateName) : base(gateName)
    {
        this.GateName = gateName;
    }
    public override bool ValidateInputs()
    {
        return (this.Inputs.Count + this.InputGate.Count == 1) ? true : false;
    }

    public override int ExitCalculator()
    {
        if (ValidateInputs() == true)
        {
            if (this.Inputs.Count > 0)
            {
                if (this.Inputs[0] > 0)
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
                int finalExit = this.InputGate[0].ExitCalculator();
                if (finalExit > 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }

            }
        }
        else
        {
            throw new Exception("entradas invalidas");
        }
    }

}