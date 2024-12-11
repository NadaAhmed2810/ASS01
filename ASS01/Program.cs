using System.ComponentModel;

namespace ASS01
{
    internal class Program
    {
        static int  Sum(int x,int y)
        {
            return x - y;
        }
        static void Main(string[] args)
        {
            #region Error Types_complication Error
            #region Syntax error
            //Console.WriteLine("hello");
            //intt x = 5;
            #endregion
            #region RunTime Error
            //int x = 10, y = 0;
            //Console.WriteLine(x/y);
            #endregion
            #region Logical Error
            //int x = 20, y = 40;
            //Console.WriteLine(Sum(x,y));
            #endregion
            #region Warning Error
            //int x = 5;//4 Byte

            #endregion
            #endregion
        }
    }
}
