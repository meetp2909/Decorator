using decorator.Interface;

namespace decorator.Classes;

    public class Concrete: IComponent<string>
    {
        public string GetText()
        {
            return "This is a concrete component.";
        }
    }

