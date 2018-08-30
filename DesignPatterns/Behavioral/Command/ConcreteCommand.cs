namespace DesignPatterns.Behavioral.Command
{
    public class ConcreteCommand : Command
    {
        /// <summary>
        /// Constructor, uses base constructor
        /// </summary>
        /// <param name="receiver">Receiver of the command</param>
        public ConcreteCommand(Receiver receiver) : base(receiver){}
        

        /// <summary>
        /// Executes the action of the receiver.
        /// </summary>
        public override void Execute()
        {
            this._receiver.Action();    
        }
    }
}