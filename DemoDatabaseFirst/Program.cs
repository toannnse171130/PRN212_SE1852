using System;
using System.Linq;
using DemoDatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a DbContext object
            MyStoreContext myStore = new MyStoreContext();

            // Print all Products
            var products = from p in myStore.Products
                           select new { p.ProductName, p.CategoryId };

            foreach (var p in products)
            {
                Console.WriteLine($"ProductName: {p.ProductName}, CategoryID: {p.CategoryId}");
            }

            Console.WriteLine("-------------------------------");

            // A query to get all Categories and their related Products
            IQueryable<Category> cats = myStore.Categories.Include(c => c.Products);
            foreach (Category c in cats)
            {
                Console.WriteLine($"CategoryId: {c.CategoryId} has {c.Products.Count} products.");
            }

            Console.ReadLine();
            Category c1 = myStore.Categories.FirstOrDefault(c => c.CategoryId == 14);

            if (c1 != null)
            {
                myStore.Categories.Remove(c1);
                myStore.SaveChanges();
            }

        } // end Main
    } // end Class
}
