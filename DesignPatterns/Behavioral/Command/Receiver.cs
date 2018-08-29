namespace DesignPatterns.Behavioral.Command
{
    public class Receiver
    {
        public int ActionPerformed { get; private set; }


        /// <summary>
        /// Constructor that initializes the ActionPerformed property for tests.
        /// </summary>
        public Receiver() {
            ActionPerformed = 0;
        }
        
        /// <summary>
        /// Action for the receiver of a command. 
        /// </summary>
        /// <remarks>
        /// For test case, the action incriments ActionPerformed.
        /// </remarks>
        public void Action()
        {
            ActionPerformed++;
        }
    }
}