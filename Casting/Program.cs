using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SmartPhone smart = new SmartPhone();
            smart.cost = 123;
            phone obj = smart;
            
            Console.WriteLine(obj.cost);

            Console.ReadKey();
        }
    }

    public class phone
    {
        public int id { get; set; }
        public  string releasedate { get; set; }
        public int cost { get; set; }
    }

    public class SmartPhone : phone, ISmartPhone
    {
        public int version { get; set; }
        public int camera { get; set; }

       

    }

    public class BasicPhone : phone, IBasicPhone
    {
        public int simslots { get; set; }
        public bool camera { get; set; }
    }
}
