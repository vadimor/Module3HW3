using System;

namespace Module3HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var prog = new Program();
            var class1 = new Class1 { Show = prog.Show };
            var class2 = new Class2();
            var result = class2.Calc(class1.Pow, 10, 5).Invoke(5);
            class1.Show.Invoke(result);
        }

        public void Show(bool result)
        {
            Console.WriteLine(result);
        }
    }
}
