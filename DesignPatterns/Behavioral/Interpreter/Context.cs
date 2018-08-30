namespace DesignPatterns.Behavioral.Interpreter
{
    public class Context
    {
        public string Input { get; set; }

        public Context(string str) 
        {
            Input = str;
        }
    }
}