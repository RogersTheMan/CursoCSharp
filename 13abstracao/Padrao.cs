using System;

abstract class Padrao
{

    public abstract void taxaEmprestimo(double valor);

    public void poupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança: R$ "+(valor*taxa ));
    }

}