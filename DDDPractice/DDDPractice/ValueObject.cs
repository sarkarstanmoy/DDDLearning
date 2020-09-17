using System;
using System.Collections.Generic;
using System.Text;

namespace DDDPractice
{
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        public override bool Equals(object obj)
        {
            var valueObject = obj as T;
            if (ReferenceEquals(valueObject, null))
                return false;
            return EqualsValue(valueObject);
        }

        public abstract bool EqualsValue(T other);

        public static bool operator ==(ValueObject<T> a , ValueObject<T> b)
        {
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(ValueObject<T> a, ValueObject<T> b)
        {
            
            return !(a == b);
        }
    }
}
