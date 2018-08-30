using System.Collections;

namespace DesignPatterns.Behavioral.Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        public int Size 
        {
            get
            {
                return _arrayList.Count;
            } 
        }

        public object this[int index]
        {
            get
            {
                return _arrayList[index];
            }
        }

        private ArrayList _arrayList;

        public ConcreteAggregate()
        {
            _arrayList = new ArrayList();
        }

        public void Insert(object o)
        {
            _arrayList.Add(o);
        }

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}