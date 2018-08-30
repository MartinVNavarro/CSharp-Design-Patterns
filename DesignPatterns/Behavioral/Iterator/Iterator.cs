namespace DesignPatterns.Behavioral.Iterator
{
    public abstract class Iterator
    {
        public abstract bool HasNext();
        public abstract object Next();
        public abstract object Prev();
        public abstract object First();
        public abstract object Curr();
    }
}