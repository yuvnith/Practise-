using System;

namespace Practise
{


    public class ExplicitImplementation : IExplicit, IExplicit2
    {
        public void A()
        {
           Console.WriteLine("void return type ");
        }

        string IExplicit2.A()
        {
            Console.WriteLine("string return type ");
            return "a";
        }
    }

    public class Implementation2 : IExplicit3
    {
        //must also implement A() of IExplicit because IExplicit3 inherits IExplicit
        public void A()
        {
            Console.WriteLine("A() of IExplicit ");
        }

        public void C()
        {
            Console.WriteLine("C() of IExplicit3 ");
        }
    }
}