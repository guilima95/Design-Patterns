namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message formError = new($" Parent {nameof(formError)} - invalid form");

            Message userFormError = new($" Child {nameof(userFormError)} - user form incorrect");

            InputMessage minLenghtError = new($" Children {nameof(minLenghtError)} - min 2 characters");
            InputMessage maxLenghtError = new($" Children {nameof(maxLenghtError)} - max 8 characters");

            userFormError.AddMessage(minLenghtError);
            userFormError.AddMessage(maxLenghtError);

            formError.AddMessage(userFormError);

            Message userDomainError = new("error user domain");

            DomainMessage cpfError = new("CPF incorrect");
            DomainMessage emailError = new("E-mail incorrect");

            userDomainError.AddMessage(cpfError);
            userDomainError.AddMessage(emailError);

            formError.AddMessage(userDomainError);

            formError.Result(sub: 2);
        }
    }
}

/*

Participants
#
The classes and objects participating in this pattern include:

Component(DrawingElement) - IMessage

declares the interface for objects in the composition.
implements default behavior for the interface common to all classes, as appropriate.
declares an interface for accessing and managing its child components.
(optional) defines an interface for accessing a component's parent in the recursive structure, and implements it if that's appropriate.


Leaf(PrimitiveElement) - DomainMessage / InputMessage
represents leaf objects in the composition.A leaf has no children.
defines behavior for primitive objects in the composition.


Composite(CompositeElement) - Message
defines behavior for components having children.
stores child components.
implements child - related operations in the Component interface.


Client(CompositeApp) - Program
manipulates objects in the composition through the Component interface.

*/