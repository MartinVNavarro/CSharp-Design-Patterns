namespace DesignPatterns.Behavioral.Interpreter
{
    public class TerminalExpression : AbstractExpression
    {
        /// <summary>
        /// Token that defines the Terminal Expression.
        /// </summary>
        public string Token { get; private set; }
        
        /// <summary>
        /// Constructor that sets the value of the token.
        /// </summary>
        /// <param name="str">A string that sets the value of Token. Must NOT contain white space.</param>
        public TerminalExpression(string str)
        {
            Token = str;
        }

        /// <summary>
        /// Interprets a string and determins if Token exists in it.
        /// </summary>
        /// <param name="str">A string to interpret.</param>
        /// <returns><c>bool</c> - True if Token exists in str else False.</returns>
        public override bool Interpret(string str)
        {
            // Split a space delimeted string
            var tokens = str.Split(' ');

            foreach(var token in tokens)
            {
                if(token == Token)
                {
                    return true;
                }
            }

            return false;
        }
    }
}