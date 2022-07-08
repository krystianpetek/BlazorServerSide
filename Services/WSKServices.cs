using BlazorServerSide.Database;
using BlazorServerSide.Models;

namespace BlazorServerSide.Services
{
    public class WSKServices
    {
        //private WSKDbContext dbContext;

        //public WSKServices(WSKDbContext db)
        //{
        //    dbContext = db;
        //}

        //public Task<WSK> GetInfo(int productionYear) => dbContext.WSKs.FirstOrDefaultAsync(q => q.ProductionYearDate == productionYear);
        //public Task<WSK[]> GetAll() => dbContext.WSKs.ToArrayAsync();
        //public Task<List<int>> GetYear() => dbContext.WSKs.Select(x=>x.ProductionYearDate).ToListAsync();

        private List<WSK> listWSK { get; set; }
        public WSKServices(WSKList lista)
        {
            listWSK = lista.listWSK;
        }
        public IEnumerable<WSK> GetInfo(int productionYear) => listWSK.Where(q => q.ProductionYearDate == productionYear);
        public WSK[] GetAll() => listWSK.ToArray();
        public List<int> GetYear() => listWSK.Select(x => x.ProductionYearDate).ToList();

    }
}
