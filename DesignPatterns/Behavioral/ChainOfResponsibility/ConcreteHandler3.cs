namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class ConcreteHandler3 : Handler
    {
        /// <summary>
        /// Handles a request by multiplying it by 10.
        /// </summary>
        /// <param name="request">Request integer.</param>
        /// <returns>Request integer multiplied by 10.</returns>
        /// <seealso cref="Handler.HandleRequest(int)"/>
        public override int HandleRequest(int request)
        {
            int result = request * 10;

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