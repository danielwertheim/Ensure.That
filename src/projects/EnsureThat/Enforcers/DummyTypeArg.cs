using System;

namespace EnsureThat.Enforcers
{
    internal class DummyTypeArg : ITypeArg
    {
        public Type IsInt(Type param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public T IsInt<T>(T param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public Type IsShort(Type param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public T IsShort<T>(T param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public Type IsDecimal(Type param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public T IsDecimal<T>(T param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public Type IsDouble(Type param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public T IsDouble<T>(T param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public Type IsFloat(Type param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public T IsFloat<T>(T param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public Type IsBool(Type param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public T IsBool<T>(T param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public Type IsDateTime(Type param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public T IsDateTime<T>(T param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public Type IsString(Type param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public T IsString<T>(T param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public T IsOfType<T>(T param, Type expectedType, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public Type IsOfType(Type param, Type expectedType, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public T IsNotOfType<T>(T param, Type nonExpectedType, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public Type IsNotOfType(Type param, Type nonExpectedType, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public T IsClass<T>(T param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;

        public Type IsClass(Type param, string paramName = Param.DefaultName, OptsFn optsFn = null)
            => param;
    }
}