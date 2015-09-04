using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace WFConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            Activity wfHello = new Hello();
            WorkflowInvoker.Invoke(wfHello);

            Console.ReadLine();
        }
    }
}
