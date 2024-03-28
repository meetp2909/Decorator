using System;
using decorator.Interface;
using decorator.Classes;
using decorator.Decorators;

// using decorator.Decortors;

// namespace Decorator
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
            // Create a ConcreteComponent
            IComponent<string> component = new Concrete();

            // Create one of each decorator
            IComponent<string> plainDecorator = new PlainDecorator(component);
            IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);
            //IComponent<string> colorDecorator = new ColorDecorator(component);

            // Call GetText() method on each object and print the result
            Console.WriteLine("ConcreteComponent: " + component.GetText());
            Console.WriteLine("PlainDecorator: " + plainDecorator.GetText());
            Console.WriteLine("UpperCaseDecorator: " + upperCaseDecorator.GetText());
            // Console.WriteLine("ColorDecorator: " + colorDecorator.GetText());
//         }
//     }
// }
