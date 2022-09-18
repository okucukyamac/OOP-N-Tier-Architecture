﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new(new EfProductDal());

            foreach (var item in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
