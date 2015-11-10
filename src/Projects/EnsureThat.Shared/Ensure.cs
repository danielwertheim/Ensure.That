using System;
using System.Diagnostics;
using System.Linq.Expressions;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static class Ensure
    {
        public static bool IsActive { get; private set; } = true;

        public static void Off()
        {
            IsActive = false;
        }

        public static void On()
        {
            IsActive = true;
        }

        [DebuggerStepThrough]
        public static Param<T> That<T>([NoEnumeration]T value, string name = Param.DefaultName)
        {
            return new Param<T>(name, value);
        }

        [DebuggerStepThrough]
        public static TypeParam ThatTypeFor<T>(T value, string name = Param.DefaultName)
        {
            return new TypeParam(name, value.GetType());
        }

        /// <summary>
        /// Defines what to validate. Please read remarks.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression">Resolves the value to validate and if no <paramref name="name"/> is specified, also the name of the param by looking at the calling path in the expression, to get which member that is being validated.</param>
        /// <param name="name">If specified, used as the name instead of being extracted from the expression.</param>
        /// <returns></returns>
        /// <remarks>
        /// When using the <paramref name="expression"/> for value resolving, a compile
        /// is done to get the value of the argument. This leads to worse performance compared to overloads
        /// where you pass the value explicitly.
        /// </remarks>
        [DebuggerStepThrough]
        public static Param<T> That<T>(Expression<Func<T>> expression, string name = Param.DefaultName)
        {
            if (name == Param.DefaultName)
            {
                var memberExpression = expression.GetRightMostMember();
                name = memberExpression.ToPath();
            }

            return new Param<T>(
                name,
                expression.Compile().Invoke());
        }

        /// <summary>
        /// Defines what to validate.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="expression">Used to extract the calling path, to get which member that is being validated. Used as param name.</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public static Param<T> That<T>([NoEnumeration]T value, Expression<Func<T>> expression)
        {
            var memberExpression = expression.GetRightMostMember();

            return new Param<T>(
                memberExpression.ToPath(),
                value);
        }
    }
}