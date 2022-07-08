using System;

namespace StructureDemo
{
    struct MyStruct
    {
        //int i = 10; - fields of struct can not initialize at declaration
         int i;
        public MyStruct(int ia)
        {
            i = ia;  
        }
        public void Display()
        {
            Console.WriteLine("Display method inside structure = "+i);
        }

        public static void Main()
        {
            MyStruct s = new MyStruct();
            MyStruct s1 = new MyStruct(100 );
            MyStruct s2;
            s2.i = 1;
            s2.Display();
            s.i = 10;
            s.Display();
            s1.Display();
            Console.ReadLine();
        }
    }
}