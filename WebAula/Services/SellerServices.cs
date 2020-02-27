using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAula.Data;
using WebAula.Models;

namespace WebAula.Services
{
    public class SellerServices
    {
        private readonly WebAulaContext _context;

        public SellerServices(WebAulaContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
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
