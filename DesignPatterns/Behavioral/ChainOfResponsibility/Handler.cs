namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// The base abstract <c>Handler</c> class.
    /// </summary>
    /// <remarks>
    /// Outlines a class for handling requests that have to pass through a "chain of command".
    /// </remarks>
    public abstract class Handler
    {
        /// <summary>
        /// Last request to handle.
        /// <summary>
        public int LastRequest { get; set; }

        /// <summary>
        /// Last result from handle.
        /// <summary>
        public int LastResult { get; set; }

        /// <summary>
        /// Successor property of the Handler.
        /// <summary>
        /// <remarks>
        /// Successor of the handled request.
        /// </remarks>
        public Handler Successor { get; set; }

        /// <summary>
        /// Virtual method to handle a request.
        /// </summary>
        /// <param name="request">Integer representation of a theoretical request for the handler.</param>
        /// <returns>Resulting request after being handled.</returns>
        public virtual int HandleRequest(int request)
        {
            int result = request;

            LastRequest = request;
            LastResult  = result;

            return result;
        }
    }
}