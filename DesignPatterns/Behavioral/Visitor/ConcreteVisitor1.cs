using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Visitor
{
    public class ConcreteVisitor1 : Visitor
    {
        /// <summary>
        /// List of visited elements for testing.
        /// </summary> 
        public List<Element> Visited { get; private set; }

        public ConcreteVisitor1()
        {
            Visited = new List<Element>();
        }

        /// <summary>
        /// Visit a concrete element 1.
        /// </summary> 
        /// <param name="element">Element to visit.</param>
        public override void Visit(ConcreteElement1 element)
        {
            Visited.Add(element);
        }

        /// <summary>
        /// Visit a concrete element 1.
        /// </summary> 
        /// <param name="element">Element to visit.</param>
        public override void Visit(ConcreteElement2 element)
        {
            Visited.Add(element);
        }
    }
}