namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class ConcreteHandler1 : Handler
    {
        /// <summary>
        /// Handles a request by adding 2 to it.
        /// </summary>
        /// <param name="request">Request integer.</param>
        /// <returns>Request integer plus 2.</returns>
        /// <seealso cref="Handler.HandleRequest(int)"/>
        public override int HandleRequest(int request)
        {
            int result = request + 2;

            if(Successor != null)
            {
                Successor.HandleRequest(result);
            }

            LastRequest = request;
            LastResult = result;

            return result;
        }
    }
}