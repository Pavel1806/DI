using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Models
{
    public class B
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int AId {get; set; }
        public A GetA { get; set; }
        public C GetC { get; set; }
        public B()
        {

        }

    }
}
