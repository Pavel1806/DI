using DI.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Models
{
    public class A
    {
        public int Id { get; set; }
        public string Name { get ; set ; }
        public string Link { get; set; }
        public B GetB { get; set; }
        public A()
        {

        }


    }
}
