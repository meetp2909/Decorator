using Decorator.Components;

namespace Decorator.Components
{
    public class Concrete: IComponent<string>
    {
        public string GetText()
        {
            return "This is a concrete component.";
        }
    }
}
