using Data.Entities;
using Data.Interfaces;
using Sincro.Context;
namespace Data.Services
{
    public class SincroService : ISincroService
    {
        private readonly SincroDBContext _context;
        public SincroService(SincroDBContext context)
        {
            _context = context;
        }



    }
}
