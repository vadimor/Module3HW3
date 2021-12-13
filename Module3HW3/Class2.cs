using System;

namespace Module3HW3
{
    public class Class2
    {
        private int _result;
        public Func<int, bool> Calc(Func<int, int, int> pow, int x, int y)
        {
            _result = pow.Invoke(x, y);
            return Result;
        }

        private bool Result(int x)
        {
            return _result % x == 0;
        }
    }
}
