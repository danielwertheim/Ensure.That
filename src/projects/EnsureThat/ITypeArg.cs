using System;
using EnsureThat.Annotations;
using JetBrains.Annotations;

namespace EnsureThat
{
    public interface ITypeArg
    {
        Type IsInt([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsInt<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        Type IsShort([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsShort<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        Type IsDecimal([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsDecimal<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        Type IsDouble([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsDouble<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        Type IsFloat([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsFloat<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        Type IsBool([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsBool<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        Type IsDateTime([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsDateTime<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        Type IsString([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsString<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsOfType<T>([ValidatedNotNull]T param, [NotNull] Type expectedType, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        Type IsOfType([ValidatedNotNull]Type param, [NotNull] Type expectedType, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsNotOfType<T>([ValidatedNotNull]T param, [NotNull] Type nonExpectedType, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        Type IsNotOfType([ValidatedNotNull]Type param, [NotNull] Type nonExpectedType, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        T IsClass<T>([ValidatedNotNull]T param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
        Type IsClass([ValidatedNotNull]Type param, [InvokerParameterName] string paramName = Param.DefaultName, OptsFn optsFn = null);
    }
}