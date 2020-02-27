using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAula.Data;
using WebAula.Models;

namespace WebAula.Services
{
    public class DepartmentServices
    {
        private readonly WebAulaContext _context;

        public DepartmentServices(WebAulaContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
