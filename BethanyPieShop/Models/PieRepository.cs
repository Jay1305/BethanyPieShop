using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _dbcontext;
        public PieRepository(AppDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public IEnumerable<Pie> GetAllPies() => _dbcontext.Pies.OrderBy(d => d.Name).ToList();

        public Pie GetPieById(int pieId) => _dbcontext.Pies.FirstOrDefault(d => d.Id == pieId);
    }
}
