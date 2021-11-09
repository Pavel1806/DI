using DI.interfaces;
using DI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Services
{
    public class CService : IService<C>
    {
        private readonly AppDbContext _appdb;
        public CService(AppDbContext appdb)
        {
            _appdb = appdb;
        }
        public List<C> GetAll()
        {

            var c = _appdb.Cs.Join(_appdb.Bs, x => x.BId, y => y.Id,
                (x, y) => new 
                {
                    Description=y.Description,
                    Year = x.Year,
                    AId=y.AId
                     
                }).Join(_appdb.As, x=>x.AId, y=>y.Id,
                (x,y)=>new C
                {
                     Year=x.Year,
                     GetB=new B { Description=x.Description, GetA=new A { Name=y.Name, Link=y.Link} }  
                }
                ).ToList();
            return c;
        }
    }
}
