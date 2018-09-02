using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Visitor
{
    public class ConcreteElement1 : Element
    {
        /// <summary>
        /// List of visitors who have visited for testing.
        /// </summary> 
        public List<Visitor> VisitedBy { get; private set; }

        public ConcreteElement1()
        {
            VisitedBy = new List<Visitor>();
        }

        /// <summary>
        /// Accept a visitor and add it to the visited by list.
        /// </summary> 
        /// <param name="visitor">The visitor.</param>
        public override void Accept(Visitor vistor)
        {
            VisitedBy.Add(vistor);
            vistor.Visit(this);
        }
    }
}