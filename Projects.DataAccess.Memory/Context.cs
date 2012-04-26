using System;
using System.Linq;
using System.Collections.Generic;

using Projects.DataAccess.Memory.Entities;

namespace Projects.DataAccess.Memory
{
    internal class Context
    {
        private Dictionary<Type, object> Lists;

        public IList<T> Set<T>()
        {
            if (!Lists.ContainsKey(typeof(T)))
            {
                Lists.Add(typeof(T), new List<T>());
            }

            return (IList<T>)Lists[typeof(T)];
        }

        public Context()
        {
            Lists = new Dictionary<Type, object>(new TypeComparer());
        }

        class TypeComparer : IEqualityComparer<Type>
        {
            public bool Equals(Type x, Type y)
            {
                return x.FullName == y.FullName;
            }

            public int GetHashCode(Type obj)
            {
                return obj.FullName.GetHashCode();
            }
        }
    }
}