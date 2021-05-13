using System;
using System.Linq;

namespace Product.Utility.Data
{
    public class SortProvider<T>
    {
        public static IQueryable<T> Sort(IQueryable<T> items, string propertyName, bool sortDescending)
        {
            if (sortDescending)
            {
                return SortDescending(items, propertyName);
            }
            else
            {
                return SortAscending(items, propertyName);
            }
        }

        private static IQueryable<T> SortAscending(IQueryable<T> items, string propertyName)
        {
            if (items == null)
                return null;

            if (string.IsNullOrEmpty(propertyName))
            {
                return items;
            }

            var type = GetPropertyType(propertyName, typeof(T));//propertyInfo.PropertyType;

            if (type == null)
            {
                return items;
            }

            IQueryable<T> sortedItems = null;

            if (type == typeof(int))
            {
                sortedItems = items.OrderBy(SortExpressionBuilder<T, int>.BuildExpression(propertyName));
            }
            else if (type == typeof(int?))
            {
                sortedItems = items.OrderBy(SortExpressionBuilder<T, int?>.BuildExpression(propertyName));
            }
            else if (type == typeof(string))
            {
                sortedItems = items.OrderBy(SortExpressionBuilder<T, string>.BuildExpression(propertyName));
            }
            else if (type == typeof(DateTime))
            {
                sortedItems = items.OrderBy(SortExpressionBuilder<T, DateTime>.BuildExpression(propertyName));
            }
            else if (type == typeof(DateTime?))
            {
                sortedItems = items.OrderBy(SortExpressionBuilder<T, DateTime?>.BuildExpression(propertyName));
            }

            return sortedItems;
        }

        private static IQueryable<T> SortDescending(IQueryable<T> items, string propertyName)
        {
            if (items == null)
                return null;

            if (string.IsNullOrEmpty(propertyName))
            {
                return items;
            }

            var type = GetPropertyType(propertyName, typeof(T));//propertyInfo.PropertyType;

            if (type == null)
            {
                return items;
            }

            IQueryable<T> sortedItems = null;

            if (type == typeof(int))
            {
                sortedItems = items.OrderByDescending(SortExpressionBuilder<T, int>.BuildExpression(propertyName));
            }
            else if (type == typeof(int?))
            {
                sortedItems = items.OrderByDescending(SortExpressionBuilder<T, int?>.BuildExpression(propertyName));
            }
            else if (type == typeof(string))
            {
                sortedItems = items.OrderByDescending(SortExpressionBuilder<T, string>.BuildExpression(propertyName));
            }
            else if (type == typeof(DateTime))
            {
                sortedItems = items.OrderByDescending(SortExpressionBuilder<T, DateTime>.BuildExpression(propertyName));
            }
            else if (type == typeof(DateTime?))
            {
                sortedItems = items.OrderByDescending(SortExpressionBuilder<T, DateTime?>.BuildExpression(propertyName));
            }

            return sortedItems;
        }

        private static Type GetPropertyType(string name, Type t)
        {
            foreach (var part in name.Split('.'))
            {
                var info = t.GetProperty(part);

                if (info == null)
                {
                    return null;
                }

                t = info.PropertyType;
            }
            return t;
        }
    }
}