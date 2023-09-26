namespace Library;
public class NotGate : LogicGate
{
    public NotGate(string gateName) : base(gateName)
    {
        this.GateName = gateName;
    }
    public override bool ValidateInputs()
    {
        return (this.Inputs.Count == 1) ? true : false;
    }

    public override int ExitCalculator()
    {
        if (ValidateInputs() == true)
        {
            if (this.Inputs[0] > 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        else
        {
            throw new Exception("Entradas inválidas");
        }
    }

}