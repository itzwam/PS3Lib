using System;
using PS3Lib;

namespace HelloWorld
{
    class Program
    {

        private static CCAPI PS3 = new CCAPI();

        static void Main(string[] args)
        {
            PS3.ConnectTarget();
        }
    }
}
