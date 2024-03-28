using decorator.Interface;
using decorator.Classes;

namespace decorator.Decorators
{
    public class PlainDecorator : Decorator<string>
    {
        public PlainDecorator(IComponent<string> component) : base(component)
        {
        }

        public override string GetText()
        {
            return "Honda Civic" + base.GetText();
        }
    }
}
