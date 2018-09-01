namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class ConcreteClass : AbstractClass
    {
        /// <summary>
        /// Primitive operation overrided by Concrete class.
        /// </summary>
        /// <returns>Returns arbitrary 1.</returns>
        public override int PrimitiveOperation1()
        {
            return 1;
        }

        /// <summary>
        /// Primitive operation overrided by Concrete class.
        /// </summary>
        /// <returns>Returns arbitrary 2.</returns>
        public override int PrimitiveOperation2()
        {
            return 2;
        }
    }
}