using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
        //public olarak açıyoruz
    {
        //get; veriye başka yerden ulaşabilmek için, set veriye değer vermek için

        public long Tc { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

    }
}
