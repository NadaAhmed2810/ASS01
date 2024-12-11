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

            #region variables
            ////5
            //int num = 50;
            #endregion

            #region CLS_CTS
            //int Num = 5;//4 Byte
            //String Name = "Ahmed";//10 Byte
            //Name = "Ali"; // 6 Byte
            #endregion

            #region Value Type
           // int x;//4 Byte
           //// Console.WriteLine(x);
           // x = 0;
           // Console.WriteLine(x);
           // Int32 Y = 9;
           // Y = x;
           // x++;
           // Console.WriteLine(x);
           // Console.WriteLine(Y);


            #endregion

        }
    }
}
