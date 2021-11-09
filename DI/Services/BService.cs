using DI.interfaces;
using DI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Services
{
    public class BService : IService<B>
    {
        private readonly AppDbContext _appdb;
        public BService(AppDbContext appdb)
        {
            _appdb = appdb;
        }
        public List<B> GetAll()
        {
             var b = _appdb.Bs.Join(_appdb.As, x=>x.AId, y=>y.Id, 
                (x, y)=> new B
                {
                    Description = x.Description,
                    GetA= new A { Name = y.Name, Link = y.Link}

                }).ToList();
            return b;
        }
    }
}
