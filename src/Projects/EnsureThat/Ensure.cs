using System;
using System.Linq.Expressions;

namespace EnsureThat
{
    public static class Ensure
    {
        public static Param<T> That<T>(T value, string name = Param.DefaultName)
        {
            return new Param<T>(name, value);
        }

        public static Param<T> That<T>(Expression<Func<object, T>> expression, string name = Param.DefaultName)
        {
            if (name == Param.DefaultName)
            {
                var memberExpressionBody = (MemberExpression)expression.Body;
                name = memberExpressionBody.Member.Name;
            }

            return new Param<T>(name, expression.Compile().Invoke(null));
        }

        public static TypeParam ThatTypeFor<T>(T value, string name = Param.DefaultName)
        {
            return new TypeParam(name, value.GetType());
        }
    }
}
