using System;
using System.Linq.Expressions;

namespace Product.Utility.Data
{
    public class SortExpressionBuilder<TType, TSortField>
    {
        public static Expression<Func<TType, TSortField>> BuildExpression(string propertyName)
        {
            var paramExp = Expression.Parameter(typeof(TType));

            var exp = BuildExpression(propertyName, paramExp);

            return Expression.Lambda<Func<TType, TSortField>>(exp, paramExp);
        }

        private static Expression BuildExpression(string propertyName, Expression paramExp)
        {
            var properties = propertyName.Split('.');

            Expression exp = paramExp;

            foreach (var prop in properties)
            {
                exp = Expression.Property(exp, prop);
            }

            return exp;
        }
    }
}