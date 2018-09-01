namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class AbstractClass
    {
        public abstract int PrimitiveOperation1();
        public abstract int PrimitiveOperation2();
        
        /// <summary>
        /// Sets a template of how the primitive methods are executed in a combination.
        /// </summary>
        /// <returns>Returns the sum of the two primitive operations.</returns>
        public int TemplateMethod()
        {
            return PrimitiveOperation1() + PrimitiveOperation2();
        }
    }
}