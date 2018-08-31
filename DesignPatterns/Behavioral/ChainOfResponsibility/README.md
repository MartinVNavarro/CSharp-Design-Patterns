## Chain of Responsibility ##
The Chain of Responsibility design pattern encapsulates responsibilites of a request into a chain of individual objects.  This decouples the caller of the request from the reciever of the request.

## Practical use: ##
By having a chain-like design to handle requests, this removes the precense of monolithic handlers that contian all of the functionality to handle a certain request.  The sender of the request also does not need to be directly attached to the receiver.

Reference:

https://www.oodesign.com/chain-of-responsibility-pattern.html