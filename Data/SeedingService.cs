using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Departament.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //DB has been seede
            }

            Departament d1 = new Departament(1, "Tecnology");
            Departament d2 = new Departament(2, "Food");
            Departament d3 = new Departament(3, "Books");
            Departament d4 = new Departament(4, "Drinks");

            Seller s1 = new Seller(1, "Fulano da Silva", "fulano@gmail.com", new DateTime(1992, 10, 23), 1000, d1);
            Seller s2 = new Seller(2, "Beltrano da Silva", "beltrano@gmail.com", new DateTime(1981, 06, 23), 1000, d2);
            Seller s3 = new Seller(3, "Cicrano da Silva", "cicrano@gmail.com", new DateTime(1972, 08, 15), 1000, d3);
            Seller s4 = new Seller(4, "João da Silva", "joao@gmail.com", new DateTime(1998, 03, 23), 1000, d4);
            Seller s5 = new Seller(5, "José da Silva", "jose@gmail.com", new DateTime(1985, 12, 23), 1000, d1);
            Seller s6 = new Seller(6, "Maria da Silva", "maria@gmail.com", new DateTime(1990, 07, 21), 1000, d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 2999.99, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(1, new DateTime(2019, 07, 15), 1099.99, SaleStatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(1, new DateTime(2018, 10, 18), 500.50, SaleStatus.Billed, s2);
            SalesRecord r4 = new SalesRecord(1, new DateTime(2018, 11, 27), 600.75, SaleStatus.Billed, s2);
            SalesRecord r5 = new SalesRecord(1, new DateTime(2019, 09, 25), 1099.99, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(1, new DateTime(2017, 10, 19), 11000, SaleStatus.Canceled, s3);
            SalesRecord r7 = new SalesRecord(1, new DateTime(2020, 03, 21), 11000, SaleStatus.Billed, s4);
            SalesRecord r8 = new SalesRecord(1, new DateTime(2018, 09, 25), 2999.99, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(1, new DateTime(2018, 09, 25), 1799.99, SaleStatus.Billed, s5);
            SalesRecord r10 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000, SaleStatus.Billed, s5);
            SalesRecord r11 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000, SaleStatus.Canceled, s6);
            SalesRecord r12 = new SalesRecord(1, new DateTime(2018, 09, 25), 1799.99, SaleStatus.Billed, s6);
            SalesRecord r13 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(1, new DateTime(2017, 10, 19), 500.50, SaleStatus.Peding, s2);
            SalesRecord r15 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000, SaleStatus.Billed, s3);
            SalesRecord r16 = new SalesRecord(1, new DateTime(2018, 09, 25), 1799.99, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(1, new DateTime(2019, 07, 15), 500.50, SaleStatus.Billed, s5);

            _context.Departament.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17);
            _context.SaveChanges();
        }
    }
}
