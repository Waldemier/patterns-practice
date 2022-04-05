using PatternsThirdPart.Iterator.Implementations;
using PatternsThirdPart.Memento.Implementation;
using System;

using CustomMediator = PatternsThirdPart.Mediator.Implementation.Mediator;

namespace PatternsThirdPart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 (Iterator)
            var reader = new Reader();

            var evenEnumerable = new EvenNumbersEnumerable();
            reader.Read(evenEnumerable);

            Console.WriteLine();

            var oddEnumerable = new OddNumbersEnumerable();
            reader.Read(oddEnumerable);

            Console.WriteLine();

            // Task 2 (Mediator)
            var mediator = new CustomMediator();

            mediator.FirstButton.Click();
            Console.WriteLine();
            mediator.SecondButton.Click();
            Console.WriteLine();
            mediator.ThirdButton.Click();

            // Task 3 (Memento)
            var notebook = new Notebook();

            while (true)
            {
                var note = Console.ReadLine();
                Console.WriteLine("Do you want to save ? [s/n] | Restore lastest [r]");
                var condition = Console.ReadLine();

                if (condition.Equals("r", StringComparison.OrdinalIgnoreCase))
                {
                    notebook.Restore();
                }

                if (condition.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    notebook.Save(note);
                }

                if(condition.Equals("q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }

            notebook.ShowHistory();
        }
    }
}
