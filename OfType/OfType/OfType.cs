using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfType
{
    internal class OfType : IOfType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            CheckNullArgument(enumerable);
            List<T> listOfType = new List<T>();
            foreach (object item in enumerable)
            {
                if (item is T output)
                {
                    listOfType.Add(output);
                }
            }

            return listOfType;
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
        {
            CheckNullArgument(enumerable);
            List<TOutput> listOfType = new List<TOutput>();
            foreach(TSource item in enumerable)
            {
                if (item is TOutput output)
                {
                    listOfType.Add(output);
                }
            }

            return listOfType;
        }

        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
        {
            CheckNullArgument(derivedItems);
            List<TBase> listOfType = new List<TBase>();
            foreach (TDerived item in derivedItems)
            {
                if (item is TBase targetType)
                {
                    listOfType.Add(targetType);
                }
            }

            return listOfType;
        }

        private static void CheckNullArgument(object value) 
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
        }
    }
}
