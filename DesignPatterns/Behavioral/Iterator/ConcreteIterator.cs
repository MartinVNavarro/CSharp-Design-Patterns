namespace DesignPatterns.Behavioral.Iterator
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _concreteAggregate;
        private int _index;
        public ConcreteIterator(ConcreteAggregate agg)
        {
            _concreteAggregate = agg;

            _index = 0;
        }
        public override object First()
        {
            _index = 0;
            
            return _concreteAggregate[_index];
        }

        public override bool HasNext()
        {
            return _index < _concreteAggregate.Size - 1;
        }

        public override object Next()
        {
            if( HasNext())
            {
                return _concreteAggregate[++_index];
            }

            return null;
        }

        public override object Prev()
        {
            if( _index > 0 )
            {
                return _concreteAggregate[--_index];
            }

            return null;
        }

        public override object Curr()
        {
            if(_concreteAggregate.Size > 0)
            {
                return _concreteAggregate[_index];
            }

            return null;
        }

    }
}