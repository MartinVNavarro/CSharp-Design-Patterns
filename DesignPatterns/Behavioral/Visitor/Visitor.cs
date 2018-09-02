namespace DesignPatterns.Behavioral.Visitor
{
    public abstract class Visitor
    {
        public abstract void Visit(ConcreteElement1 element);
        public abstract void Visit(ConcreteElement2 element);
    }
}