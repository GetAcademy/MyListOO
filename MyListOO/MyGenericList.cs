using System;

namespace MyListOO
{
    internal class MyGenericList<T>
    {
        T[] _values;
        int _count;

        public MyGenericList()
        {
            _values = new T[3];
            _count = 0;
        }

        public void Add(T value)
        {
            if (_count >= _values.Length) Grow();
            _values[_count] = value;
            _count++;
        }

        private void Grow()
        {
            Console.WriteLine($"Dobler kapasitet fra {_values.Length} til {_values.Length * 2}");
            var newValues = new T[_values.Length * 2];
            Array.Copy(_values, newValues, _values.Length);
            _values = newValues;
        }

        public void Show()
        {
            for (int i = 0; i < _values.Length; i++)
            {
                Console.WriteLine($"index {i} => {_values[i]} ");
            }
        }
    }

}

