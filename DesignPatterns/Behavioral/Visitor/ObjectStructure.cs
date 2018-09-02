using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Visitor
{
    public class ObjectStructure
    {
        public List<Element> Elements { get; private set; }

        public ObjectStructure()
        {
            Elements = new List<Element>();
        }

        /// <summary>
        /// Add an Element to the list of visitable objects.
        /// </summary> 
        /// <param name="element">The element to attach.</param>
        public void Attach(Element element)
        {
            Elements.Add(element);
        }

        /// <summary>
        /// Remove an Element from the list of visitable objects.
        /// </summary> 
        /// <param name="element">The element to remove.</param>
        public void Detach(Element element)
        {
            Elements.Remove(element);
        }


        /// <summary>
        /// Accept a visitor that will visit all attached elements.
        /// </summary> 
        /// <param name="visitor">Visitor to accept a visit from.</param>
        public void Accept(Visitor vistor)
        {
            foreach(var element in Elements)
            {
                element.Accept(vistor);
            }
        }
    }
}