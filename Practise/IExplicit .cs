using System;

namespace Practise
{
    public interface IExplicit
    {
        void A();
        

    }

    public interface IExplicit2
    {
        String A();

    }

    public interface IExplicit3 : IExplicit
    {
        void C();
    }
}