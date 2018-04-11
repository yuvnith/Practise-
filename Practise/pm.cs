using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class pm
    {
        public String Name { get; set; }
        public  int Year { get; set; }


        public pm(String name,int year )
        {
            this.Name = name;
            this.Year = year;
        }

        public override string ToString()
        {
            return String.Format("{0} :{1}", Name, Year);
        }
    }
}
