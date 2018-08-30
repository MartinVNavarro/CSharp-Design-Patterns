namespace DesignPatterns.Behavioral.Command
{
    public class Invoker
    {
        /// <summary>
        /// Private command
        /// </summary>
        private Command _command;

        /// <summary>
        /// Sets the command to be executed.
        /// </summary>
        /// <param name="command">Command</param>
        public void SetCommand(Command command)
        {
            this._command = command;
        }

        /// <summary>
        /// Executes the command if one is set.
        /// </summary>
        public void ExecuteCommand()
        {
            if ( this._command != null )
            {
                this._command.Execute();
            }
        }
    }
}