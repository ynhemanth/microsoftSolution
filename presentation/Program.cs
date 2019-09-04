using Service;
using System;

namespace presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Starter.Init();            
            var initiator = Setup.Retrieve<Initiator>();
            var data = initiator.FetchData();            
            Console.WriteLine(data);
            Console.ReadLine();

        }
    }
}
