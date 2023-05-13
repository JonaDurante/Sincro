using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Sincro.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class TablesServices : ITablesServices
    {
        private readonly SincroDBContext _context;
        public TablesServices(SincroDBContext context)
        {
            _context = context;
        }
        public List<Table> GetAllTables()
        {
            return _context.Tables.ToList();
        }
    }
}
