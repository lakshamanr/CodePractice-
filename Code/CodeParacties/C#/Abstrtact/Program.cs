using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrtact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAPI1 abb1 = new API1();
            
            abb1.ImplementmeIAPI1();

            IAPI2 abb2 = new API1();
            IAPI3 abb3 = new API1();
            IAPI4 abb4 = new API5();
        }
    }

    public abstract class BaseClass : IAPI1, IAPI2, IAPI3, IGlobal
    {
        public abstract void Implementme();

        public void ImplementmeIAPI1()
        {
            Console.WriteLine("ImplementmeIAPI1 implemented ");
        }

        public void ImplementmeIAPI2()
        {
            Console.WriteLine("ImplementmeIAPI2 implemented ");
        }

        public void ImplementmeIAPI3()
        {
            Console.WriteLine("ImplementmeIAPI2 implemented ");
        }

        public void ImplementmeGlobal()
        {
            throw new NotImplementedException();
        }
    }

    public class API1 : BaseClass
    {
        public override void Implementme()
        {
            Console.WriteLine("ImplementmeAPI1");
        }
    }
    public class API2 : BaseClass
    {
        public override void Implementme()
        {
            Console.WriteLine("ImplementmeAPI1");
        }
    }
    public class API3 : BaseClass
    {
        public override void Implementme()
        {
            Console.WriteLine("ImplementmeAPI1");
        }
    }
    public class API4 : BaseClass
    {
        public override void Implementme()
        {
            Console.WriteLine("ImplementmeAPI1");
        }
    }
    public class API5 : BaseClass, IAPI4
    {
        public override void Implementme()
        {
            Console.WriteLine("ImplementmeAPI1");
        }

        public void ImplementmeIAPI4()
        {
            Console.WriteLine("ImplementmeAPI4");
        }
    }

    public interface IAPI1
    {
        void ImplementmeIAPI1();
    }
    public interface IAPI2
    {
        void ImplementmeIAPI2();
    }
    public interface IAPI3
    {
        void ImplementmeIAPI3();
    }
    public interface IAPI4
    {
        void ImplementmeIAPI4();
    }
    public interface IGlobal
    {
        void ImplementmeGlobal();
    }
}
