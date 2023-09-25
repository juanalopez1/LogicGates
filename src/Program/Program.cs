using Library;

namespace Program;
class Program
{
    static void Main(string[] args)
    {
        LogicGate and1 = new AndGate("AND-1");
        and1.AddNewIntInput("A", 1);
        and1.AddNewIntInput("B", 1);
        Console.WriteLine($"Resultado intermedio de compuerta {and1.GateName}: {and1.ExitCalculator()}");

        LogicGate or2 = new OrGate("OR-2");
        or2.AddNewIntInput("C", 0);
        or2.AddNewIntInput("D", 1);
        or2.AddNewGateInput(and1.GateName, and1);
        Console.WriteLine($"Resultado intermedio de compuerta {or2.GateName}: {or2.ExitCalculator()}");

        LogicGate not3 = new NotGate("NOT-3");
        not3.AddNewGateInput(or2.GateName, or2);
        Console.WriteLine($"Resultado final: {not3.ExitCalculator()}");

    }

}
