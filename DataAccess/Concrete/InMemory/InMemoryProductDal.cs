using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    { 
        public List<Product> GetAll()
        {
            return new List<Product>
           {
               new Product{Id=1,Name="Laptop"},
               new Product{Id=2,Name="Mouse"}
           };
        }
    }
}
