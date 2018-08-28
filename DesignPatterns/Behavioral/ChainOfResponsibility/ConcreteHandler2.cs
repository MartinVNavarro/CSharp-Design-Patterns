namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        /// <summary>
        /// Handles a request by subtracting 1 from it.
        /// </summary>
        /// <param name="request">Request integer.</param>
        /// <returns>Request integer minus 1.</returns>
        /// <seealso cref="Handler.HandleRequest(int)"/>
        public override int HandleRequest(int request)
        {
            int result = request - 1;

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