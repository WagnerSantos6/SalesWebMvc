using SalesWeb.Data;
using SalesWeb.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWeb.Services
{
    public class SellerService
    {
        private readonly SalesWebContext _context;

        public SellerService(SalesWebContext context)
        {
            _context = context; 
        }

        public List<Seller>  FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges(); 
        }
    }
}
