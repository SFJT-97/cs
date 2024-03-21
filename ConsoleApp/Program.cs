/* using System;

namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! I'm just getting started");
        }
    }
} */

using System;

namespace Array
{
  class Program
  {
    static void Main(string[] args)
    {

        string[] words1 = new string[3];

        words1[0] = "Hello ";
        words1[1] = "I'm ";
        words1[2] = "getting ";

        string[] words2 = {"World! ", "just ", "started. "};

        string phrase = words1[0] + words2[0] + words1[1] + words2[1] + words1[2] + words2[2];

        Console.WriteLine(phrase);

    }
  }
}