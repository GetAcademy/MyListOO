using System;

namespace MyListOO
{
    internal class MyList
    {
        string[] _string;
        int _count;

        public MyList()
        {
            _string = new string[3];
            _count = 0;
        }

        public void Add(string text)
        {
            if (_count >= _string.Length) Grow();
            _string[_count] = text;
            _count++;
        }

        private void Grow()
        {
            Console.WriteLine($"Dobler kapasitet fra {_string.Length} til {_string.Length * 2}");
            var newStrings = new string[_string.Length * 2];
            Array.Copy(_string, newStrings, _string.Length);
            _string = newStrings;
        }

        public void Show()
        {
            for (int i = 0; i < _string.Length; i++)
            {
                Console.WriteLine($"index {i} => {_string[i]} ");
            }
        }
    }
}
