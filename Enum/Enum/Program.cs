using System;

namespace Enum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Floor.f1);//print it as string
            Console.WriteLine((int)Floor.f1);//print it as int
            //loop in Enum 
            foreach (var f in Enum.GetNames(typeof( Floor)))
            {
                Console.WriteLine($"{f} : {(int)Enum.Parse(typeof(Floor),f)}");
            }
            Console.ReadKey();
        }
    }
    //enum Month //Auto deal With Int but i can change that
    //enum Month:long //become daeling with long 
  //  enum Month:String can not deal with string
    enum Floor
    {
        //f1,//start with 0 and follow uo 1,2,3,etc i can change that as follow
        f1 = 1,
        f2,
        f3,
        f4,
        f5,
        f6,
        f7
    }
}
