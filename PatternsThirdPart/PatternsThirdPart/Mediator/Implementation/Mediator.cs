using PatternsThirdPart.Mediator.Abstraction;
using System;

namespace PatternsThirdPart.Mediator.Implementation
{
    public class Mediator : IMediator
    {
        public Button FirstButton { get; }
        public Button SecondButton { get; }
        public Button ThirdButton { get; }

        public Mediator()
        {
            FirstButton = new FirstButton(this);
            SecondButton = new SecondButton(this);
            ThirdButton = new ThirdButton(this);
        }

        public void Send(object sender, string message)
        {
            if (sender == FirstButton)
            {
                Console.WriteLine(message);
                SecondButton.Nofity();
                ThirdButton.Nofity();
            }
            
            if (sender == SecondButton)
            {
                Console.WriteLine(message);
                FirstButton.Nofity();
                ThirdButton.Nofity();
            }

            if (sender == ThirdButton)
            {
                Console.WriteLine(message);
                FirstButton.Nofity();
                SecondButton.Nofity();
            }
        }
    }
}
