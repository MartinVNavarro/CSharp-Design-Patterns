namespace DesignPatterns.Behavioral.Interpreter
{
    public class NonterminalExpression : AbstractExpression
    {
        public AbstractExpression Expression1 { get; private set; }
        public AbstractExpression Expression2 { get; private set; }

        /// <summary>
        /// Constructor that defines this non-terminal Expression as an expression composed of two others.
        /// </summary>
        /// <param name="exp1">One composite expression.</param>
        /// <param name="exp2">Second composite expression.</param>
        public NonterminalExpression(AbstractExpression exp1, AbstractExpression exp2)
        {
            Expression1 = exp1;
            Expression2 = exp2;
        }

        /// <summary>
        /// Interprets a string and evalutes the AND of both composite expressions.
        /// </summary>
        /// <param name="str">A string to interpret.</param>
        /// <returns><c>bool</c> - True if expression 1 AND expression 2 else False.</returns>
        public override bool Interpret(string str)
        {
            return Expression1.Interpret(str) && Expression2.Interpret(str);
        }
    }
}