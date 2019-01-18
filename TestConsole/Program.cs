using System;
using System.Linq.Expressions;

namespace TestConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<int, int, int> func = (m, n) => m * n + 2;
            Expression<Func<int,int,int>> exp = (m, n) => m * n + 2;

            int result = exp.Compile().Invoke(12,23);
            
         }
        //public static TOut Trans<TOut,TIn>(TIn tin)
        //{

        //}
    }
}
 