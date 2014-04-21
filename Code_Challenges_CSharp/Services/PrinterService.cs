using System;
using Code_Challenges_CSharp.Interfaces;

namespace Code_Challenges_CSharp.Services
{
    public class PrinterService : IPrinter
    {
        public void Print(string message, string data)
        {
            Console.WriteLine("{0}: {1}\n", message, data);
        } 
    }
}