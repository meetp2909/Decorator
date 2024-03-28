using System;
using decorator.Interface;
using decorator.Classes;
using decorator.Decorators;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IComponent<string> component = new Concrete();
            IComponent<string> plainDecorator = new PlainDecorator(component);
            IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);
            IComponent<string> colorDecorator = new ColorDecorator(component);

            Console.WriteLine("ConcreteComponent: " + component.GetText());
            Console.WriteLine("PlainDecorator: " + plainDecorator.GetText());
            Console.WriteLine("UpperCaseDecorator: " + upperCaseDecorator.GetText());
            Console.WriteLine("ColorDecorator: " + colorDecorator.GetText());
        }
    }
}
