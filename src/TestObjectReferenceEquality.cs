namespace TestObjRefEq
{
    using System;
    using System.Collections.Generic;

    class Program
    {

        public static void Main (string[] args)
        {
            List<object> objList = new List<object> ();

            object O0 = new object ();
            object O1 = new object ();
            object O2 = new object ();

            objList.Add (O0);
            objList.Add (O1);
            objList.Add (O2);

            Console.WriteLine (O0);
            Console.WriteLine (O1);
            Console.WriteLine (O2);

            Console.WriteLine (O0 == O1);
            Console.WriteLine (O0 == O2);
            Console.WriteLine (O1 == O2);

            Console.WriteLine (objList.IndexOf (new object ()));
            Console.WriteLine (objList.IndexOf (O0));
            Console.WriteLine (objList.IndexOf (O1));
            Console.WriteLine (objList.IndexOf (O2));
        }
    }
}
