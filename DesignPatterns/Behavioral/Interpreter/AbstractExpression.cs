namespace DesignPatterns.Behavioral.Interpreter
{
    public abstract class AbstractExpression
    {
        public abstract bool Interpret(string str);
    }
}