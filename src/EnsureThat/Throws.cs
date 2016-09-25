using System;

namespace EnsureThat
{
    public class Throws<T>
    {
        public delegate Func<Param<T>, Exception> ExceptionFnConfig(Throws<T> throws);
        
        public static Throws<T> Instance { get; private set; }
        public Func<Param<T>, Exception> InvalidOperationException { get; set; } 

        static Throws()
        {
            Instance = new Throws<T>();
        }

        private Throws()
        {
            InvalidOperationException = param => ExceptionFactory.CreateForInvalidOperation(param, ExceptionMessages.EnsureExtensions_InvalidOperationException);
        }

        public virtual Func<Param<T>, Exception> Custom(Func<Param<T>, Exception> exceptionFn)
        {
            return exceptionFn;
        }
    }
}