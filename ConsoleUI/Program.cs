using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //IoC
            IProductService productService = new ProductManager(new InMemoryProductDal());
            foreach (var product in productService.GetAll())
            {
                Console.WriteLine(product.Name);
            }
            Console.ReadKey();
        }
    }
}
