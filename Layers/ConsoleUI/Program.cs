using DataAccessLayer.DbContexts;
using Models.Entities;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var d = new BookContext())
            {
                var pb = new Publisher()
                {
                    //referans tipli
                    Name = "Dostoyevski",
                    Phone = "12345678998",
                    Email = "dostoyevski1@gmail.com",
                    books = new List<Book>
                    {
                        new Book()
                        {
                             BookId=100,
                             Name="Suç ve ceza",
                             bookPrice="89"
                               
                        },
                        new Book()
                        {
                             BookId=200,
                             Name="insancıklar",
                             bookPrice="69"

                        }
                    }
                };

                d.Publishers.Add(pb);
                d.SaveChanges();
            }
        }
    }
}
//migration ile ilgili komutlar
//Add-Migration firstMigration -outputDir Migrations
//update-database
//Add-Migration addProductDetailField -outputDir Migrations
//remove-migration
//Add-Migration editSupplierFields -outputDir Migrations