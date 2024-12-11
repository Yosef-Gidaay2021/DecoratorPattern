
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a ConcreteComponent
        IComponent<string> component = new ConcreteComponent();
        Console.WriteLine("ConcreteComponent: " + component.GetText());

        // Wrap the component in a PlainDecorator
        IComponent<string> plainDecorator = new PlainDecorator(component);
        Console.WriteLine("PlainDecorator: " + plainDecorator.GetText());

        // Wrap the PlainDecorator in an UpperCaseDecorator
        IComponent<string> upperCaseDecorator = new UpperCaseDecorator(plainDecorator);
        Console.WriteLine("UpperCaseDecorator: " + upperCaseDecorator.GetText());

        // Wrap the UpperCaseDecorator in a ColorDecorator
        IComponent<string> colorDecorator = new ColorDecorator(upperCaseDecorator);
        Console.WriteLine("ColorDecorator: " + colorDecorator.GetText());
    }
}