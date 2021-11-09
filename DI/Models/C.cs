using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Models
{
    public class C
    { 
        public int Id { get; set; }
        public int Year{ get; set; }
        public int BId { get; set; }
        public B GetB { get; set; }

        public C()
        {

        }
       
    }
}
