﻿using System.Collections;
using System.Dynamic;

namespace Library;
public class AndGate : LogicGate
{
    public AndGate(string gateName) : base(gateName)
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
            int finalExit = 1;
            foreach (int input in this.Inputs)
            {
                if (input == 0 || input == 1)
                {
                    finalExit = finalExit * input;
                }
            }
            return finalExit;

        }
        else
        {
            throw new Exception("Número de entradas invalidos");
        }
    }


}
