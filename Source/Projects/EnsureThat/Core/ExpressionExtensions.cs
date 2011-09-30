using System;
using System.Linq.Expressions;
using EnsureThat.Resources;

namespace EnsureThat.Core
{
    internal static class ExpressionExtensions
    {
        internal static string ToPath(this MemberExpression e)
        {
            var path = "";
            var parent = e.Expression as MemberExpression;

            if (parent != null)
                path = parent.ToPath() + ".";

            return path + e.Member.Name;
        }

        internal static MemberExpression GetRightMostMember(this Expression e)
        {
            if (e is LambdaExpression)
                return GetRightMostMember(((LambdaExpression)e).Body);

            if (e is MemberExpression)
                return (MemberExpression)e;

            if (e is MethodCallExpression)
            {
                var callExpression = (MethodCallExpression)e;
                var member = callExpression.Arguments.Count > 0 ? callExpression.Arguments[0] : callExpression.Object;
                return GetRightMostMember(member);
            }

            if (e is UnaryExpression)
            {
                var unaryExpression = (UnaryExpression)e;
                return GetRightMostMember(unaryExpression.Operand);
            }

            throw new Exception(
                ExceptionMessages.ExpressionUtils_GetRightMostMember_NoMemberFound.Inject(e.ToString()));
        }
    }
}