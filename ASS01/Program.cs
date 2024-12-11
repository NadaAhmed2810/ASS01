using System.ComponentModel;
using System.Drawing;

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
            #region Reference Type
            //Point P01;
            //P01= new Point();

            //Point P02=new Point();
            //P02 = P01;
            //P01.X = 10;
            //P01.Y= 20;
            //Console.WriteLine(P02.X);
            #endregion
            #region Object
            //object obj = new object();
            //obj = 1;
            //obj = 'C';
            //obj = "Ahmed";
            //obj = true;
            //object obj02=new object();
            //Console.WriteLine(obj02.GetHashCode());
            //Console.WriteLine(obj.GetHashCode());
            //obj02 = obj;
            //Console.WriteLine(obj02.GetHashCode());
            //Console.WriteLine(obj.GetHashCode());
            #endregion
            #region fractions and Discard
           //// int Num01 = 1234556789999;
           // long Num02 = 12345667788888;
           // double Num03 = 22.2;
           // float Num04 = 22.2f;
           // decimal Num05 = 22.2M;
           // int Num06 = 1_000_000;
           // Console.WriteLine(Num06);
            #endregion
        }
    }
}
