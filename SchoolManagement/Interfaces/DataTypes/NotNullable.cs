using System;

namespace Interfaces.DataTypes
{
    public struct NotNullable<T>
        where T : class
    {
        private readonly T _value;

        public NotNullable(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            _value = value;
        }

        public T Value
        {
            get
            {
                if (_value == null)
                {
                    throw new NullReferenceException();
                }
                return _value;
            }
        }

        public static implicit operator NotNullable<T>(T value)
        {
            return new NotNullable<T>(value);
        }

        public static implicit operator T(NotNullable<T> wrapper)
        {
            return wrapper.Value;
        }
    }
}
