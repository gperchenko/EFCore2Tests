using System;
using System.Collections.Generic;
using System.Linq;
using EFTests.DataAccess;
using EFTests.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFTests.ConsoleApp
{
    class Program
    {
        private static readonly TestContext _context = new TestContext();

        static void Main(string[] args)
        {
            //InsertSamurai();
            //InsertMultipleSamurais();
            //SimpleSamuraiQuery();
            //MoreQueries();
            //RetrieveAndUpdateSamurai();
            RetrieveAndUpdateMultipleSamurais();

            Console.ReadKey();
        }

        private static void InsertSamurai()
        {
            var samurai = new Samurai { Name = "Gena 10"};
            
            _context.Samurais.Add(samurai);
            _context.SaveChanges();
           
        }

        private static void InsertMultipleSamurais()
        {
            // as of 2.1 you need at least 4 entries to get batch 
            // effect  

            var list = new List<Samurai>
            {
                {new Samurai {Name = "Gena 110"}},
                {new Samurai {Name = "Gena 220"}},
                {new Samurai {Name = "Gena 330"}},
                {new Samurai {Name = "Gena 440"}}
            };
           
            _context.Samurais.AddRange(list);
            _context.SaveChanges();
            
        }

        private static void SimpleSamuraiQuery()
        {
            var samurais = _context.Samurais.ToList();
        }

        private static void MoreQueries()
        {
            var samurais = _context
                .Samurais.Where(s => s.Name == "Samu1").ToList();

            var samurais2 = _context
                .Samurais.Where(s => EF.Functions.Like(s.Name, "Gena%")).ToList();

            var samurai = _context
                .Samurais.FirstOrDefault(s => s.Name == "Samu1");
        }

        private static void RetrieveAndUpdateSamurai()
        {
            var samurai = _context.Samurais.Find(3);
            samurai.Name += "Sam";
            _context.SaveChanges();
        }

        private static void RetrieveAndUpdateMultipleSamurais()
        {
            var samurais = _context.Samurais.ToList();
            samurais.ForEach(s => s.Name += "Sam");
            _context.ChangeTracker.DetectChanges();

            var a = _context.ChangeTracker.Entries();

            _context.SaveChanges();
        }
    }
}
