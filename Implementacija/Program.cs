using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

interface IProba
{
    void Print();
}

class Proba : IProba
{
    public void Print()
    {
        Console.WriteLine("Proba interfejs pecatenje");
        Console.ReadLine();
    }
}

namespace Implementacija
{
    class Program
    {
        static void Main(string[] args)
        {
            Proba P1 = new Proba();
            P1.Print();
        }
    }
}
