##Interpreter Design Pattern##
The interpreter design pattern is geared towards providing a design for defining rules and parsing expressions. 

##Practical use:##
One of the main uses of this design is to define a grammar for a language.  The heirarchical nature of this design allows for representation of a grammar.

Example:

    NonTerm1 -> NonTerm2 & Term1 | Term1 & Term2
    NonTerm2 -> Term3 & Term4

Where a Non-Terminal expression can evaluate to a compisition of multiple other expressions.

Reference:

https://www.oodesign.com/interpreter-pattern.html